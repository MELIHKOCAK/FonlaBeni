using FonlaBeni.Domain.Entites;
using Microsoft.AspNetCore.Identity;

namespace FonlaBeni.Persistence.Identity
{
    public class AppUser : IdentityUser<Guid>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ProfileImageUrl { get; set; }
        public string ExternalAccountId { get; set; } //Ödeme Servisleri İçin Üretici Id

        //Navigation Property
        public ICollection<Campaign> Campaigns { get; set; }
        public Donation Donation { get; set; }
    }
}
