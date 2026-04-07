using MediatR;

namespace FonlaBeni.Application.Payment.Commands.Create
{
    public class CreatePaymentCommandHandler : IRequestHandler<CreatePaymentCommandRequest, CreatePaymentCommandResponse>
    {
        public Task<CreatePaymentCommandResponse> Handle(CreatePaymentCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
