using Microsoft.AspNetCore.Identity;

namespace FonlaBeni.Persistence.Identity
{
    public class AppRole : IdentityRole<Guid>
    {
        public string Description { get; set; }
    }
}
