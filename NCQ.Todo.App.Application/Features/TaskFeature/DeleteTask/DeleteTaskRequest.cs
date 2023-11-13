using MediatR;

namespace NCQ.Todo.App.Application.Features.TaskFeature.DeleteTask
{
    public sealed record DeleteTaskRequest : IRequest<bool>
    {
        public Guid Id { get; set; }
    }
}
