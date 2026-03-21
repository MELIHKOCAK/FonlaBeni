using FluentValidation;

namespace FonlaBeni.Application.Campaign.Create;

public class CreateCampaignValidation:AbstractValidator<CreateCampaignDto>
{
    public CreateCampaignValidation()
    {
        RuleFor(x=> x.CategoryId)
            .NotEmpty()
            .WithMessage("Kategori Boş Olamaz! Lütfen Bir Kategori Seçiniz...");

        RuleFor(x => x.TargetAmount)
            .NotEmpty()
            .GreaterThan(0)
            .WithMessage("Hedef Tutar Boş Olamaz Ve Sıfırdan Büyük Olmalıdır");

        RuleFor(x => x.Description)
            .NotEmpty()
            .MinimumLength(300)
            .WithMessage("Açıklama Boş Olamaz, Açıklama En Az 300 Karakter Olmalıdır");

        RuleFor(x => x.Title)
            .MinimumLength(20)
            .NotEmpty()
            .MaximumLength(150)
            .WithMessage("Başlık Boş Olamaz, Başlık 20 Karakterden Fazla Olmalı, Başlık 150 Karakterden Az Olmalı");

        RuleFor(x => x.DeadLine)
            .NotEmpty()
            .GreaterThan(DateTime.Now)
            .WithMessage("Kampanyanın Bitiş Tarihi Boş Olamaz Ve Bugün Olarak İşaretlenemez");
    }
}
