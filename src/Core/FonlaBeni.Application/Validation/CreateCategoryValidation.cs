using FluentValidation;
using FonlaBeni.Application.DataTransferObject.Category.Create;

namespace FonlaBeni.Application.Validation;
public class CreateCategoryValidation : AbstractValidator<CreateCategoryDto>
{
    public CreateCategoryValidation()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Kategorinin İsmi Boş Geçilemez")
            .MaximumLength(100).WithMessage("Kategorinin İsminin Uzunluğu 100 Karakterden Az Olmalıdır.");
    }
}
