using System;
using IdentityModel;
using System.Security.Claims;
using FoodStoreMarket.Application.Interfaces;
using Microsoft.AspNetCore.Http;

namespace FoodStoreMarket.Service;

public class CurrnetUserService : ICurrentUserService
{
    public string Email { get; set; }
    public bool IsAuthenticated { get; set; }

    public CurrnetUserService(IHttpContextAccessor httpContextAccessor)
    {
        var email = httpContextAccessor.HttpContext?.User?.FindFirstValue(JwtClaimTypes.Email);
        Email = email;

        IsAuthenticated = !string.IsNullOrEmpty(email);
    }
}