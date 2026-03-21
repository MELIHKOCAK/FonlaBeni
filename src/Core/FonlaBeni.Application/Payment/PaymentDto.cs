using FonlaBeni.Domain.Enums;

namespace FonlaBeni.Application.Payment;

public record PaymentDto(decimal Amount, DateTime PaymentAt, PaymentStatus Status, Providers ProviderName, string ProviderId, Guid DonationId);
