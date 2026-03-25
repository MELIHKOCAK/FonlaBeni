using FluentValidation;
using FonlaBeni.Application.Extensition;

namespace FonlaBeni.Application.Donation.Commands.Delete;

public class DeleteDonationValidation : AbstractValidator<DeleteDonationCommandRequest>
{
    public DeleteDonationValidation()
    {
        RuleFor(x => x.Id)
            .Cascade(CascadeMode.Stop)
            .IsRequired("Id");
    }
}


