using MediatR;
namespace FonlaBeni.Application.Donation.Commands.Update;
public class UpdateDonationCommandHandler : IRequestHandler<UpdateDonationCommandRequest, UpdateDonationCommandResponse>
{
    public Task<UpdateDonationCommandResponse> Handle(UpdateDonationCommandRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}

