using MediatR;

namespace FonlaBeni.Application.Donation.Commands.Create
{
    public class CreateDonationCommandHandler : IRequestHandler<CreateDonationCommandRequest, CreateDonationCommandResponse>
    {
        public Task<CreateDonationCommandResponse> Handle(CreateDonationCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
