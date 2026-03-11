using FonlaBeni.Domain.Enums;

namespace FonlaBeni.Application.DataTransferObject.Campaign;
public record CampaignResponseDto(string Title, string Description, string Slug, decimal TargetAmount, decimal CurrentAmount, int BackersCount, DateTime DeadLine, CampaignStatus Status);