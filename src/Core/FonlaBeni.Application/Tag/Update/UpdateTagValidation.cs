using FluentValidation;
using FonlaBeni.Application.Extensition;

namespace FonlaBeni.Application.Tag.Update;
public class UpdateTagValidation : AbstractValidator<UpdateTagDto>
{
    public UpdateTagValidation()
    {
        RuleFor(x => x.Id)
            .IsRequired("Id");

        RuleFor(x => x.Name)
            .IsRequired("İsim");
    }
}
