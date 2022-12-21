using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System.Collections.Generic;
using System.IO;
using System;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace FoodStoreMarket.Api.Configure
{
    public static class SwaggerConfiguration
    {
        public static void AddSwaggerConfiguration(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.AddSwaggerConfiguration();
            });
        }

        private static void AddSwaggerConfiguration(this SwaggerGenOptions options)
        {
            options.AddSecurityDefinitionConfiguration();
            options.AddSwaggerDocConfiguration();
            options.OperationFilter<AuthorizeCheckOperationFilter>();
            options.AddXMLFileWithComments();
        }
        private static void AddSecurityDefinitionConfiguration(this SwaggerGenOptions options)
        {
            options.AddSecurityDefinition("bearer", new OpenApiSecurityScheme
            {
                Type = SecuritySchemeType.OAuth2,
                Flows = new OpenApiOAuthFlows()
                {
                    AuthorizationCode = new OpenApiOAuthFlow()
                    {
                        AuthorizationUrl = new Uri("https://localhost:5001/connect/authorize"),
                        TokenUrl = new Uri("https://localhost:5001/connect/token"),
                        Scopes = new Dictionary<string, string>
                            {
                                {"api1", "Full access"},
                                {"user", "User info"},
                                {"openid", "openid" },
                                {"role", "User role"}
                            }
                    }
                }
            });
        }
        private static void AddSwaggerDocConfiguration(this SwaggerGenOptions options)
        {
            options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
            {
                Title = "FoodStoreMarket",
                Version = "v1",
                Description = "Application for managing a restaurant, warehouse, storing information about dishes, taking orders and customer service.",
                TermsOfService = new Uri("https://example.com/terms"),
                Contact = new Microsoft.OpenApi.Models.OpenApiContact
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
        }
        private static void AddXMLFileWithComments(this SwaggerGenOptions options)
        {
            var filePath = Path.Combine(AppContext.BaseDirectory, "FoodStoreMarket.Api.xml");
            options.IncludeXmlComments(filePath);
        }
    }
}
