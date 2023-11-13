using NCQ.Todo.App.Domain.Common;

namespace NCQ.Todo.App.Application.Repositories
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task<T> AddAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task<T?> Get(Guid id, CancellationToken cancellationToken);
        Task<List<T>> GetAll(CancellationToken cancellationToken);
        Task<bool> Exist(Guid id, CancellationToken cancellationToken);
    }
}
