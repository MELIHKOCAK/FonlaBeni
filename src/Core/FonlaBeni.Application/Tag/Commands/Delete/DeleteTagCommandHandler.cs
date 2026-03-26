using MediatR;

namespace FonlaBeni.Application.Tag.Commands.Delete
{
    public class DeleteTagCommandHandler : IRequestHandler<DeleteTagCommandRequest, DeleteTagCommandResponse>
    {
        public Task<DeleteTagCommandResponse> Handle(DeleteTagCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
