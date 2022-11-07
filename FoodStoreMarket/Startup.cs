using FoodStoreMarket.Application;
using FoodStoreMarket.Infrastructure;
using FoodStoreMarket.Persistance;
using FoodStoreMarket.Infrastructure.Identity;
using FoodStoreMarket.Application.Interfaces;
using FoodStoreMarket.Service;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Claims;
using IdentityModel;
using IdentityServer4.Models;
using IdentityServer4.Test;
using System.IdentityModel.Tokens.Jwt;

namespace FoodStoreMarket
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment environment)
        {
            Configuration = configuration;
            Environment = environment;
        }

        public IConfiguration Configuration { get; }
        public IWebHostEnvironment Environment { get; }

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

            if(Environment.IsEnvironment("Test"))
            {
                services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("MovieDatabase")));
                services.AddDefaultIdentity<ApplicationUser>().AddEntityFrameworkStores<ApplicationDbContext>();
                services.AddIdentityServer()
                        .AddApiAuthorization<ApplicationUser, ApplicationDbContext>(options =>
                        {
                            options.ApiResources.Add(new IdentityServer4.Models.ApiResource("api1"));
                            options.ApiScopes.Add(new IdentityServer4.Models.ApiScope("api1"));
                            options.Clients.Add(new IdentityServer4.Models.Client
                            {
                                ClientId = "client",
                                AllowedGrantTypes = { GrantType.ResourceOwnerPassword },
                                ClientSecrets = { new IdentityServer4.Models.Secret("secret".Sha256()) },
                                AllowedScopes = { "openid", "profile", "api1" }
                            });
                        }).AddTestUsers(new List<TestUser>
                        {
                        new TestUser
                        {
                            SubjectId = "4B434A88-212D-4A4D-A17C-F35102D73CBB",
                            Username = "alice",
                            Password = "Pass123$",
                            Claims = new List<Claim>
                            {
                                new Claim(JwtClaimTypes.Email, "alice@user.com"),
                                new Claim(ClaimTypes.Name, "alice")
                            }
                        }
                        });
                services.AddAuthentication("Bearer").AddIdentityServerJwt();
            }
            else
            {
                services.AddAuthentication("bearer")
                .AddJwtBearer("bearer", options =>
                {
                    options.Authority = "https://localhost:5001";
                    options.TokenValidationParameters = new TokenValidationParameters()
                    {
                        ValidateAudience = false
                    };
                });

                services.AddAuthorization(optionns =>
                {
                    optionns.AddPolicy("admin", policy =>
                    {
                        policy.RequireAuthenticatedUser();
                        policy.RequireClaim("scope", "api1", JwtClaimTypes.Role);
                        policy.RequireRole("admin");
                    });
                    optionns.AddPolicy("ApiScope", policy =>
                    {
                        policy.RequireAuthenticatedUser();
                        policy.RequireClaim("scope", "api1");
                    });
                });
            }

            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.TryAddSingleton(typeof(ICurrentUserService), typeof(CurrnetUserService));
            services.AddScoped(typeof(ICurrentUserService), typeof(CurrnetUserService));
            JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();
            
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
                                {"roles", "User role"}
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

            if(Environment.IsEnvironment("Test"))
            {
                app.UseIdentityServer();
            }

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
