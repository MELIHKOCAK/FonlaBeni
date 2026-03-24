using MediatR;

namespace FonlaBeni.Application.Category.Commands.UpdateCategory
{
    public record UpdateCategoryCommandRequest(Guid Id, string Name, string Slug, string Description) : IRequest<UpdateCategoryCommandResponse>;
}
