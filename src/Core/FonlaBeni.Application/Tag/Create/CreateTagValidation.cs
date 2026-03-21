using FluentValidation;

namespace FonlaBeni.Application.Tag.Create;

public class CreateTagValidation: AbstractValidator<CreateTagDto>
{
    public CreateTagValidation()
    {
        RuleFor(x => x.Name)
            .NotNull().WithMessage("İsim Alanı Boş Olamaz.");
    }
}
