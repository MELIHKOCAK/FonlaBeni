using MediatR;

namespace FonlaBeni.Application.Payment.Commands.Delete
{
    public class DeletePaymentCommandHandler : IRequestHandler<DeletePaymentCommandRequest, DeletePaymentCommandResponse>
    {
        public Task<DeletePaymentCommandResponse> Handle(DeletePaymentCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
