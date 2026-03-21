using FluentValidation;
using FonlaBeni.Application.Extensition;

namespace FonlaBeni.Application.Campaign.Create;

public class CreateCampaignValidation:AbstractValidator<CreateCampaignDto>
{
    public CreateCampaignValidation()
    {
        RuleFor(x => x.CategoryId)
            .IsRequired("Kategori Id");

        RuleFor(x => x.TargetAmount)
            .IsRequired("Hedef Tutar")
            .GreaterThan(0).WithMessage("Hedef Tutar Sıfırdan Büyük Olmalıdır");

        RuleFor(x => x.Description)
            .IsRequired("Açıklama")
            .MinimumLength(300).WithMessage("Açıklama En Az 300 Karakter Olmalıdır");

        RuleFor(x => x.Title)
            .IsRequired("Başlık")
            .MinimumLength(20).WithMessage("Başlık En Az 20 Karakter Olmalı")
            .MaximumLength(150).WithMessage("Başlık 150 Karakterden Az Olmalı");

        RuleFor(x => x.DeadLine)
            .IsRequired("Bitiş Tarihi")
            .GreaterThan(DateTime.Now)
            .WithMessage("Kampanyanın Bitiş Tarihi Bugün Olarak İşaretlenemez");
    }
}
