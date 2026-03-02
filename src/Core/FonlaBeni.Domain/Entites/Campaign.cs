using FonlaBeni.Domain.Enums;

namespace FonlaBeni.Domain.Entites
{
    public class Campaign : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Slug { get; set; }
        public decimal TargetAmount { get; set; }
        public decimal CurrentAmount { get; set; }
        public int BackersCount { get; set; }
        public DateTime DeadLine { get; set; }
        public DateTime CreatedDate { get; set; }
        public CampaignStatus Status { get; set; }
        public PaymentStatus PayoutStatus { get; set; }

        //Navigation Properties
        public Category Category { get; set; }
        public ICollection<CampaignImage> CampaignImages { get; set; }
        public ICollection<CampaignTags> CampaignTags { get; set; }
        public ICollection<Donation> Donations { get; set; }

        //Foreign Key
        public Guid CategoryId { get; set; }

    }
}
