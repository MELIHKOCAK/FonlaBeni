using MediatR;

namespace FonlaBeni.Application.CampaignImage.Queries.GetById
{
    public record GetByIdCampaignImageQueryRequest(Guid Id) : IRequest<GetByIdCampaignImageQueryResponse>;

    public class GetByIdCampaignQueryHandler : IRequestHandler<GetByIdCampaignImageQueryRequest, GetByIdCampaignImageQueryResponse>
    {
        public Task<GetByIdCampaignImageQueryResponse> Handle(GetByIdCampaignImageQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

    public record GetByIdCampaignImageQueryResponse(Guid Id, string Url, Guid CampaignId);
}
