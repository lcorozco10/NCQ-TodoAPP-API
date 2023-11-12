using NCQ.Todo.App.Domain.Common;

namespace NCQ.Todo.App.Domain.Entities
{
    public sealed class Note : BaseEntity
    {
        public string Content { get; set; } = string.Empty;
        public Guid TaskId { get; set; }
        public Task Task { get; set; } = new Task();
    }
}
