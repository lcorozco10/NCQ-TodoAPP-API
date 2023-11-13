using Microsoft.EntityFrameworkCore;
using NCQ.Todo.App.Application.Dtos;
using NCQ.Todo.App.Application.Repositories;
using NCQ.Todo.App.Persistence.Context;

namespace NCQ.Todo.App.Persistence.Repositories
{
    public class TaskRepository : BaseRepository<Domain.Entities.Task>, ITaskRepository
    {
        public TaskRepository(DataContext context) : base(context)
        {
        }

        public async Task<List<TaskDto>> GetTaskWithNotes(CancellationToken cancellationToken)
        {
            return await Context.Tasks.Select(task => new TaskDto
            {
                Id = task.Id,
                Description = task.Description,
                Status = task.Status,
                PripriorityCode = task.PripriorityCode,
                StartDate = task.StartDate,
                EndDate = task.EndDate,
                CollaboratorId = task.CollaboratorId,
                CollaboratorName = task.Collaborator != null ? task.Collaborator.Name : null,
                Notes = task.Notes.Select(note => new NoteDto
                {
                    Id = note.Id,
                    Content = note.Content,
                }).ToList()
            }).ToListAsync(cancellationToken);
        }
    }
}
