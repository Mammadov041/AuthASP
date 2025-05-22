using Microsoft.AspNetCore.Identity;

namespace AuthApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        // additional properties
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
