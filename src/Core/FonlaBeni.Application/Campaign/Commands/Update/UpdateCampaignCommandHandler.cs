using MediatR;
namespace FonlaBeni.Application.Campaign.Commands.Update;
public class UpdateCampaignCommandHandler : IRequestHandler<UpdateCampaignCommandRequest, UpdateCampaignCommandResponse>
{
    public Task<UpdateCampaignCommandResponse> Handle(UpdateCampaignCommandRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}

