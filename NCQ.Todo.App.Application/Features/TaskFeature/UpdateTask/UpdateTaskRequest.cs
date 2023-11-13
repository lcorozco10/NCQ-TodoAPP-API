using MediatR;
using NCQ.Todo.App.Domain.Entities;

namespace NCQ.Todo.App.Application.Features.TaskFeature.UpdateTask
{
    public record UpdateTaskRequestDto
    {
        public string Description { get; set; } = string.Empty;
        public Domain.Entities.TaskStatus Status { get; set; } = Domain.Entities.TaskStatus.Pending;
        public TaskPripriority? PripriorityCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public Guid? CollaboratorId { get; set; }
        public string Notes { get; set; } = string.Empty;
    }

    public sealed record UpdateTaskRequest : UpdateTaskRequestDto, IRequest<UpdateTaskResponse>
    {
        public Guid Id { get; set; }
    }
}
