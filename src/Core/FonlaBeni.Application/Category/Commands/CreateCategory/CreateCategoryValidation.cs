using FluentValidation;
using FonlaBeni.Application.Extensition;

namespace FonlaBeni.Application.Category.Commands.CreateCategory;
public class CreateCategoryValidation : AbstractValidator<CreateCategoryCommandRequest>
{
    public CreateCategoryValidation()
    {
        RuleFor(x => x.Name)
            .Cascade(CascadeMode.Stop)
            .IsRequired("Kategori İsim")
            .MaximumLength(100).WithMessage("Kategorinin İsminin Uzunluğu 100 Karakterden Az Olmalıdır.");
    }

}
