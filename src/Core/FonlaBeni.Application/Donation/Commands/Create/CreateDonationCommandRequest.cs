using MediatR;

namespace FonlaBeni.Application.Donation.Commands.Create
{
    public record CreateDonationCommandRequest(decimal Amount, string Message, bool IsAnonymous, Guid CampaignId, Guid UserId) : IRequest<CreateDonationCommandResponse>;
}
