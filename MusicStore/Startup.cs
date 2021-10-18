using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MusicStore.Data;
using MusicStore.Data.IRepositories;
using MusicStore.Data.Repositories;
using MusicStore.Models; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MusicStore.Services.EmailSender;
using Microsoft.AspNetCore.Http.Features;
using MusicStore.Security;
using MusicStore.Mapping;
using MusicStore.Services.ShoppingCart;
using Microsoft.AspNetCore.Http;

namespace MusicStore
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.SignIn.RequireConfirmedAccount = true;

                options.Tokens.EmailConfirmationTokenProvider = "CustomEmailProvider";

                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(15);
            })
            .AddRoles<IdentityRole>()
            .AddEntityFrameworkStores<ApplicationDbContext>()
            .AddDefaultTokenProviders()
            .AddTokenProvider<CustomEmailConfirmationTokenProvider<ApplicationUser>>("CustomEmailProvider");

            services.Configure<DataProtectionTokenProviderOptions>(o =>
                o.TokenLifespan = TimeSpan.FromHours(5)
            );

            services.Configure<CustomEmailConfirmationTokenProviderOptions>(o =>
                o.TokenLifespan = TimeSpan.FromDays(1)
            );

            services.AddControllersWithViews();

            //Shopping cart
            services.AddTransient<IShoppingCart>(sp => ShoppingCart.GetCart(sp.GetRequiredService<IUnitOfWork>(), sp.GetRequiredService<IHttpContextAccessor>().HttpContext));

            //Data access
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            //Authentication
            services.AddAuthentication()
                .AddFacebook(options =>
                {
                    options.AppId= "";
                    options.AppSecret = "";
                });

            //Email service
            services.AddSingleton(emailConfig => Configuration.GetSection("EmailConfiguration").Get<EmailConfiguration>());
            services.AddScoped<IEmailSender, EmailSender>();

            services.Configure<FormOptions>(o => {
                o.ValueLengthLimit = int.MaxValue;
                o.MultipartBodyLengthLimit = int.MaxValue;
                o.MemoryBufferThreshold = int.MaxValue;
            });

            //AutoMapper
            services.AddAutoMapper(typeof(MappingProfile));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseStatusCodePagesWithReExecute("/Error/{0}");

                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            SeedData.SeedUsersAndRoles(userManager, roleManager);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Albums}/{action=Index}/{id?}"
                );

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
