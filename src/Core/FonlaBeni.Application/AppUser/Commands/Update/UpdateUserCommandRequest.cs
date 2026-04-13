using MediatR;

namespace FonlaBeni.Application.AppUser.Commands.Update
{
    public record UpdateUserCommandRequest(Guid Id, string Name, string Surname, string ProfileImageUrl, string PhoneNumber) : IRequest<UpdateUserCommandResponse>;
}
