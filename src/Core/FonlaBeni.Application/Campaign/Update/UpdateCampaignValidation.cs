using FluentValidation;

namespace FonlaBeni.Application.Campaign.Update;

public class UpdateCampaignValidation : AbstractValidator<UpdateCampaignDto>
{
    public UpdateCampaignValidation()
    {
        RuleFor(x => x.Id)
            .NotNull()
            .WithMessage("Id Alanı Boş Olamaz");

        RuleFor(x => x.Title)
            .MinimumLength(20)
            .NotEmpty()
            .MaximumLength(150)
            .WithMessage("Başlık Boş Olamaz, Başlık 20 Karakterden Fazla Olmalı, Başlık 150 Karakterden Az Olmalı");

        RuleFor(x => x.Description)
            .NotEmpty()
            .MinimumLength(300)
            .WithMessage("Açıklama Boş Olamaz, Açıklama En Az 300 Karakter Olmalıdır");

        RuleFor(x => x.CurrentAmount)
            .NotEmpty()
            .GreaterThanOrEqualTo(0)
            .WithMessage("Mevcut Tutar Boş Olamaz Ve Negatif Olamaz");

        RuleFor(x => x.BackersCount)
            .NotEmpty()
            .LessThan(0)
            .WithMessage("Destekçi Sayısı Negatif Olamaz.");

        RuleFor(x => x.Status)
            .Must(status => Enum.IsDefined(typeof(Domain.Enums.CampaignStatus), status));

        RuleFor(x => x.PayoutStatus)
           .Must(status => Enum.IsDefined(typeof(Domain.Enums.PaymentStatus), status));

        RuleFor(x => x.CategoryId)
           .NotEmpty()
           .WithMessage("Kategori Boş Olamaz! Lütfen Bir Kategori Seçiniz...");
    }
}
