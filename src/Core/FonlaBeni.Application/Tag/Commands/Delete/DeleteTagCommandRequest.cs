using MediatR;

namespace FonlaBeni.Application.Tag.Commands.Delete
{
    public record DeleteTagCommandRequest(Guid Id) : IRequest<DeleteTagCommandResponse>;
}
