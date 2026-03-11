using FonlaBeni.Domain.Enums;

namespace FonlaBeni.Application.DataTransferObject.Donation.Update;

public record UpdateDonationDto(Guid Id, PaymentStatus Status, string Message, bool IsAnonymous);