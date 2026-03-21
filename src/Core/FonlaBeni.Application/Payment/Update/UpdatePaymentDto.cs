using FonlaBeni.Domain.Enums;

namespace FonlaBeni.Application.Payment.Update;

public record UpdatePaymentDto(Guid Id, PaymentStatus Status);
