using MediatR;
namespace FonlaBeni.Application.Tag.Commands.Update;
public class UpdateTagCommandHandler : IRequestHandler<UpdateTagCommandRequest, UpdateTagCommandResponse>
{
    public Task<UpdateTagCommandResponse> Handle(UpdateTagCommandRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}

