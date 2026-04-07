using FluentValidation;
using FonlaBeni.Application.Extensition;

namespace FonlaBeni.Application.Campaign.Commands.Update;

public class UpdateCampaignValidation:AbstractValidator<UpdateCampaignCommandRequest>
{
    public UpdateCampaignValidation()
    {
        RuleFor(x => x.Description)
            .Cascade(CascadeMode.Stop)
            .IsRequired("Açıklama")
            .MinimumLength(300).WithMessage("Açıklama En Az 300 Karakter Olmalıdır");

        RuleFor(x => x.Title)
            .Cascade(CascadeMode.Stop)
            .IsRequired("Başlık")
            .MinimumLength(20).WithMessage("Başlık En Az 20 Karakter Olmalı")
            .MaximumLength(150).WithMessage("Başlık 150 Karakterden Az Olmalı");
    }
}
