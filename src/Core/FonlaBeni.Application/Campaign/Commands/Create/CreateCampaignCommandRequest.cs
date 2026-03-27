using FonlaBeni.Domain.Enums;
using MediatR;

namespace FonlaBeni.Application.Campaign.Commands.Create
{
    public record CreateCampaignCommandRequest(string Title, string Description, string Slug, decimal TargetAmount, decimal CurrentAmount, int BackersCount, DateTime DeadLine, CampaignStatus Status) : IRequest<CreateCampaignCommandResponse>;
}
