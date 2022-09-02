using System;
using System.Threading.Tasks;
using IdentityServer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace IdentityServer;

public static class SeedRole 
{
    public static IServiceProvider SeedRoleAndAddToUsers(this IServiceProvider service)
    {
        CreateRoles(service).Wait();

        return service;
    }
    
    private static async Task CreateRoles(IServiceProvider serviceProvider) {
        var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();

        ApplicationUser userToMakeAdmin = await userManager.FindByNameAsync("alice");
        await userManager.AddToRoleAsync(userToMakeAdmin, "admin");
        ApplicationUser userToMakeMember = await userManager.FindByNameAsync("bob");
        await userManager.AddToRoleAsync(userToMakeMember, "member");
    }
}