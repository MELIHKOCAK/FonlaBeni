using MediatR;

namespace FonlaBeni.Application.Payment.Commands.Delete
{
    public record DeletePaymentCommandRequest(Guid Id) : IRequest<DeletePaymentCommandResponse>;
}
