using MediatR;

namespace FonlaBeni.Application.AppUser.Queries.GetAll
{
    public record GetAllUserQueryRequest : IRequest<List<GetAllUserQueryResponse>>;

    public class GetAllUserQueryHandler : IRequestHandler<GetAllUserQueryRequest, List<GetAllUserQueryResponse>>
    {
        public Task<List<GetAllUserQueryResponse>> Handle(GetAllUserQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

    public record GetAllUserQueryResponse(Guid Id, string Name, string Surname, string ProfileImageUrl, string UserName, string NormalizedUserName, string Email, string NormalizedEmail, string PhoneNumber, bool TwoFactorEnabled);
}
