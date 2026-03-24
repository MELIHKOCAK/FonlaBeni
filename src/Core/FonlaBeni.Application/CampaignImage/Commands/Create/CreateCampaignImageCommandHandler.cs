using MediatR;

namespace FonlaBeni.Application.CampaignImage.Commands.Create
{
    public class CreateCampaignImageCommandHandler : IRequestHandler<CreateCampaignImageCommandRequest, CreateCampaignImageCommandResponse>
    {
        public Task<CreateCampaignImageCommandResponse> Handle(CreateCampaignImageCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
