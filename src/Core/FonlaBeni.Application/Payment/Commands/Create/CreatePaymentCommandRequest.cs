using FonlaBeni.Domain.Enums;
using MediatR;

namespace FonlaBeni.Application.Payment.Commands.Create
{
    public record CreatePaymentCommandRequest(decimal Amount, DateTime PaymentAt, PaymentStatus Status, Providers ProviderName, string ProviderId, Guid DonationId) : IRequest<CreatePaymentCommandResponse>;
}
