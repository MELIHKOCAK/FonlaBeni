using MediatR;

namespace FonlaBeni.Application.Tag.Commands.Update;

public record UpdateTagCommandRequest(Guid Id, string Name, string Slug) :IRequest<UpdateTagCommandResponse>;
