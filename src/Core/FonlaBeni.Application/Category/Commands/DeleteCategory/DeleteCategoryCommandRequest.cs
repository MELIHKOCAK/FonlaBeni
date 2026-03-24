using MediatR;

namespace FonlaBeni.Application.Category.Commands.DeleteCategory
{
    public record DeleteCategoryCommandRequest(Guid Id) : IRequest<DeleteCategoryCommandResponse>;
}
