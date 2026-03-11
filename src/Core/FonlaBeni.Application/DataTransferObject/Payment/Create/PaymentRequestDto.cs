using FonlaBeni.Domain.Enums;

namespace FonlaBeni.Application.DataTransferObject.Payment.Create;

public record PaymentRequestDto(decimal Amount, DateTime PaymentAt, Providers ProviderName, string ProviderId, Guid DonationId, PaymentStatus Status);
