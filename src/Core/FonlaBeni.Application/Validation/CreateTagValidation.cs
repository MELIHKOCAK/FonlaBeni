using FluentValidation;
using FonlaBeni.Application.DataTransferObject.Tag.Create;

namespace FonlaBeni.Application.Validation;

public class CreateTagValidation: AbstractValidator<CreateTagDto>
{
    public CreateTagValidation()
    {
        RuleFor(x => x.Name)
            .NotNull().WithMessage("İsim Alanı Boş Olamaz.");
    }
}
