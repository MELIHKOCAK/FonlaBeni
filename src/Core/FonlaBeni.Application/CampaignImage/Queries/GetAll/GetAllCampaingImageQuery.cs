using MediatR;

namespace FonlaBeni.Application.CampaignImage.Queries.GetAll
{
    public record GetAllCampaignImageQueryRequest : IRequest<List<GetAllCampaignImageQueryResponse>>;

    public class GetAllCampaignQueryHandler : IRequestHandler<GetAllCampaignImageQueryRequest, List<GetAllCampaignImageQueryResponse>>
    {
        public Task<List<GetAllCampaignImageQueryResponse>> Handle(GetAllCampaignImageQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

    public record GetAllCampaignImageQueryResponse(Guid Id, string Url, Guid CampaignId);
}
