using FluentValidation;
using FonlaBeni.Application.Extensition;

namespace FonlaBeni.Application.CampaignImage.Create;

public class CreateCampaignImageValidation : AbstractValidator<CreateCampaignImageDto>
{
    public CreateCampaignImageValidation()
    {
        RuleFor(x => x.Url)
            .IsRequired("Url");

        RuleFor(x => x.CampaignId)
            .IsRequired("Kampanya Id");
    }
}
