using Microsoft.AspNetCore.Identity;

namespace Blazor8App1.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string? FullName { get; set; }
        public DateOnly? BirthDate { get; set; }
    }

}
