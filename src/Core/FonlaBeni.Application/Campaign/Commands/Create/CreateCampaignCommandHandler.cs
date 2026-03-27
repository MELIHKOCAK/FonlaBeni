using MediatR;

namespace FonlaBeni.Application.Campaign.Commands.Create
{
    public class CreateCampaignCommandHandler : IRequestHandler<CreateCampaignCommandRequest, CreateCampaignCommandResponse>
    {
        public Task<CreateCampaignCommandResponse> Handle(CreateCampaignCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
