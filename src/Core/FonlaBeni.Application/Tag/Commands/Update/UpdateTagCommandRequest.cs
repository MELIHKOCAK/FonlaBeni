using MediatR;

namespace FonlaBeni.Application.Tag.Commands.Update;

public record UpdateTagCommandRequest(Guid Id):IRequest<UpdateTagCommandResponse>;
