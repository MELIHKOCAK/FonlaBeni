namespace FonlaBeni.Application.DataTransferObject.Donation.Create;
public record CreateDonationDto(decimal Amount, string Message, bool IsAnonymous, Guid CampaignId, Guid UserId);
