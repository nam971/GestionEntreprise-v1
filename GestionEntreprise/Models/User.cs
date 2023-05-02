using Microsoft.AspNetCore.Identity;

namespace GestionEntreprise.Models
{
    public class User : IdentityUser
    {
        public string? Name { get; set; }
    }
}
