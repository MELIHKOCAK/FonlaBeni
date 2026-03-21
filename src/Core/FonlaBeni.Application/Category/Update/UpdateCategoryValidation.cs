using FluentValidation;

namespace FonlaBeni.Application.Category.Update;

public class UpdateCategoryValidation : AbstractValidator<UpdateCategoryDto>
{
    public UpdateCategoryValidation()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage("Kategorinin Id'si Boş Geçilemez");

        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Kategorinin İsmi Boş Geçilemez")
            .MaximumLength(100).WithMessage("Kategorinin İsminin Uzunluğu 100 Karakterden Az Olmalıdır.");
    }
}
