using AdvanceAPI.API.Extensions;
using AdvanceAPI.BLL.Abstract;
using AdvanceAPI.BLL.Concrete;
using AdvanceAPI.BLL.Mapper;
using AdvanceAPI.CORE.Helper;
using AdvanceAPI.DAL.Repositories.Abstract;
using AdvanceAPI.DAL.Repositories.Concrete;
using AdvanceAPI.DAL.UnitOfWork;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvanceAPI.API
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
            ConnectionHelper.SetConfiguration(Configuration);
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IAuthManager, AuthManager>();
            services.AddScoped<ITitleManager, TitleManager>();
            services.AddScoped<IBusinessUnitManager, BusinessUnitManager>();
            services.AddScoped<MyMapper>();
            services.AddScoped<TokenHelper>();


            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "AdvanceAPI.API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                //app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "AdvanceAPI.API v1"));
            }

            app.ConfigureExceptionHandler();

            app.UseHttpsRedirection();
          
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
