using MediatR;

namespace FonlaBeni.Application.Tag.Commands.Create
{
    public record CreateTagCommandRequest(string Name, string Slug) : IRequest<CreateTagCommandResponse>;
}
