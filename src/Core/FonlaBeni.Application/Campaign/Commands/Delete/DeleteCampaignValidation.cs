using FluentValidation;
using FonlaBeni.Application.Extensition;

namespace FonlaBeni.Application.Campaign.Commands.Delete;

public class DeleteCampaignValidation : AbstractValidator<DeleteCampaignCommandRequest>
{
    public DeleteCampaignValidation()
    {
        RuleFor(x => x.Id)
            .Cascade(CascadeMode.Stop)
            .IsRequired("Id");
    }
}


