using MediatR;

namespace FonlaBeni.Application.Donation.Commands.Update;

public record UpdateDonationCommandRequest(Guid Id):IRequest<UpdateDonationCommandResponse>;
