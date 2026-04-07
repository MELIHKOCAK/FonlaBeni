using FluentValidation;
using FonlaBeni.Application.Extensition;

namespace FonlaBeni.Application.Category.Commands.DeleteCategory;

public class DeleteCategoryValidation : AbstractValidator<DeleteCategoryCommandRequest>
{
    public DeleteCategoryValidation()
    {
        RuleFor(x => x.Id)
            .Cascade(CascadeMode.Stop)
            .IsRequired("Id");
    }
}


