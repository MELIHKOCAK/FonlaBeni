using System.Linq.Expressions;

namespace FonlaBeni.Application.Contracts.Persistence
{
    public interface IReadRepository<T>
    {
        IQueryable<T> GetAll(bool isShouldTrackChanges);
        IQueryable<T> Where(Expression<Func<T, bool>> predicate, bool isShouldTrackChanges);
        ValueTask<T?> GetByIdAsync(Guid id);
    }

}
