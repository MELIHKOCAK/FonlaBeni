using MediatR;

namespace FonlaBeni.Application.Campaign.Queries.GetAll
{
    public record GetAllCampaignQueryRequest : IRequest<List<GetAllCampaignQueryResponse>>;

    public class GetAllCampaignQueryHandler : IRequestHandler<GetAllCampaignQueryRequest, List<GetAllCampaignQueryResponse>>
    {
        public Task<List<GetAllCampaignQueryResponse>> Handle(GetAllCampaignQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

    public record GetAllCampaignQueryResponse(Guid Id, string Name, string Slug);
}
