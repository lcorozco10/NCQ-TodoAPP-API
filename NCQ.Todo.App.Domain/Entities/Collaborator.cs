using NCQ.Todo.App.Domain.Common;

namespace NCQ.Todo.App.Domain.Entities
{
    public sealed class Collaborator : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public ICollection<Task> Tasks { get; } = new List<Task>();
    }
}
