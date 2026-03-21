using FonlaBeni.Domain.Enums;

namespace FonlaBeni.Application.Donation;

public record DonationDto(decimal Amount, string Message, bool IsAnonymous, PaymentStatus Status, Guid CampaignId, Guid UserId);
