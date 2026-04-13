using MediatR;

namespace FonlaBeni.Application.AppUser.Queries.GetById
{
    public record GetByIdUserQueryRequest(Guid Id) : IRequest<GetByIdUserQueryResponse>;

    public class GetByIdUserQueryHandler : IRequestHandler<GetByIdUserQueryRequest, GetByIdUserQueryResponse>
    {
        public Task<GetByIdUserQueryResponse> Handle(GetByIdUserQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

    public record GetByIdUserQueryResponse(Guid Id, string Name, string Surname, string ProfileImageUrl, string UserName, string NormalizedUserName, string Email, string NormalizedEmail, string PhoneNumber, bool TwoFactorEnabled);
}
