using MediatR;

namespace FonlaBeni.Application.Tag.Queries.GetById
{
    public record GetByIdTagCommandRequest(Guid Id) : IRequest<GetByIdTagCommandResponse>;

    public class GetByIdTagCommandHandler : IRequestHandler<GetByIdTagCommandRequest, GetByIdTagCommandResponse>
    {
        public Task<GetByIdTagCommandResponse> Handle(GetByIdTagCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

    public record GetByIdTagCommandResponse(Guid Id, string Name, string Slug);
}
