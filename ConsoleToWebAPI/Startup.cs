using ConsoleToWebAPI.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleToWebAPI
{
    public class Startup
    {

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddTransient<CustomMiddleware1>();
            //services.AddSingleton<IProductRepository, ProductRepository>();
            //services.AddScoped<IProductRepository, ProductRepository>();  //AddScoped<>

            services.TryAddTransient<IProductRepository, TestRepository>();
            services.TryAddTransient<IProductRepository, ProductRepository>();  
             

        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync("Hello from Run method");
            //});

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello from Use-1 1\n");
            //    await next(); // Next Method
            //    await context.Response.WriteAsync("Hello from Use-1 \n");
                

            //});
            //app.Map("/raihan", CustomCode);
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello from Use-2 1\n");
            //    await next(); // Next Method
            //    await context.Response.WriteAsync("Hello from Use-2 2\n");

            //});

            //app.UseMiddleware<CustomMiddleware1>();

            

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Request Complete \n");
                

            //});

            //app.Run(async context => {
            //    await context.Response.WriteAsync("Request Complete \n");
            //});

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting(); //Enable Routing

            app.UseEndpoints(endpoints =>  //Map the resource Resource
            {
                endpoints.MapControllers();
            });
        }

        private void CustomCode(IApplicationBuilder app)
        {
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Hello from Raihan \n");
              
            });
        }
    }
}
