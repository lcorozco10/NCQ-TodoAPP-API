using NCQ.Todo.App.Application.Dtos;
using Task = NCQ.Todo.App.Domain.Entities.Task;

namespace NCQ.Todo.App.Application.Repositories
{
    public interface ITaskRepository : IBaseRepository<Task>
    {
        Task<List<TaskDto>> GetTaskWithNotes(CancellationToken cancellationToken);
    }
}
