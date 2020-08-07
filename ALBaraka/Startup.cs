using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using ALBaraka.Models;
using ALBaraka.Repositories.UnitOfWork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace ALBaraka
{
    public class Startup
    {
        private IConfiguration configuration;

        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //Adding Localization Service
            services.AddLocalization(opts => {
                opts.ResourcesPath = "Resources";
            });

            //Add MVC Service With Configration Authorize To All Controllers
            services.AddMvc(config => {
                var policy = new AuthorizationPolicyBuilder()
                                   .RequireAuthenticatedUser()
                                   .Build();

                config.Filters.Add(new AuthorizeFilter(policy));
            }).AddViewLocalization(opts => { opts.ResourcesPath = "Resources"; })
                    .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
                    .AddDataAnnotationsLocalization();

            //Localization Configuration
            services.Configure<RequestLocalizationOptions>(opts => {
                var supportedCultures = new List<CultureInfo> {
                    new CultureInfo("en"),   // English 
                    new CultureInfo("ar"),   // Arabic 
                  };

                opts.DefaultRequestCulture = new RequestCulture("ar");
                // Formatting numbers, dates, etc.
                opts.SupportedCultures = supportedCultures;
                // UI strings that we have localized.
                opts.SupportedUICultures = supportedCultures;
            });

            //Adding DB Context And Connect It To Connection String

            services.AddDbContextPool<DB>(options => {

                options.UseSqlServer(configuration.GetConnectionString("DB"));
            });
            //Add Identity Service
            services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<DB>();

            //Configure Login Page
            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = new PathString("/Auth/login");
            });

            //Adding Unit Of Work To Services As Scoped
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IStaticDataValues, StaticDataValues>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                //Developer Handler Page With Option To Show 10 Line Of Code
                DeveloperExceptionPageOptions options = new DeveloperExceptionPageOptions();
                options.SourceCodeLineCount = 10;
                app.UseDeveloperExceptionPage(options);
            }
            else
            {
                //Create Global Exceprion Handler
                app.UseExceptionHandler("/Home/Error");
            }


            //Add Files Middleware
            app.UseStaticFiles();
            //Add Authentication Middleware
            app.UseAuthentication();

            //Add Localization MiddleWare
            var Localizationoptions = app.ApplicationServices.GetService<IOptions<RequestLocalizationOptions>>();
            app.UseRequestLocalization(Localizationoptions.Value);

            //Add MVC Middleware
            app.UseMvc(routes => {
                routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
