using GoalArena.Data;
using GoalArena.Models;
using GoalArena.Repositories;
using GoalArena.Repositories.IRepositories;
using GoalArena.Utility;
using GoalArena.Utility.DBInitializer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Stripe;
using System.Configuration;

namespace GoalArena
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            // 2. Add Identity
            builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.Password.RequireNonAlphanumeric = false;
                options.SignIn.RequireConfirmedEmail = true;
            })

                  .AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();
            // login by Google
            builder.Services.AddAuthentication().AddGoogle("google", opt =>
            {
                var googleAuth = builder.Configuration.GetSection("Authentication:Google");
                opt.ClientId = googleAuth["ClientId"];
                opt.ClientSecret = googleAuth["ClientSecret"];
                opt.SignInScheme = IdentityConstants.ExternalScheme;

                // ????? ????? ?????? ?????? ??????
                opt.Events.OnRedirectToAuthorizationEndpoint = context =>
                {
                    context.Response.Redirect(context.RedirectUri + "&prompt=select_account");
                    return Task.CompletedTask;
                };
            });

            // 3. Configure authentication cookies
            builder.Services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/Identity/Account/Login";
                options.AccessDeniedPath = "/Identity/Account/AccessDenied";
            });
            builder.Services.AddTransient<IEmailSender, EmailSender>();


            builder.Services.AddScoped<ImatchRepository, MatchRepository>();   
            builder.Services.AddScoped<IPlayerRepository, PlayerRepository>();
            builder.Services.AddScoped<ISeasonRepository, SeasonRepository>();
            builder.Services.AddScoped<IUserOTPRepository, UserOTPRepository>();
            builder.Services.AddScoped<ITeamRepository, TeamRepository>();
            builder.Services.AddScoped<IDBInitializer, DBInitializer>();
            builder.Services.AddScoped<IMatchEventRepository, MatcheventRepository >();
            builder.Services.AddScoped<ITicketRepository, TicketRepository>();
            builder.Services.AddScoped<ITournamentRepository, TournamentRepository >();
            builder.Services.AddScoped<InewsRepository, NewsRepository>();
            builder.Services.Configure<StripeSettings>(builder.Configuration.GetSection("Stripe"));
            StripeConfiguration.ApiKey = builder.Configuration["Stripe:SecretKey"];

            var app = builder.Build();

            // Configure the HTTP request pipelinez      ccccccccv bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();


            using (var scope = app.Services.CreateScope())
            {
                var dbInitializer = scope.ServiceProvider.GetRequiredService<IDBInitializer>();
                dbInitializer.Initialize();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                 name: "default",
                 pattern: "{area=Customer}/{controller=Home}/{action=Index}/{id?}")
                 .WithStaticAssets();

            app.Run();

        }
    }
}
