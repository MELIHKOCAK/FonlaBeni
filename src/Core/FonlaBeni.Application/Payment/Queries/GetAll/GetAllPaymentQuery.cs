using FonlaBeni.Domain.Enums;
using MediatR;

namespace FonlaBeni.Application.Payment.Queries.GetAll
{
    public record GetAllPaymentQueryRequest : IRequest<List<GetAllPaymentQueryResponse>>;

    public class GetAllPaymentQueryHandler : IRequestHandler<GetAllPaymentQueryRequest, List<GetAllPaymentQueryResponse>>
    {
        public Task<List<GetAllPaymentQueryResponse>> Handle(GetAllPaymentQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

    public record GetAllPaymentQueryResponse(Guid Id,decimal Amount, DateTime PaymentAt, PaymentStatus Status, Providers ProviderName, string ProviderId, Guid DonationId);
}
