using Microsoft.EntityFrameworkCore;
using NCQ.Todo.App.Application.Dtos;
using NCQ.Todo.App.Application.Repositories;
using NCQ.Todo.App.Persistence.Context;
using System.Linq.Expressions;

namespace NCQ.Todo.App.Persistence.Repositories
{
    public class TaskRepository : BaseRepository<Domain.Entities.Task>, ITaskRepository
    {
        public TaskRepository(DataContext context) : base(context)
        {
        }

        public async Task<List<TaskDto>> GetTaskWithNotes(TaskFilterDto filter, CancellationToken cancellationToken)
        {
            // Collaborator filter
            Expression<Func<Domain.Entities.Task, bool>> collaboratorPredicate = task => true;
            if (filter.CollaboratorId != null)
            {
                collaboratorPredicate = task => task.CollaboratorId == filter.CollaboratorId;
            }

            // Status filter
            Expression<Func<Domain.Entities.Task, bool>> statusPredicate = task => true;
            if (filter.Status != null)
            {
                statusPredicate = task => task.Status == filter.Status;
            }

            // Priority filter
            Expression<Func<Domain.Entities.Task, bool>> priorityPredicate = task => true;
            if (filter.PripriorityCode != null)
            {
                priorityPredicate = task => task.PripriorityCode == filter.PripriorityCode;
            }

            // FromDate filter
            Expression<Func<Domain.Entities.Task, bool>> fromDatePredicate = task => true;
            if (filter.FromDate != null)
            {
                fromDatePredicate = task => task.StartDate >= filter.FromDate;
            }

            // ToDate filter
            Expression<Func<Domain.Entities.Task, bool>> toDatePredicate = task => true;
            if (filter.ToDate != null)
            {
                // Validate data interception
                toDatePredicate = task => task.EndDate <= filter.ToDate || task.StartDate <= filter.ToDate;
            }

            var query = Context.Tasks
                .Where(task => task.DateDeleted == null)
                .Where(collaboratorPredicate)
                .Where(statusPredicate)
                .Where(priorityPredicate)
                .Where(fromDatePredicate)
                .Where(toDatePredicate)
                .OrderBy(task => task.StartDate)
                .Select(task => new TaskDto
                {
                    Id = task.Id,
                    Description = task.Description,
                    Status = task.Status,
                    PripriorityCode = task.PripriorityCode,
                    StartDate = task.StartDate,
                    EndDate = task.EndDate,
                    CollaboratorId = task.CollaboratorId,
                    CollaboratorName = task.Collaborator != null ? task.Collaborator.Name : null,
                    Notes = task.Notes ?? string.Empty
                })
                .AsNoTracking()
                .TagWith("GetTaskWithNotes TaskRepository");


            var compiledQuery = EF.CompileAsyncQuery((DbContext context) => query);

            return await compiledQuery(Context).ToListAsync(cancellationToken);

        }
    }
}
