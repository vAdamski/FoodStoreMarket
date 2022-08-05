using FoodStoreMarket.Application;
using FoodStoreMarket.Infrastructure;
using FoodStoreMarket.Persistance;
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
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Serilog;

namespace FoodStoreMarket
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
            services.AddPersistance(Configuration);
            services.AddInfrastructure(Configuration);
            services.AddApplication();



            services.AddCors(options =>
            {
                options.AddPolicy(name: "MyAllowSpecificOrigins",
                    builder =>
                    {
                        builder.AllowAnyOrigin();
                    });
            });
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Title = "FoodStoreMarket",
                    Version = "v1",
                    Description = "Application for managing a restaurant, warehouse, storing information about dishes, taking orders and customer service.",
                    TermsOfService = new Uri("https://example.com/terms"),
                    Contact =  new Microsoft.OpenApi.Models.OpenApiContact
                    {
                        Name = "Adam Ludwiczak",
                        Email = "adam.ludwiczak98@gmail.com"
                    },
                    License = new Microsoft.OpenApi.Models.OpenApiLicense
                    {
                        Name = "Used License",
                        Url = new Uri("https://example.com/license")
                    }
                });
                var filePath = Path.Combine(AppContext.BaseDirectory, "FoodStoreMarket.Api.xml");
                c.IncludeXmlComments(filePath);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "FoodStoreMarket"));

            app.UseHttpsRedirection();

            app.UseSerilogRequestLogging();
            
            app.UseRouting();

            app.UseCors();

            app.UseAuthorization();

            app.UseMiddlewareApplication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }
    }
}
