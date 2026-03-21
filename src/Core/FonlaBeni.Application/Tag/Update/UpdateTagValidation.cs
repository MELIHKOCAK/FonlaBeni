using FluentValidation;

namespace FonlaBeni.Application.Tag.Update;
public class UpdateTagValidation : AbstractValidator<UpdateTagDto>
{
    public UpdateTagValidation()
    {
        RuleFor(x => x.Id)
            .NotNull().WithMessage("Id Alanı Boş Olamaz");

        RuleFor(x => x.Name)
            .NotNull().WithMessage("İsim Alanı Boş Olamaz");
    }
}
