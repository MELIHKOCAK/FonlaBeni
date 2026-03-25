using MediatR;

namespace FonlaBeni.Application.Donation.Commands.Delete
{
    public record DeleteDonationCommandRequest(Guid Id) : IRequest<DeleteDonationCommandResponse>;
}
