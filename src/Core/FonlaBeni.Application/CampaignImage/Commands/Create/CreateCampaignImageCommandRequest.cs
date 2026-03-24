using MediatR;

namespace FonlaBeni.Application.CampaignImage.Commands.Create
{
    public record CreateCampaignImageCommandRequest(string Url, Guid CampaignId) : IRequest<CreateCampaignImageCommandResponse>
    {
    }
}
