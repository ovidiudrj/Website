using Microsoft.AspNetCore.Identity;

namespace GymWebApp.Models
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public DateOnly DateOfBirth { get; set; }
    }
}
