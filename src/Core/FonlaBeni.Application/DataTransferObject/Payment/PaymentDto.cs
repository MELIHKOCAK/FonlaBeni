using FonlaBeni.Domain.Enums;

namespace FonlaBeni.Application.DataTransferObject.Payment;

public record PaymentDto(decimal Amount, DateTime PaymentAt, PaymentStatus Status, Providers ProviderName, string ProviderId, Guid DonationId);
