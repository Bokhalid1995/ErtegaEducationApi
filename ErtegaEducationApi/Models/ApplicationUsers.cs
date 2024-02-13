using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ErtegaEducationApi.Models
{
    public class ApplicationUsers : IdentityUser
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
    }
}
