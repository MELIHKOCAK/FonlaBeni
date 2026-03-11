using FonlaBeni.Domain.Enums;

namespace FonlaBeni.Application.DataTransferObject.Payment.Update;

public record UpdatePaymentDto(Guid Id, PaymentStatus Status);
