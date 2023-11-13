using NCQ.Todo.App.Domain.Entities;

namespace NCQ.Todo.App.Application.Dtos
{
    public sealed record TaskDto
    {
        public Guid Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public Domain.Entities.TaskStatus Status { get; set; }
        public TaskPripriority PripriorityCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid? CollaboratorId { get; set; }
        public string? CollaboratorName { get; set; }
        public string Notes { get; set; } = string.Empty;
    }

    public sealed record TaskFilterDto
    {
        public Guid? CollaboratorId { get; set; }
        public Domain.Entities.TaskStatus? Status { get; set; }
        public TaskPripriority? PripriorityCode { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }
}
