using Booking_Backend.Data.EF;
using Booking_Backend.Data.Entities;
using Booking_Backend.Repository.Users.Validator;
using Booking_Backend.Utilities.Constants;
using Booking_Frontend.AdminApp.Service.APIFree;
using Booking_Frontend.APIIntegration.BedService;
using Booking_Frontend.APIIntegration.BookingCartService;
using Booking_Frontend.APIIntegration.BookingService;
using Booking_Frontend.APIIntegration.CommentService;
using Booking_Frontend.APIIntegration.EmailService;
using Booking_Frontend.APIIntegration.ExtensionRoom;
using Booking_Frontend.APIIntegration.ExtensionTypeRoom;
using Booking_Frontend.APIIntegration.FormatMoney;
using Booking_Frontend.APIIntegration.HotelService;
using Booking_Frontend.APIIntegration.HotelType;
using Booking_Frontend.APIIntegration.Language;
using Booking_Frontend.APIIntegration.LocationService;
using Booking_Frontend.APIIntegration.Profile;
using Booking_Frontend.APIIntegration.RoomService;
using Booking_Frontend.APIIntegration.RoomType;
using Booking_Frontend.APIIntegration.ServiceHotel;
using Booking_Frontend.APIIntegration.User;
using Booking_Frontend.APIIntegration.ViewService;
using Booking_Frontend.WebApp.LocalizationResources;
using Booking_Frontend.WebApp.Service.VnPayService;
using FluentValidation.AspNetCore;
using LazZiya.ExpressLocalization;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
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
            services.AddHttpContextAccessor();
            var cultures = new[]
            {
                new CultureInfo("en-US"),
                new CultureInfo("vi-VN"),
            };
            services.AddDbContext<BookingContext>(options =>
            options.UseSqlServer("Server=DESKTOP-JRGDO84\\SQLEXPRESS;Database=Booking_DB;Trusted_Connection=True;"));
            services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<BookingContext>()
                .AddDefaultTokenProviders();
            services.AddScoped<UserManager<AppUser>, UserManager<AppUser>>();
            services.AddScoped<SignInManager<AppUser>, SignInManager<AppUser>>();
            services.AddScoped<RoleManager<AppRole>, RoleManager<AppRole>>();

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
            })
                .AddGoogle(googleOptions =>
                {
                    var googleAuthNSection = Configuration.GetSection("Authentication:Google");
                    googleOptions.ClientId = googleAuthNSection["ClientId"];
                    googleOptions.ClientSecret = googleAuthNSection["ClientSecret"];
                    googleOptions.SaveTokens = true;
                    googleOptions.CallbackPath = "/dang-nhap-tu-google";
                })
                .AddFacebook(opt =>
                {
                    var googleAuthNSection = Configuration.GetSection("Authentication:Facebook");
                    opt.ClientId = googleAuthNSection["ClientId"];
                    opt.ClientSecret = googleAuthNSection["ClientSecret"];
                    opt.CallbackPath = "/dang-nhap-tu-facebook";

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
            services.AddScoped<ILocationClientService, LocationClientService>();
            services.AddScoped<IHotelClientService, HotelClientService>();
            services.AddScoped<IBookingClientService, BookingClientService>();
            services.AddScoped<IRoomClientService, RoomClientService>();
            services.AddScoped<IExtensionTypeRoomClientService, ExtensionTypeRoomClientService>();
            services.AddScoped<IFormatMoney, FormatMoney>();
            services.AddScoped<IViewClientService, ViewClientService>();
            services.AddScoped<IEmailServiceClient, EmailServiceClient>();
            services.AddScoped<ICommentClientService, CommentClientService>();
            services.AddScoped<IBookingCartClientService, BookingCartClientService>();
            services.AddSingleton<IVnPayService, VnPayService>();
            services.AddSession(option =>
            {
                option.IdleTimeout = TimeSpan.FromHours(3);
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
                endpoints.MapControllerRoute(
                    name: "default2",
                    pattern: "{controller=home}/{action=index}/{id?}");
                endpoints.MapControllerRoute(
                    name: "authCallback",
                    pattern: "vi-VN/Auth/OnGetCallbackAsync",
                    defaults: new { controller = "Auth", action = "OnGetCallbackAsync" }
    );

                //endpoints.MapControllerRoute(
                //    name: "Step 1 booking",
                //    pattern: "{culture}/owner/{id?}", new
                //    {
                //        controller = "HomeOwner",
                //        action = "Index"
                //    });
            });
        }
    }
}
