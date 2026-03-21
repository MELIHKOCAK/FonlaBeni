using FluentValidation;
using FonlaBeni.Application.Extensition;

namespace FonlaBeni.Application.Campaign.Update;

public class UpdateCampaignValidation : AbstractValidator<UpdateCampaignDto>
{
    public UpdateCampaignValidation()
    {
        RuleFor(x => x.Id)
            .IsRequired("Id");

        RuleFor(x => x.Title)
            .IsRequired("Başlık")
            .MinimumLength(20)
            .MaximumLength(150)
            .WithMessage("Başlık 20 Karakterden Fazla Olmalı, Başlık 150 Karakterden Az Olmalı");

        RuleFor(x => x.Description)
            .IsRequired("Açıklama")
            .MinimumLength(300)
            .WithMessage("Açıklama En Az 300 Karakter Olmalıdır");

        RuleFor(x => x.CurrentAmount)
            .IsRequired("Mevcut Tutar")
            .GreaterThanOrEqualTo(0)
            .WithMessage("Mevcut Tutar Negatif Olamaz");

        RuleFor(x => x.BackersCount)
            .IsRequired("Destekçi Sayısı")
            .LessThan(0)
            .WithMessage("Destekçi Sayısı Negatif Olamaz.");

        RuleFor(x => x.Status)
            .Must(status => Enum.IsDefined(typeof(Domain.Enums.CampaignStatus), status));

        RuleFor(x => x.PayoutStatus)
           .Must(status => Enum.IsDefined(typeof(Domain.Enums.PaymentStatus), status));

        RuleFor(x => x.CategoryId)
           .IsRequired("Kategori Id");
    }
}
