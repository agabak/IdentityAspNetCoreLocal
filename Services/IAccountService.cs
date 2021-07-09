using IdentityAspNetCore.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace IdentityAspNetCore.Services
{
    public interface IAccountService
    {
        Task<IdentityResult> RegisterUser(RegisterViewModel model);
    }
}