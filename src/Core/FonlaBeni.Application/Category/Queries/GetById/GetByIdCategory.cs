using MediatR;

namespace FonlaBeni.Application.Category.Queries.GetById
{
    public record GetByIdCategoryCommandRequest(Guid Id) : IRequest<GetByIdCategoryCommandResponse>;

    public class GetByIdCommandHandler : IRequestHandler<GetByIdCategoryCommandRequest, GetByIdCategoryCommandResponse>
    {
        public Task<GetByIdCategoryCommandResponse> Handle(GetByIdCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

    public record GetByIdCategoryCommandResponse(Guid Id, string Name, string Slug, string Description);
}
