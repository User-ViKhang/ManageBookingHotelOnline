using Booking_Backend.Repository.Users.Validator;
using Booking_Frontend.AdminApp.Service.APIFree;
using Booking_Frontend.APIIntegration.BedService;
using Booking_Frontend.APIIntegration.ExtensionRoom;
using Booking_Frontend.APIIntegration.ExtensionTypeRoom;
using Booking_Frontend.APIIntegration.HotelType;
using Booking_Frontend.APIIntegration.Language;
using Booking_Frontend.APIIntegration.Profile;
using Booking_Frontend.APIIntegration.RoomType;
using Booking_Frontend.APIIntegration.ServiceHotel;
using Booking_Frontend.APIIntegration.User;
using Booking_Frontend.WebApp.LocalizationResources;
using FluentValidation.AspNetCore;
using LazZiya.ExpressLocalization;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Booking_Frontend.WebApp
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
            services.AddHttpClient();
            var cultures = new[]
            {
                new CultureInfo("en-US"),
                new CultureInfo("vi-VN"),
            };

            services.AddControllersWithViews()
                .AddExpressLocalization<ExpressLocalizationResource, ViewLocalizationResource>(ops =>
                {
                    ops.UseAllCultureProviders = false;
                    ops.ResourcesPath = "LocalizationResources";
                    ops.RequestLocalizationOptions = o =>
                    {
                        o.SupportedCultures = cultures;
                        o.SupportedUICultures = cultures;
                        o.DefaultRequestCulture = new RequestCulture("vi-VN");
                    };
                }
            )

                .AddRazorRuntimeCompilation()
                .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<LoginValidator>());
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(option =>
            {
                option.LoginPath = "/auth/login";
                option.AccessDeniedPath = "/home/index";
            });
            services.AddScoped<IUserAPI, UserAPI>();
            services.AddScoped<IAPIFree, APIFree>();
            services.AddScoped<IProfileClientService, ProfileClientService>();
            services.AddScoped<ILanguageClientService, LanguageClientService>();
            services.AddScoped<IHotelTypeClientService, HotelTypeClientService>();
            services.AddScoped<IServiceHotelClientService, ServiceHotelClientService>();
            services.AddScoped<IRoomTypeClientService, RoomTypeClientService>();
            services.AddScoped<IExtensionTypeRoomClientService, ExtensionTypeRoomClientService>();
            services.AddScoped<IExtensionRoomClientService, ExtensionRoomClientService>();
            services.AddScoped<IBedClientService, BedClientService>();
            services.AddSession(option =>
            {
                option.IdleTimeout = TimeSpan.FromMinutes(10);
            });

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseRouting();

            app.UseAuthorization();

            app.UseRequestLocalization();

            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{culture=vi-VN}/{controller=home}/{action=index}/{id?}");

            });
        }
    }
}
