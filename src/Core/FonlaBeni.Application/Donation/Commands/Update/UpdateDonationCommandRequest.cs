using FonlaBeni.Domain.Enums;
using MediatR;

namespace FonlaBeni.Application.Donation.Commands.Update;

public record UpdateDonationCommandRequest(Guid Id, PaymentStatus Status) :IRequest<UpdateDonationCommandResponse>;
