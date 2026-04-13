using FluentValidation;
using FonlaBeni.Application.Extensition;

namespace FonlaBeni.Application.AppUser.Commands.Update;

public class UpdateUserValidation : AbstractValidator<UpdateUserCommandRequest>
{
    public UpdateUserValidation()
    {
        RuleFor(x => x.Id)
            .IsRequired("Id");

        RuleFor(x => x.Name)
            .Cascade(CascadeMode.Stop)
            .IsRequired("İsim");

        RuleFor(x => x.Surname)
            .Cascade(CascadeMode.Stop)
            .IsRequired("Soyisim");

        RuleFor(x => x.ProfileImageUrl)
            .Cascade(CascadeMode.Stop)
            .IsRequired("Profil Resmi");
        RuleFor(x => x.PhoneNumber)
            .Cascade(CascadeMode.Stop)
            .IsRequired("Telefon Numarası");
    }
}
