using FonlaBeni.Domain.Enums;

namespace FonlaBeni.Application.Payment.Create;

public record CreatePaymentDto(decimal Amount, DateTime PaymentAt, Providers ProviderName, string ProviderId, Guid DonationId, PaymentStatus Status);
