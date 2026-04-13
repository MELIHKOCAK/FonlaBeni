using MediatR;

namespace FonlaBeni.Application.AppUser.Commands.Delete
{
    public record DeleteUserCommandRequest(Guid Id) : IRequest<DeleteUserCommandResponse>;
}
