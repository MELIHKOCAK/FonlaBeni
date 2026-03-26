using FluentValidation;
using FonlaBeni.Application.Extensition;

namespace FonlaBeni.Application.Tag.Commands.Update;

public class UpdateTagValidation : AbstractValidator<UpdateTagCommandRequest>
{
    public UpdateTagValidation()
    {
        RuleFor(x => x.Id)
            .IsRequired("Kategori Id");
    }
}
