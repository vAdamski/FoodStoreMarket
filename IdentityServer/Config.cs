﻿// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4.Models;
using System.Collections.Generic;
using IdentityModel;

namespace IdentityServer
{
    public static class Config
    {
        //Here declares which one information will be given in token
        public static IEnumerable<IdentityResource> IdentityResources =>
           new IdentityResource[]
           {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResource(
                    name: "user",
                    userClaims: new[] {JwtClaimTypes.Email}),
                new IdentityResource(
                    name: "role",
                    userClaims: new[] {JwtClaimTypes.Role})
           };
    
        //Here declares my ApiApplications
        public static IEnumerable<ApiScope> ApiScopes =>
            new ApiScope[]
            {
                new ApiScope("api1")
            };

        //Here declares my Applications
        public static IEnumerable<Client> Clients =>
            new Client[]
            {
                new Client()
                {
                    ClientId = "client",
                    ClientName = "Client for Postman use",
                    
                    AllowedGrantTypes = GrantTypes.ResourceOwnerPasswordAndClientCredentials,
                    ClientSecrets = {new Secret("secret".Sha256())},
                    AllowedScopes = {"api1", "user"},
                    AlwaysSendClientClaims = true,
                    AlwaysIncludeUserClaimsInIdToken = true,
                    AllowAccessTokensViaBrowser = true,
                    Enabled = false
                },
                
                new Client()
                {
                    ClientId = "swagger",
                    ClientName = "Client for Swagger use",
                    
                    AllowedGrantTypes = GrantTypes.CodeAndClientCredentials,
                    ClientSecrets = {new Secret("secret".Sha256())},
                    AllowedScopes = {"api1", "user", "openid", "role"},
                    AlwaysSendClientClaims = true,
                    AlwaysIncludeUserClaimsInIdToken = true,
                    AllowAccessTokensViaBrowser = true,
                    RedirectUris = {"https://localhost:44376/swagger/oauth2-redirect.html"},
                    AllowedCorsOrigins = {"https://localhost:44376"},
                    Enabled= true
                }, 

                new Client()
                {
                    ClientId = "blazor",
                    AllowedGrantTypes = GrantTypes.CodeAndClientCredentials,
                    RequirePkce = true,
                    RequireClientSecret = false,
                    AllowedScopes = { "api1", "user", "openid", "role", "profile" },
                    AllowedCorsOrigins = { "https://localhost:5000", "https://localhost:44376" },
                    RedirectUris = { "https://localhost:5000/authentication/login-callback" },
                    PostLogoutRedirectUris = { "https://localhost:5000/authentication/logout-callback" },
                    Enabled = true
                }
            };
    }
}