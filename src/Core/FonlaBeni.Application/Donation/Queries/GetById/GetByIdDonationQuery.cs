using FonlaBeni.Domain.Enums;
using MediatR;

namespace FonlaBeni.Application.Donation.Queries.GetById
{
    public record GetByIdDonationQueryRequest(Guid Id) : IRequest<GetByIdDonationQueryResponse>;

    public class GetByIdDonationQueryHandler : IRequestHandler<GetByIdDonationQueryRequest, GetByIdDonationQueryResponse>
    {
        public Task<GetByIdDonationQueryResponse> Handle(GetByIdDonationQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

    public record GetByIdDonationQueryResponse(Guid Id, decimal Amount, string Message, bool IsAnonymous, PaymentStatus Status, Guid CampaignId, Guid UserId);
}
