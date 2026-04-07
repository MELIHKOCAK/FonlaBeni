using MediatR;
namespace FonlaBeni.Application.Payment.Commands.Update;
public class UpdatePaymentCommandHandler : IRequestHandler<UpdatePaymentCommandRequest, UpdatePaymentCommandResponse>
{
    public Task<UpdatePaymentCommandResponse> Handle(UpdatePaymentCommandRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}

