using MediatR;

namespace FonlaBeni.Application.Donation.Commands.Delete
{
    public class DeleteDonationCommandHandler : IRequestHandler<DeleteDonationCommandRequest, DeleteDonationCommandResponse>
    {
        public Task<DeleteDonationCommandResponse> Handle(DeleteDonationCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
