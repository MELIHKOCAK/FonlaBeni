using FluentValidation;
using FonlaBeni.Application.Extensition;

namespace FonlaBeni.Application.Tag.Commands.Create;

public class CreateTagValidation : AbstractValidator<CreateTagCommandRequest>
{
    public CreateTagValidation()
    {
        RuleFor(x => x.Name)
            .IsRequired("İsim");
    }
}
