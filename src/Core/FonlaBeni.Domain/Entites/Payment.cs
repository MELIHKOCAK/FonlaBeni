using FonlaBeni.Domain.Enums;

namespace FonlaBeni.Domain.Entites;
public class Payment: BaseEntity
{
    public decimal Amount { get; set; }
    public DateTime PaymentAt { get; set; }
    public PaymentStatus Status { get; set; }
    public Providers ProviderName { get; set; }
    public string ProviderId { get; set; }

    //Foreign Key
    public Guid DonationId { get; set; }

    //Navigation Property
    public Donation Donation { get; set; }
}
