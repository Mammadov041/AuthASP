using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AuthApp.Pages
{
    [Authorize(Roles = "admin")]
    public class AdminModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
