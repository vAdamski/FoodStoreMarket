using FoodStoreMarket.Application;
using FoodStoreMarket.Infrastructure;
using FoodStoreMarket.Persistance;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using FoodStoreMarket.Application.Interfaces;
using FoodStoreMarket.Service;
using IdentityModel;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Any;
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
                options.AddPolicy("AllowAll", poliicy => poliicy.AllowAnyOrigin());
            });

            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(typeof(ICurrentUserService), typeof(CurrnetUserService));
            JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();
            services.AddAuthentication("bearer")
                .AddJwtBearer("bearer", options =>
                {
                    options.Authority = "https://localhost:5001";
                    options.TokenValidationParameters = new TokenValidationParameters()
                    {
                        ValidateAudience = false,
                        NameClaimType = JwtClaimTypes.Name,
                        RoleClaimType = JwtClaimTypes.Role
                    };
                });
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.AddSecurityDefinition("bearer", new OpenApiSecurityScheme
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
                c.OperationFilter<AuthorizeCheckOperationFilter>();
                var filePath = Path.Combine(AppContext.BaseDirectory, "FoodStoreMarket.Api.xml");
                c.IncludeXmlComments(filePath);
            });

            services.AddAuthorization(optionns =>
            {
                optionns.AddPolicy("admin", policy =>
                {
                    policy.RequireAuthenticatedUser();
                    policy.RequireClaim("scope", "api1");
                    policy.RequireRole("admin");
                });
                optionns.AddPolicy("ApiScope", policy =>
                {
                    policy.RequireAuthenticatedUser();
                    policy.RequireClaim("scope", "api1");
                });
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
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "FoodStoreMarket");
                c.OAuthClientId("swagger");
                c.OAuthClientSecret("secret");
                c.OAuth2RedirectUrl("https://localhost:44376/swagger/oauth2-redirect.html");
                c.OAuthUsePkce();
            });

            app.UseHttpsRedirection();

            app.UseAuthentication();

            app.UseSerilogRequestLogging();
            
            app.UseRouting();

            app.UseCors();

            app.UseAuthorization();

            app.UseMiddlewareApplication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers().RequireAuthorization("ApiScope");
            });

        }
    }
}
