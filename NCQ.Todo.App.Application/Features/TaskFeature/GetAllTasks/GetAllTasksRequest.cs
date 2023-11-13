using MediatR;
using TaskStatus = NCQ.Todo.App.Domain.Entities.TaskStatus;

namespace NCQ.Todo.App.Application.Features.TaskFeature.GetAllTasks
{
    public sealed record GetAllTasksRequest : IRequest<List<GetAllTasksResponse>>
    {
        public Guid? CollaboratorId { get; set; }
        public TaskStatus? Status { get; set; }
        public Domain.Entities.TaskPripriority? PripriorityCode { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }
}
