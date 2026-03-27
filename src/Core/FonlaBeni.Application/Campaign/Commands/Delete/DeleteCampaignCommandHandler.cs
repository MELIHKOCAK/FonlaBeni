using MediatR;

namespace FonlaBeni.Application.Campaign.Commands.Delete
{
    public class DeleteCampaignCommandHandler : IRequestHandler<DeleteCampaignCommandRequest, DeleteCampaignCommandResponse>
    {
        public Task<DeleteCampaignCommandResponse> Handle(DeleteCampaignCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
