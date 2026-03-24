
using FluentValidation;
using MediatR;
using Microsoft.IdentityModel.Tokens;

namespace FonlaBeni.Application.Pipelines
{
    public class ValidationBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
        where TRequest : notnull
    {
        private readonly IEnumerable<IValidator<TRequest>> _validators;

        public ValidationBehavior(IEnumerable<IValidator<TRequest>> validators)
        {
            _validators = validators;
        }

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            if (_validators.Any() == false)
                return await next();


            var context = new ValidationContext<TRequest>(request);

            // Tüm doğrulama kurallarını asenkron olarak çalıştır ve sonuçları topla
            var validationResults = await Task.WhenAll(
                _validators.Select(v => v.ValidateAsync(context, cancellationToken)));

            // İçlerinde hata (Error) olanları filtrele
            var failures = validationResults
                .Where(r => !r.IsValid)
                .SelectMany(r => r.Errors)
                .ToList();

            if (failures.Count != 0)
                // Eğer kural ihlali varsa, FluentValidation'ın exception'ını fırlat!
                // Bu sayede request asla Handler'a ulaşmaz, işlem iptal olur.
                throw new ValidationException(failures);


            // Eğer hata yoksa (veya bu request için validator yazılmamışsa) yola devam et
            return await next();
        }
    }
}
