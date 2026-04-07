using FonlaBeni.Domain.Enums;
using MediatR;

namespace FonlaBeni.Application.Payment.Queries.GetById
{
    public record GetByIdPaymentQueryRequest(Guid Id) : IRequest<GetByIdPaymentQueryResponse>;

    public class GetByIdPaymentQueryHandler : IRequestHandler<GetByIdPaymentQueryRequest, GetByIdPaymentQueryResponse>
    {
        public Task<GetByIdPaymentQueryResponse> Handle(GetByIdPaymentQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

    public record GetByIdPaymentQueryResponse(Guid Id, decimal Amount, DateTime PaymentAt, PaymentStatus Status, Providers ProviderName, string ProviderId, Guid DonationId);
}
