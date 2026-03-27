using MediatR;

namespace FonlaBeni.Application.Campaign.Commands.Delete
{
    public record DeleteCampaignCommandRequest(Guid Id) : IRequest<DeleteCampaignCommandResponse>;
}
