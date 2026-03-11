namespace FonlaBeni.Application.DataTransferObject.Donation.Create;
public record DonationRequestDto(decimal Amount, string Message, bool IsAnonymous, Guid CampaignId, Guid UserId);
