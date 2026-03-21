using FluentValidation;
using FonlaBeni.Application.Extensition;

namespace FonlaBeni.Application.Payment.Update;
public class UpdatePaymentValidation : AbstractValidator<UpdatePaymentDto>
{
    public UpdatePaymentValidation()
    {
        RuleFor(x => x.Id)
            .IsRequired("Id")
            .Must(id => Guid.TryParse(id.ToString(), out _)).WithMessage("Geçersiz Id Değeri");

        RuleFor(x => x.Status)
          .Must(status => Enum.IsDefined(typeof(Domain.Enums.PaymentStatus), status));
    }
}
