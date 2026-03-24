using FluentValidation;
using FonlaBeni.Application.Extensition;

namespace FonlaBeni.Application.CampaignImage.Commands.Create;

public class CreateCampaignImageValidation : AbstractValidator<CreateCampaignImageCommandRequest>
{
    public CreateCampaignImageValidation()
    {
        RuleFor(x => x.Url)
            .IsRequired("Url");

        RuleFor(x => x.CampaignId)
            .IsRequired("Kampanya Id");
    }
}
