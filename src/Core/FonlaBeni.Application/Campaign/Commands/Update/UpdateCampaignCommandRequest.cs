using FonlaBeni.Domain.Enums;
using MediatR;

namespace FonlaBeni.Application.Campaign.Commands.Update;

public record UpdateCampaignCommandRequest(Guid Id, string Title, string Description, decimal CurrentAmount, int BackersCount, CampaignStatus Status) :IRequest<UpdateCampaignCommandResponse>;
