using MediatR;

namespace FonlaBeni.Application.Campaign.Queries.GetById
{
    public record GetByIdCampaignCommandRequest(Guid Id) : IRequest<CampaignDetailReadModel>;

    public class GetByIdCampaignCommandHandler : IRequestHandler<GetByIdCampaignCommandRequest, CampaignDetailReadModel>
    {
        public Task<CampaignDetailReadModel> Handle(GetByIdCampaignCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
