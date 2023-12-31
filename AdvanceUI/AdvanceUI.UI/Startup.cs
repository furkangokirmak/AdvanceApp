using AdvanceUI.ConnectApi;
using AdvanceUI.DTOs.Advance;
using AdvanceUI.DTOs.Employee;
using AdvanceUI.UI.Filters;
using AdvanceUI.Validation.FluentValidation.Advance;
using AdvanceUI.Validation.FluentValidation.Employee;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace AdvanceUI.UI
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
            services.AddControllersWithViews();
            services.AddScoped<TokenAuthorizationFilter>();

            services.AddFluentValidationAutoValidation();
            services.AddMemoryCache();

            services.AddScoped<IValidator<AdvanceInsertDTO>, AdvanceInsertDTOValidator>();
            services.AddScoped<IValidator<EmployeeRegisterDTO>, EmployeeRegisterDTOValidator>();

            services.AddScoped<AuthService>();
            services.AddScoped<GenericService>();

            services.AddSession();

            services.AddHttpClient<AuthService>(conf =>
            {
                conf.BaseAddress = new Uri(Configuration["myBaseUri"]);
            });

            services.AddHttpClient<GenericService>(conf =>
            {
                conf.BaseAddress = new Uri(Configuration["myBaseUri"]);
            });

            services.AddAuthentication(a =>
			{
                a.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
			}).AddCookie(a =>
			{
				a.LoginPath = "/Auth/Login";
                a.AccessDeniedPath = "/Home/Index";
				a.Cookie.Name = CookieAuthenticationDefaults.AuthenticationScheme;
				a.Cookie.HttpOnly = true;
			});
			services.AddAuthorization();
		}

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseSession();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
