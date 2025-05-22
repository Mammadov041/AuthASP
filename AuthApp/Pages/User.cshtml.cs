using AuthApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AuthApp.Pages
{
    [Authorize]
    public class UserModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        public ApplicationUser? AppUser { get; set; }
        public UserModel(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
        public void OnGet()
        {
            var task = _userManager.GetUserAsync(User);
            task.Wait();
            AppUser = task.Result;
        }
    }
}
