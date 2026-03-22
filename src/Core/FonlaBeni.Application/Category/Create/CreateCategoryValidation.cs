using FluentValidation;
using FonlaBeni.Application.Category.Create;
using FonlaBeni.Application.Extensition;

namespace FonlaBeni.Application.Validation;
public class CreateCategoryValidation : AbstractValidator<CreateCategoryDto>
{
    public CreateCategoryValidation()
    {
        RuleFor(x => x.Name)
            .Cascade(CascadeMode.Stop)
            .IsRequired("Kategori İsim")
            .MaximumLength(100).WithMessage("Kategorinin İsminin Uzunluğu 100 Karakterden Az Olmalıdır.");
    }
}
