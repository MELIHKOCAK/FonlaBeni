using FluentValidation;
using FonlaBeni.Application.Extensition;

namespace FonlaBeni.Application.Donation.Commands.Update;

public class UpdateDonationValidation : AbstractValidator<UpdateDonationCommandRequest>
{
    public UpdateDonationValidation()
    {
        RuleFor(x => x.Id)
             .IsRequired("Id");
    }
}
