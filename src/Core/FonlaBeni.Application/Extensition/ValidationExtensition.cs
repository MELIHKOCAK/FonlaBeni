using FluentValidation;

namespace FonlaBeni.Application.Extensition
{
    public static class ValidationExtensition
    {
        public static IRuleBuilderOptions<T, string> IsRequired<T>(this IRuleBuilder<T, string> ruleBuilder, string fieldName)
        {
            return ruleBuilder
                .NotEmpty()
                .WithMessage($"{fieldName} Alanı Boş Bırakılamaz.");
        }

        public static IRuleBuilderOptions<T, TProperty> IsRequired<T, TProperty>(this IRuleBuilder<T, TProperty> ruleBuilder, string fieldName)
        {
            return ruleBuilder
                .NotNull()
                .WithMessage($"{fieldName} Alanı Boş Bırakılamaz.");
        }
    }
}
