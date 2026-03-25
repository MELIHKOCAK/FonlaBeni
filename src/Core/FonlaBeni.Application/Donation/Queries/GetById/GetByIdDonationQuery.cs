using FonlaBeni.Domain.Enums;
using MediatR;

namespace FonlaBeni.Application.Donation.Queries.GetById
{
    public record GetAllDonationQueryRequest : IRequest<GetAllDonationQueryResponse>;

    public class GetAllDonationQueryHandler : IRequestHandler<GetAllDonationQueryRequest, GetAllDonationQueryResponse>
    {
        public Task<GetAllDonationQueryResponse> Handle(GetAllDonationQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

    public record GetAllDonationQueryResponse(Guid Id, decimal Amount, string Message, bool IsAnonymous, PaymentStatus Status, Guid CampaignId, Guid UserId);
}
