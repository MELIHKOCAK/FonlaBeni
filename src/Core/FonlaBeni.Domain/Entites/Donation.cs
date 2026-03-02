using FonlaBeni.Domain.Enums;

namespace FonlaBeni.Domain.Entites;

public class Donation:BaseEntity
{
    public decimal Amount { get; set; }
    public string Message { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool IsAnonymous { get; set; }
    public PaymentStatus Status { get; set; }

    //Foreign Key
    public Guid CampaignId { get; set; }

    //Navigation Properties
    public Campaign Campaign { get; set; }
    public ICollection<Payment> Payments { get; set; }

}
