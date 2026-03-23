using MediatR;

namespace FonlaBeni.Application.Category.Queries.GetAll
{
    public record GetAllCategoryQueryRequest : IRequest<List<GetAllCategoryQueryResponse>>;

    public class GetAllCategoryQueryHandler : IRequestHandler<GetAllCategoryQueryRequest, List<GetAllCategoryQueryResponse>>
    {
        public Task<List<GetAllCategoryQueryResponse>> Handle(GetAllCategoryQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

    public record GetAllCategoryQueryResponse(string Name, string Slug, string Description);
}
