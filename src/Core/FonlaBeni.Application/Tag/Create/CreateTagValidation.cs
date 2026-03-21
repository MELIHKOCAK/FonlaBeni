using FluentValidation;
using FonlaBeni.Application.Extensition;

namespace FonlaBeni.Application.Tag.Create;

public class CreateTagValidation: AbstractValidator<CreateTagDto>
{
    public CreateTagValidation()
    {
        RuleFor(x => x.Name)
            .IsRequired("İsim");
    }
}
