using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using IdentityModel;
using IdentityServer.Models;
using IdentityServer4.Extensions;
using IdentityServer4.Models;
using IdentityServer4.Services;
using Microsoft.AspNetCore.Identity;

namespace IdentityServer.Services;

public sealed class ProfileService : IProfileService
    {
        private readonly UserManager<ApplicationUser> _userMgr;

        public ProfileService(UserManager<ApplicationUser> userMgr)
        {
            _userMgr = userMgr;
        }

        public async Task GetProfileDataAsync(ProfileDataRequestContext context)
        {
            var user = await _userMgr.GetUserAsync(context.Subject);
            

            var claims = new List<Claim>()
            {
                new Claim("Email", user.Email)
            };
            
            var roles = await _userMgr.GetRolesAsync(user);
            
            foreach (var role in roles)
            {
                claims.Add(new Claim(JwtClaimTypes.Role, role));
            }
            
            context.IssuedClaims.AddRange(claims);
        }

        public async Task IsActiveAsync(IsActiveContext context)
        {
            var user = await _userMgr.GetUserAsync(context.Subject);
            context.IsActive = user != null;
        }
    }