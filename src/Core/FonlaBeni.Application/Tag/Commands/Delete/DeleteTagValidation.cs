using FluentValidation;
using FonlaBeni.Application.Extensition;

namespace FonlaBeni.Application.Tag.Commands.Delete;

public class DeleteTagValidation : AbstractValidator<DeleteTagCommandRequest>
{
    public DeleteTagValidation()
    {
        RuleFor(x => x.Id)
            .Cascade(CascadeMode.Stop)
            .IsRequired("Id");
    }
}


