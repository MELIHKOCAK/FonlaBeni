using FluentValidation;
using FonlaBeni.Application.Extensition;

namespace FonlaBeni.Application.Payment.Commands.Delete;

public class DeletePaymentValidation : AbstractValidator<DeletePaymentCommandRequest>
{
    public DeletePaymentValidation()
    {
        RuleFor(x => x.Id)
            .Cascade(CascadeMode.Stop)
            .IsRequired("Id");
    }
}


