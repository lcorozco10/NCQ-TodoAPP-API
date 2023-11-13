using NCQ.Todo.App.Domain.Common;

namespace NCQ.Todo.App.Domain.Entities
{
    public sealed class Note : BaseEntity
    {
        public string Content { get; set; } = string.Empty;
        public Guid TaskId { get; set; }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Task Task { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    }
}
