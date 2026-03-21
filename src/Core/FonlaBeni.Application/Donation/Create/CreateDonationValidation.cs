using FluentValidation;
using FonlaBeni.Application.Extensition;

namespace FonlaBeni.Application.Donation.Create;

public class CreateDonationValidation : AbstractValidator<CreateDonationDto>
{
    public CreateDonationValidation()
    {
        RuleFor(x => x.Amount)
            .IsRequired("Tutar")
            .GreaterThan(0).WithMessage("Tutar 0'dan büyük olmalıdır");

        RuleFor(x => x.UserId)
            .IsRequired("Kullanıcı Id");

        RuleFor(x => x.CampaignId)
            .IsRequired("Kampanya Id");
    }
}
