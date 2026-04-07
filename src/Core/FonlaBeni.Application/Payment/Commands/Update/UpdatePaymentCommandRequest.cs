using FonlaBeni.Domain.Enums;
using MediatR;

namespace FonlaBeni.Application.Payment.Commands.Update;

public record UpdatePaymentCommandRequest(Guid Id, PaymentStatus Status): IRequest<UpdatePaymentCommandResponse>;
