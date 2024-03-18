using Booking_Backend.Data.Entities;
using Booking_Backend.Repository.Users.Validator;
using Booking_Frontend.AdminApp.Service.APIFree;
using Booking_Frontend.AdminApp.Service.BedType;
using Booking_Frontend.AdminApp.Service.ExtensionRoom;
using Booking_Frontend.AdminApp.Service.ExtensionTypeRoom;
using Booking_Frontend.AdminApp.Service.HotelType;
using Booking_Frontend.AdminApp.Service.Language;
using Booking_Frontend.AdminApp.Service.Profile;
using Booking_Frontend.AdminApp.Service.RoomType;
using Booking_Frontend.AdminApp.Service.ServiceHotel;
using Booking_Frontend.AdminApp.Service.User;
using FluentValidation.AspNetCore;
using LazZiya.ExpressLocalization;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Booking_Frontend.AdminApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHttpClient();
            services.AddControllersWithViews()
                .AddRazorRuntimeCompilation()
                .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<LoginValidator>());
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(option =>
            {
                option.LoginPath = "/user/login";
                option.AccessDeniedPath = "/";
            });
            services.AddScoped<IUserAPI, UserAPI>();
            services.AddScoped<IAPIFree, APIFree>();
            services.AddScoped<IProfileClientService, ProfileClientService>();
            services.AddScoped<ILanguageClientService, LanguageClientService>();
            services.AddScoped<IHotelTypeClientService, HotelTypeClientService>();
            services.AddScoped<IServiceHotelClientService, ServiceHotelClientService>();
            services.AddScoped<IRoomTypeClientService, RoomTypeClientService>();
            services.AddScoped<IBedTypeClientService, BedTypeClientService>();
            services.AddScoped<IExtensionTypeRoomClientService, ExtensionTypeRoomClientService>();
            services.AddScoped<IExtensionRoomClientService, ExtensionRoomClientService>();
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

            app.UseStaticFiles();

            app.UseAuthorization();

            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}