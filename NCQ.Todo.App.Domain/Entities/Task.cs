using NCQ.Todo.App.Domain.Common;

namespace NCQ.Todo.App.Domain.Entities
{
    public sealed class Task : BaseEntity
    {
        public string Description { get; set; } = string.Empty;
        public int StateCode { get; set; }
        public int PripriorityCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid? CollaboratorId { get; set; }
        public Collaborator? Collaborator { get; set; }
    }
}
