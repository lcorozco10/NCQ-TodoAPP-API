using Microsoft.EntityFrameworkCore;
using NCQ.Todo.App.Application.Repositories;
using NCQ.Todo.App.Domain.Common;
using NCQ.Todo.App.Persistence.Context;

namespace NCQ.Todo.App.Persistence.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly DataContext Context;

        public BaseRepository(DataContext context)
        {
            Context = context;
        }

        public async Task<T> AddAsync(T entity)
        {
            await Context.Set<T>().AddAsync(entity);
            return entity;
        }

        public void Update(T entity)
        {
            Context.Update(entity);
        }

        public void Delete(T entity)
        {
            entity.DateCreated = DateTimeOffset.UtcNow;
            Context.Update(entity);
        }

        public Task<T?> Get(Guid id, CancellationToken cancellationToken)
        {
            return Context.Set<T>().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
        }

        public Task<List<T>> GetAll(CancellationToken cancellationToken)
        {
            return Context.Set<T>().ToListAsync(cancellationToken);
        }

        public Task<bool> Exist(Guid id, CancellationToken cancellationToken)
        {
            return Context.Set<T>().AnyAsync(x => x.Id == id, cancellationToken);
        }
    }
}
