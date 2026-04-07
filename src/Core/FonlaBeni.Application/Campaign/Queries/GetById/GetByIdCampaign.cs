using MediatR;

namespace FonlaBeni.Application.Campaign.Queries.GetById
{
    public record GetByIdCampaignCommandRequest(Guid Id) : IRequest<GetByIdCampaignCommandResponse>;

    public class GetByIdCampaignCommandHandler : IRequestHandler<GetByIdCampaignCommandRequest, GetByIdCampaignCommandResponse>
    {
        public Task<GetByIdCampaignCommandResponse> Handle(GetByIdCampaignCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

    public record GetByIdCampaignCommandResponse(Guid Id, string Name, string Slug);
}
