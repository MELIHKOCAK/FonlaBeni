using FonlaBeni.Domain.Enums;

namespace FonlaBeni.Application.DataTransferObject.Donation;

public record DonationDto(decimal Amount, string Message, bool IsAnonymous, PaymentStatus Status, Guid CampaignId, Guid UserId);
