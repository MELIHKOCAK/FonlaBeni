using FluentValidation;
using FonlaBeni.Application.DataTransferObject.Donation.Create;

namespace FonlaBeni.Application.Validation;

public class CreateDonationValidation : AbstractValidator<CreateDonationDto>
{
    public CreateDonationValidation()
    {
        RuleFor(x => x.Amount)
            .NotNull().WithMessage("Tutar Alanı Boş Geçilemez")
            .GreaterThan(0).WithMessage("Tutar 0'dan büyük olmalıdır");

        RuleFor(x => x.UserId)
            .NotNull().WithMessage("Kullanıcı Id Alanı Boş Geçilemez");

        RuleFor(x => x.CampaignId)
            .NotNull().WithMessage("Kampanya Id Alanı Boş Geçilemez");
    }
}
