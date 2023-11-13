using NCQ.Todo.App.Application.Repositories;
using NCQ.Todo.App.Domain.Entities;
using NCQ.Todo.App.Persistence.Context;

namespace NCQ.Todo.App.Persistence.Repositories
{
    public class CollaboratorRepository : BaseRepository<Collaborator>, ICollaboratorRepository
    {
        public CollaboratorRepository(DataContext context) : base(context)
        {
        }
    }
}
