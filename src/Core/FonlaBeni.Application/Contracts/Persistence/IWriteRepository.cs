namespace FonlaBeni.Application.Contracts.Persistence
{
    public interface IWriteRepository<T>
    {
        ValueTask AddAsync(T Entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
