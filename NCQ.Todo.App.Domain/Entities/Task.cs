using NCQ.Todo.App.Domain.Common;

namespace NCQ.Todo.App.Domain.Entities
{
    public sealed class Task : BaseEntity
    {
        public string Description { get; set; } = string.Empty;
        public TaskStatus Status { get; set; }
        public TaskPripriority PripriorityCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? Notes { get; set; }
        public Guid? CollaboratorId { get; set; }
        public Collaborator? Collaborator { get; set; }
    }

    public enum TaskStatus { Pending, InProgress, Completed }
    public enum TaskPripriority { High, Medium, Low }
}
