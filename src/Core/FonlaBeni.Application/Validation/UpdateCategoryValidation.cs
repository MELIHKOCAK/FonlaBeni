using FluentValidation;
using FonlaBeni.Application.DataTransferObject.Category.Update;

namespace FonlaBeni.Application.Validation;

public class UpdateCategoryValidation : AbstractValidator<UpdateCategoryDto>
{
    public UpdateCategoryValidation()
    {
        
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Kategorinin İsmi Boş Geçilemez")
            .MaximumLength(100).WithMessage("Kategorinin İsminin Uzunluğu 100 Karakterden Az Olmalıdır.");
    }
}
