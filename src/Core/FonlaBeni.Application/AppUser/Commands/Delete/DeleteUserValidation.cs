using FluentValidation;
using FonlaBeni.Application.Extensition;

namespace FonlaBeni.Application.Category.Commands.DeleteCategory;

public class DeleteUserValidation : AbstractValidator<DeleteCategoryCommandRequest>
{
    public DeleteUserValidation()
    {
        RuleFor(x => x.Id)
            .Cascade(CascadeMode.Stop)
            .IsRequired("Id");
    }
}


