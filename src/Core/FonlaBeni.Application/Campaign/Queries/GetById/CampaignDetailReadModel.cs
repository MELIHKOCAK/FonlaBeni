using FonlaBeni.Domain.Enums;

namespace FonlaBeni.Application.Campaign.Queries.GetById
{
    public class CampaignDetailReadModel
    {
        public Guid Id { get; init; }
        public string CampaignName { get; init; }
        public string CampaignDescription { get; init; }
        public decimal TargetAmount { get; init; }
        public decimal CurrentAmount { get; init; }
        public string CategoryName { get; init; }
        public DateTime DeadLine { get; init; }
        public DateTime CreatedDate { get; init; }
        public string TagName { get; init; }
        public CampaignStatus Status { get; init; }
        public PaymentStatus PayoutStatus { get; init; }
        public List<string> ImageUrl { get; init; }
    }
}