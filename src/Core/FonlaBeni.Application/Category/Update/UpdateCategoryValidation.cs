using FluentValidation;
using FonlaBeni.Application.Extensition;

namespace FonlaBeni.Application.Category.Update;

public class UpdateCategoryValidation : AbstractValidator<UpdateCategoryDto>
{
    public UpdateCategoryValidation()
    {
        RuleFor(x => x.Id)
            .IsRequired("Kategori Id");

        RuleFor(x => x.Name)
            .IsRequired("Kategori İsim")
            .MaximumLength(100).WithMessage("Kategorinin İsminin Uzunluğu 100 Karakterden Az Olmalıdır.");
    }
}
