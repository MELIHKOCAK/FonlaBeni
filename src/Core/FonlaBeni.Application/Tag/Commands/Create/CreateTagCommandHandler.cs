using MediatR;

namespace FonlaBeni.Application.Tag.Commands.Create
{
    public class CreateTagCommandHandler : IRequestHandler<CreateTagCommandRequest, CreateTagCommandResponse>
    {
        public Task<CreateTagCommandResponse> Handle(CreateTagCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
