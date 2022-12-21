using FoodStoreMarket.Application;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace FoodStoreMarket.Api.Configure;

public static class ApplicationBuilderConfiguration
{
    public static void AddApplicationBuilderConfiguration(this IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        
        app.UseSwagger();
        app.UseSwaggerUI(c =>
        {
            c.AddSwaggerUIConfiguration();
        });

        app.UseHttpsRedirection();

        app.UseAuthentication();

        app.UseSerilogRequestLogging();
            
        app.UseRouting();

        app.UseCors("CORS");

        app.UseAuthorization();

        app.UseMiddlewareApplication();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers().RequireAuthorization("ApiScope");
        });
    }
}