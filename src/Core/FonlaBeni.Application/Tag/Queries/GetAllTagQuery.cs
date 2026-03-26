using MediatR;

namespace FonlaBeni.Application.Tag.Queries
{
    public record GetAllTagQueryRequest : IRequest<List<GetAllTagQueryResponse>>;

    public class GetAllTagQueryHandler : IRequestHandler<GetAllTagQueryRequest, List<GetAllTagQueryResponse>>
    {
        public Task<List<GetAllTagQueryResponse>> Handle(GetAllTagQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

    public record GetAllTagQueryResponse(Guid Id, string Name, string Slug);
}
