using FluentValidation;
using FonlaBeni.Application.Extensition;

namespace FonlaBeni.Application.Category.Commands.UpdateCategory;

public class UpdateCategoryValidation : AbstractValidator<UpdateCategoryCommandRequest>
{
    public UpdateCategoryValidation()
    {
        RuleFor(x => x.Id)
            .IsRequired("Kategori Id");

        RuleFor(x => x.Name)
            .Cascade(CascadeMode.Stop)
            .IsRequired("Kategori İsim")
            .MaximumLength(100).WithMessage("Kategorinin İsminin Uzunluğu 100 Karakterden Az Olmalıdır.");
    }
}
