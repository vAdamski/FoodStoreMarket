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
    public string Role { get; set; }

    public CurrnetUserService(IHttpContextAccessor httpContextAccessor)
    {
        var email = httpContextAccessor.HttpContext?.User?.FindFirstValue(JwtClaimTypes.Email);
        var role = httpContextAccessor.HttpContext?.User?.FindFirstValue(JwtClaimTypes.Role);
        Console.WriteLine(role);

        Role = role;
        Email = email;

        IsAuthenticated = !string.IsNullOrEmpty(email);
    }
}