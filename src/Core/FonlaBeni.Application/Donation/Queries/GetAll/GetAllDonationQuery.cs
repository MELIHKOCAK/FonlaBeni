using FonlaBeni.Domain.Enums;
using MediatR;

namespace FonlaBeni.Application.Donation.Queries.GetAll
{
    public record GetAllDonationQueryRequest : IRequest<List<GetAllDonationQueryResponse>>;

    public class GetAllDonationQueryHandler : IRequestHandler<GetAllDonationQueryRequest, List<GetAllDonationQueryResponse>>
    {
        public Task<List<GetAllDonationQueryResponse>> Handle(GetAllDonationQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

    public record GetAllDonationQueryResponse(Guid Id, decimal Amount, string Message, bool IsAnonymous, PaymentStatus Status, Guid CampaignId, Guid UserId);
}
