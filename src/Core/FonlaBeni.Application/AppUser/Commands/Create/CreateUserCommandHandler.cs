using MediatR;

namespace FonlaBeni.Application.AppUser.Commands.Create
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommandRequest, CreateUserCommandResponse>
    {
        public Task<CreateUserCommandResponse> Handle(CreateUserCommandRequest request, CancellationToken cancellationToken)
        {
            //UserManager Sınıfını Kullan Repository Pattern Uygulamana Gerek Yok!
            throw new NotImplementedException();
        }
    }
}
