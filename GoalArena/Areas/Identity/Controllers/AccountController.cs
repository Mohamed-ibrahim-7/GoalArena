using GoalArena.Models;
using GoalArena.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;

namespace GoalArena.Areas.Identity.Controllers
{
    [Area("Identity")]
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IEmailSender _emailSender;
        private readonly SignInManager<ApplicationUser> _signInManager;
        // private readonly IUserOTPRepository _userOTPRepository;

        public AccountController(UserManager<ApplicationUser> userManager, IEmailSender emailSender, SignInManager<ApplicationUser> signInManager //IUserOTPRepository userOTPRepository)
        ){
            _userManager = userManager;
            _emailSender = emailSender;
            _signInManager = signInManager;
           // _userOTPRepository = userOTPRepository;
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
               // var token = await _userManager.GenerateEmailConfirmationTokenAsync(applicationUser);
              //  var link = Url.Action(nameof(ConfirmEmail), "Account", new { area = "Identity", token = token, userId = applicationUser.Id }, Request.Scheme);
              //  await _emailSender.SendEmailAsync(registerVM.Email, "Confirm Your Account", $"<h1>Confirm Your Account By Clicking <a href='{link}'>Here</a></h1>");

              //  await _userManager.AddToRoleAsync(applicationUser, SD.Customer);

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

    }
}
