using FluentValidation;
using FonlaBeni.Application.Extensition;

namespace FonlaBeni.Application.Donation.Commands.Create;

public class CreateDonationValidation : AbstractValidator<CreateDonationCommandRequest>
{
    public CreateDonationValidation()
    {
        RuleFor(x => x.Amount)
            .Cascade(CascadeMode.Stop)
            .IsRequired("Tutar")
            .GreaterThan(0).WithMessage("Tutar 0'dan büyük olmalıdır");

        RuleFor(x => x.UserId)
            .IsRequired("Kullanıcı Id");

        RuleFor(x => x.CampaignId)
            .IsRequired("Kampanya Id");
    }
}
