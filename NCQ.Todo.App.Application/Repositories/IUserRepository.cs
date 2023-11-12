using NCQ.Todo.App.Domain.Entities;

namespace NCQ.Todo.App.Application.Repositories
{
    public interface IUserRepository : IBaseRepository<Collaborator>
    {
        Task<Collaborator?> GetByEmail(string email, CancellationToken cancellationToken);
    }
}
