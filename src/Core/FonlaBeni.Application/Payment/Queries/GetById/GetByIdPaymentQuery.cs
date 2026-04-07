using FonlaBeni.Domain.Enums;
using MediatR;

namespace FonlaBeni.Application.Payment.Queries.GetById
{
    public record GetAllPaymentQueryRequest(Guid Id) : IRequest<GetAllPaymentQueryResponse>;

    public class GetAllPaymentQueryHandler : IRequestHandler<GetAllPaymentQueryRequest, GetAllPaymentQueryResponse>
    {
        public Task<GetAllPaymentQueryResponse> Handle(GetAllPaymentQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

    public record GetAllPaymentQueryResponse(Guid Id, decimal Amount, DateTime PaymentAt, PaymentStatus Status, Providers ProviderName, string ProviderId, Guid DonationId);
}
