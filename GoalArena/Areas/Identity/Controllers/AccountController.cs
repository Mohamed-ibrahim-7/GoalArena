using GoalArena.Models;
using GoalArena.Repositories.IRepositories;
using GoalArena.Utility;
using GoalArena.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace GoalArena.Areas.Identity.Controllers
{
    [Area("Identity")]
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IEmailSender _emailSender;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IUserOTPRepository _userOTPRepository;

        public AccountController(UserManager<ApplicationUser> userManager, IEmailSender emailSender, SignInManager<ApplicationUser> signInManager, IUserOTPRepository userOTPRepository)
        {
            _userManager = userManager;
            _emailSender = emailSender;
            _signInManager = signInManager;
            _userOTPRepository = userOTPRepository;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (!ModelState.IsValid)
            {
                return View(registerVM);
            }

            ApplicationUser applicationUser = new()
            {
                UserName = registerVM.UserName,
                Email = registerVM.Email,
                FirstName = registerVM.FirstName,
                LastName = registerVM.LastName,
                Address = registerVM.Address
            };

            //ApplicationUser applicationUser2 = registerVM.Adapt<ApplicationUser>();

            var result = await _userManager.CreateAsync(applicationUser, registerVM.Password);

            if (result.Succeeded)
            {
                // Send Email
                var token = await _userManager.GenerateEmailConfirmationTokenAsync(applicationUser);
                var link = Url.Action(nameof(ConfirmEmail), "Account", new { area = "Identity", token = token, userId = applicationUser.Id }, Request.Scheme);
                await _emailSender.SendEmailAsync(registerVM.Email, "Confirm Your Account", $"<h1>Confirm Your Account By Clicking <a href='{link}'>Here</a></h1>");

                await _userManager.AddToRoleAsync(applicationUser, SD.Customer);

                // Send msg
                TempData["success-notification"] = "Add Account Successfully, Confirm Your Account!";
                return RedirectToAction(nameof(Index), "Home", new { area = "Customer" });
            }

            foreach (var item in result.Errors)
            {
                ModelState.AddModelError(string.Empty, item.Description);
            }
            //TempData["error-notification"] = String.Join(", ", result.Errors.Select(e=>e.Description));

            return View(registerVM);
        }

        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            var user = await _userManager.FindByIdAsync(userId);

            if (user is not null)
            {
                var result = await _userManager.ConfirmEmailAsync(user, token);

                if (result.Succeeded)
                    return View();

                TempData["error-notification"] = String.Join(", ", result.Errors.Select(e => e.Description));
                return RedirectToAction(nameof(Index), controllerName: "Home", new { area = "Customer" });
            }

            return NotFound();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (!ModelState.IsValid)
            {
                return View(loginVM);
            }

            var user = await _userManager.FindByEmailAsync(loginVM.EmailORUserName) ?? await _userManager.FindByNameAsync(loginVM.EmailORUserName);

            if (user is not null)
            {
                var result = await _signInManager.PasswordSignInAsync(user.UserName, loginVM.Password, loginVM.RememberMe, lockoutOnFailure: true);

                if (result.Succeeded)
                {
                    TempData["success-notification"] = "Login Successfully";
                    return RedirectToAction(nameof(Index), "Home", new { area = "Customer" });
                }

                if (!user.EmailConfirmed)
                {
                    ModelState.AddModelError(string.Empty, "Confirm Your Account!");
                    return View(loginVM);
                }

                if (result.IsLockedOut)
                {
                    ModelState.AddModelError(string.Empty, "Too Many Attempts");
                    return View(loginVM);
                }
            }

            ModelState.AddModelError(string.Empty, "Invalid User Name Or Password");
            return View(loginVM);
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            TempData["success-notification"] = "Logout Successfully";
            return RedirectToAction(nameof(Index), "Home", new { area = "Customer" });
        }

        public IActionResult ResendEmailConfirmation()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ResendEmailConfirmation(ResendEmailConfirmationVM resendEmailConfirmationVM)
        {
            if (!ModelState.IsValid)
                return View(resendEmailConfirmationVM);

            ApplicationUser user = null;

            // Check if input is email or username
            if (resendEmailConfirmationVM.EmailORUserName.Contains("@"))
            {
                // Avoid "Sequence contains more than one element"
                user = await _userManager.Users
                    .FirstOrDefaultAsync(u => u.Email == resendEmailConfirmationVM.EmailORUserName);
            }
            else
            {
                user = await _userManager.FindByNameAsync(resendEmailConfirmationVM.EmailORUserName);
            }

            if (user != null)
            {
                var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                var link = Url.Action(nameof(ConfirmEmail), "Account",
                    new { area = "Identity", token = token, userId = user.Id },
                    Request.Scheme);

                await _emailSender.SendEmailAsync(user.Email!, "Confirm Your Account",
                    $"<h1>Confirm Your Account By Clicking <a href='{link}'>Here</a></h1>");
            }

            TempData["success-notification"] = "Confirm Your Account Again!";
            return RedirectToAction(nameof(Index), "Home", new { area = "Customer" });
        }

        public IActionResult ForgetPassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ForgetPassword(ForgetPasswordVM forgetPasswordVM)
        {
            if (!ModelState.IsValid)
            {
                return View(forgetPasswordVM);
            }

            var user = await _userManager.Users
                .FirstOrDefaultAsync(u => u.Email == forgetPasswordVM.EmailORUserName)
                ?? await _userManager.FindByNameAsync(forgetPasswordVM.EmailORUserName);

            if (user == null)
            {
                TempData["error-notification"] = "User not found";
                return View(forgetPasswordVM);
            }

            var userOTP = await _userOTPRepository.GetAsync(e => e.ApplicationUserId == user.Id);

            var totalOTPs = userOTP.Count(e =>
                e.Date.Day == DateTime.UtcNow.Day &&
                e.Date.Month == DateTime.UtcNow.Month &&
                e.Date.Year == DateTime.UtcNow.Year);

            if (totalOTPs < 3)
            {
                var OTPNumber = new Random().Next(1000, 9999);

                await _emailSender.SendEmailAsync(
                    user.Email!,
                    "Reset Password",
                    $"<h1>Reset Password Using OTP Number {OTPNumber}</h1>"
                );

                await _userOTPRepository.CreateAsync(new()
                {
                    Code = OTPNumber.ToString(),
                    Date = DateTime.UtcNow,
                    ExpirationDate = DateTime.UtcNow.AddHours(1),
                    ApplicationUserId = user.Id
                });
                await _userOTPRepository.CommitAsync();

                TempData["RedirectToAction"] = Guid.NewGuid().ToString();
                return RedirectToAction(nameof(ResetPassword), new { userId = user.Id });
            }

            TempData["error-notification"] = "Too Many Requests, Please try again later";
            return View(forgetPasswordVM);
        }

        public IActionResult ResetPassword(string userId)
        {
            if (TempData["RedirectToAction"] is not null)
            {
                if (userId is not null)
                {
                    return View(new ResetPasswordVM()
                    {
                        UserId = userId
                    });
                }

            }

            return BadRequest();
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordVM resetPasswordVM)
        {
            var userOTP = (await _userOTPRepository.GetAsync(e => e.ApplicationUserId == resetPasswordVM.UserId)).OrderBy(e => e.Id).LastOrDefault();

            if (userOTP is not null)
            {
                if (DateTime.UtcNow < userOTP.ExpirationDate && !userOTP.Status && userOTP.Code == resetPasswordVM.Code)
                {
                    TempData["RedirectToAction"] = Guid.NewGuid().ToString();
                    return RedirectToAction(nameof(ChangePassword), new { userId = userOTP.ApplicationUserId! });
                }
            }

            // Error
            ModelState.AddModelError(string.Empty, "Invalid Code");
            return View(resetPasswordVM);
        }

        public IActionResult ChangePassword(string userId)
        {
            if (TempData["RedirectToAction"] is not null)
            {
                return View(new ChangePasswordVM()
                {
                    UserId = userId
                });
            }

            return BadRequest();
        }

        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordVM changePasswordVM)
        {
            if (!ModelState.IsValid)
            {
                return View(changePasswordVM);
            }

            var user = await _userManager.FindByIdAsync(changePasswordVM.UserId);

            if (user is not null)
            {
                var token = await _userManager.GeneratePasswordResetTokenAsync(user);
                await _userManager.ResetPasswordAsync(user, token, changePasswordVM.Password);

                // Send msg
                TempData["success-notification"] = "Reset Password Successfully";
                return RedirectToAction(nameof(Index), "Home", new { area = "Customer" });
            }

            return NotFound();
        }
        public IActionResult UserProfile()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;

            var model = new UserProfileVM
            {
                UserName = claimsIdentity.FindFirst(ClaimTypes.Name)?.Value,
                Email = claimsIdentity.FindFirst(ClaimTypes.Email)?.Value
              
            };
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ExternalLogin(string provider, string returnUrl = null)
        {
            var redirectUrl = Url.Action(nameof(ExternalLoginCallback), "Account", new { returnUrl });
            var properties = _signInManager.ConfigureExternalAuthenticationProperties(provider, redirectUrl);
            return Challenge(properties, provider);
        }
        [HttpGet]
        public async Task<IActionResult> ExternalLoginCallback(string returnUrl = null, string remoteError = null)
        {
            if (remoteError != null)
            {
                ModelState.AddModelError(string.Empty, $"Error from external provider: {remoteError}");
                return RedirectToAction(nameof(Login));
            }

            var info = await _signInManager.GetExternalLoginInfoAsync();
            if (info == null)
            {
                return RedirectToAction(nameof(Login));
            }

            var signInResult = await _signInManager.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey, isPersistent: false);
            if (signInResult.Succeeded)
            {
                return LocalRedirect(returnUrl ?? "/");
            }

            var email = info.Principal.FindFirstValue(ClaimTypes.Email);
            var name = info.Principal.FindFirstValue(ClaimTypes.Name);

            if (email != null)
            {
                var user = await _userManager.FindByEmailAsync(email);
                if (user == null)
                {
                    user = new ApplicationUser
                    {
                        UserName = name.Replace(" ", ""),
                        Email = email,
                        LastName = name,
                        FirstName = string.Empty
                    };

                    var createUserResult = await _userManager.CreateAsync(user);
                    if (!createUserResult.Succeeded)
                    {
                        ModelState.AddModelError(string.Empty, "Error creating user.");
                        return RedirectToAction(nameof(Login));
                    }
                }

                var existingLogins = await _userManager.GetLoginsAsync(user);
                if (!existingLogins.Any(l => l.LoginProvider == info.LoginProvider))
                {
                    var addLoginResult = await _userManager.AddLoginAsync(user, info);
                    if (!addLoginResult.Succeeded)
                    {
                        ModelState.AddModelError(string.Empty, "Error linking external login.");
                        return RedirectToAction(nameof(Login));
                    }
                }

                var claims = await _userManager.GetClaimsAsync(user);
                if (!claims.Any(c => c.Type == ClaimTypes.Name))
                {
                    await _userManager.AddClaimAsync(user, new Claim(ClaimTypes.Name, name));
                }

                await _signInManager.SignInAsync(user, isPersistent: false);
                return LocalRedirect(returnUrl ?? "/");
            }

            return RedirectToAction(nameof(Login));
        }


    }
}