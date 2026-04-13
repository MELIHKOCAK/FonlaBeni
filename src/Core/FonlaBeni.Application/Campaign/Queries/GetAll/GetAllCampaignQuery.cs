using MediatR;

namespace FonlaBeni.Application.Campaign.Queries.GetAll
{
    public record GetAllCampaignQueryRequest : IRequest<List<CampaignListReadModel>>;

    public class GetAllCampaignQueryHandler : IRequestHandler<GetAllCampaignQueryRequest, List<CampaignListReadModel>>
    {
        public Task<List<CampaignListReadModel>> Handle(GetAllCampaignQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
    
}
