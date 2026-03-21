using FonlaBeni.Domain.Enums;

namespace FonlaBeni.Application.Donation.Update;

public record UpdateDonationDto(Guid Id, PaymentStatus Status, string Message, bool IsAnonymous);