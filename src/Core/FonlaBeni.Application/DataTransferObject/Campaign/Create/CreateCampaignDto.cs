namespace FonlaBeni.Application.DataTransferObject.Campaign.Create;
public record CreateCampaignDto(string Title, string Description, string Slug, decimal TargetAmount, DateTime DeadLine, Guid CategoryId, Guid UserId, List<CampaignImageDto>);
