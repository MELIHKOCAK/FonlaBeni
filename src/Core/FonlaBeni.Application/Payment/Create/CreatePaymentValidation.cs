using FluentValidation;

namespace FonlaBeni.Application.Payment.Create;

public class CreatePaymentValidation : AbstractValidator<CreatePaymentDto>
{
    public CreatePaymentValidation()
    {
        RuleFor(x => x.ProviderId)
            .NotNull().WithMessage("Sağlayıcı Id Boş Olamaz.");

        RuleFor(x => x.ProviderName)
            .Must(provider => Enum.IsDefined(typeof(Domain.Enums.Providers), provider));

        RuleFor(x => x.Amount)
            .GreaterThan(0).WithMessage("Tutar sıfırdan büyük olmalıdır.");

        RuleFor(x => x.PaymentAt)
            .LessThanOrEqualTo(DateTime.Now).WithMessage("Ödeme tarihi bugünden büyük olamaz.");

        RuleFor(x => x.Status)
          .Must(status => Enum.IsDefined(typeof(Domain.Enums.PaymentStatus), status));
    }
}
