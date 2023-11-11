using Microsoft.EntityFrameworkCore;
using NCQ.Todo.App.Application.Repositories;
using NCQ.Todo.App.Domain.Entities;
using NCQ.Todo.App.Persistence.Context;

namespace NCQ.Todo.App.Persistence.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(DataContext context) : base(context)
        {
        }

        public Task<User?> GetByEmail(string email, CancellationToken cancellationToken)
        {
            return Context.Users.FirstOrDefaultAsync(x => x.Email == email, cancellationToken);
        }
    }
}
