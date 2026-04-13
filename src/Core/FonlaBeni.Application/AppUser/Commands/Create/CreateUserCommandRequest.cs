using MediatR;

namespace FonlaBeni.Application.AppUser.Commands.Create
{
    public record CreateUserCommandRequest(string Name, string Surname, string ProfileImageUrl, string UserName, string NormalizedUserName, string Email, string NormalizedEmail, string PhoneNumber, bool TwoFactorEnabled) : IRequest<CreateUserCommandResponse>;
}
