using FonlaBeni.Domain.Enums;

namespace FonlaBeni.Application.Campaign.Update;

public record UpdateCampaignDto(Guid Id, string Title, string Description, decimal CurrentAmount, int BackersCount, CampaignStatus Status, PaymentStatus PayoutStatus, Guid CategoryId);
