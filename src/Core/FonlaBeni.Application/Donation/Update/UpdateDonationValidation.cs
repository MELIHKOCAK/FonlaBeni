using FluentValidation;
using FonlaBeni.Application.Extensition;

namespace FonlaBeni.Application.Donation.Update;
public class UpdateDonationValidation : AbstractValidator<UpdateDonationDto>
{
    public UpdateDonationValidation()
    {
        RuleFor(x => x.Id)
            .IsRequired("Bağış Id");

        RuleFor(x => x.Status)
          .Must(status => Enum.IsDefined(typeof(Domain.Enums.PaymentStatus), status));
    }
}
