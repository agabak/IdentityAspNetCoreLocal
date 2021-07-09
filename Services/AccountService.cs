using IdentityAspNetCore.DbContexts;
using IdentityAspNetCore.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityAspNetCore.Services
{
    public class AccountService : IAccountService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly UserManager<AppUser> _userManager;

        public AccountService(
            ApplicationDbContext dbContext,
            UserManager<AppUser> userManager
            )
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }
        public async Task<IdentityResult> RegisterUser(RegisterViewModel model)
        {
            if (model is null) return null;
            AppUser user = new()
            {
                UserName = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                DateOfBorn = DateTime.Now,
                LastDateLogin = DateTime.Now,
                Email = model.Email,
            };
            var result = await _userManager.CreateAsync(user , model.Password);

            return result;
        }
    }
}
