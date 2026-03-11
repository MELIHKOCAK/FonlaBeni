namespace FonlaBeni.Application.DataTransferObject.Campaign.Create;
public record CampaignRequestDto(string Title, string Description, string Slug, decimal TargetAmount, DateTime DeadLine, Guid CategoryId, Guid UserId, List<CampaignImageDto>);
