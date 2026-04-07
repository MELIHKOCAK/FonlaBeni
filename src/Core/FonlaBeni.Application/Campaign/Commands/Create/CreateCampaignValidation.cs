using FluentValidation;
using FonlaBeni.Application.Campaign.Commands.Create;
using FonlaBeni.Application.Extensition;

namespace FonlaBeni.Application.Campaign.Create;

public class CreateCampaignValidation:AbstractValidator<CreateCampaignCommandRequest>
{
    public CreateCampaignValidation()
    {
        RuleFor(x => x.TargetAmount)
            .Cascade(CascadeMode.Stop)  
            .IsRequired("Hedef Tutar")
            .GreaterThan(0).WithMessage("Hedef Tutar Sıfırdan Büyük Olmalıdır");

        RuleFor(x => x.Description)
            .Cascade(CascadeMode.Stop)
            .IsRequired("Açıklama")
            .MinimumLength(300).WithMessage("Açıklama En Az 300 Karakter Olmalıdır");

        RuleFor(x => x.Title)
            .Cascade(CascadeMode.Stop)
            .IsRequired("Başlık")
            .MinimumLength(20).WithMessage("Başlık En Az 20 Karakter Olmalı")
            .MaximumLength(150).WithMessage("Başlık 150 Karakterden Az Olmalı");

        RuleFor(x => x.DeadLine)
            .Cascade(CascadeMode.Stop)
            .IsRequired("Bitiş Tarihi")
            .GreaterThan(DateTime.Now)
            .WithMessage("Kampanyanın Bitiş Tarihi Bugün Olarak İşaretlenemez");
    }
}
