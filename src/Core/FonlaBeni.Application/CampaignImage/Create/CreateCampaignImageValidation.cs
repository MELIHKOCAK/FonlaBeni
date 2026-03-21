using FluentValidation;

namespace FonlaBeni.Application.CampaignImage.Create;

public class CreateCampaignImageValidation : AbstractValidator<CreateCampaignImageDto>
{
    public CreateCampaignImageValidation()
    {
        RuleFor(x => x.Url)
            .NotEmpty()
            .WithMessage("Resim URL'si boş olamaz!");

        RuleFor(x => x.CampaignId)
            .NotEmpty()
            .WithMessage("Kampanya ID'si boş olamaz!");
    }
}
