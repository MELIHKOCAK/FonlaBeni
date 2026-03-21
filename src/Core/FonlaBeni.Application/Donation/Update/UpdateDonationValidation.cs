using FluentValidation;

namespace FonlaBeni.Application.Donation.Update;
public class UpdateDonationValidation : AbstractValidator<UpdateDonationDto>
{
    public UpdateDonationValidation()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage("Bağış Id'si Boş Olamaz!");

        RuleFor(x => x.Status)
          .Must(status => Enum.IsDefined(typeof(Domain.Enums.PaymentStatus), status));
    }
}
