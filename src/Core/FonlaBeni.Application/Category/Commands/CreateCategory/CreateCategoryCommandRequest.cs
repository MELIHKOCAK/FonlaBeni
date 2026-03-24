using MediatR;

namespace FonlaBeni.Application.Category.Commands.CreateCategory
{
    public record CreateCategoryCommandRequest(string Name, string Description): IRequest<CreateCategoryCommandResponse>;
}
