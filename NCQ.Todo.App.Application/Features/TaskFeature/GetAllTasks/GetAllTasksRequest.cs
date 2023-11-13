using MediatR;

namespace NCQ.Todo.App.Application.Features.TaskFeature.GetAllTasks
{
    public sealed record GetAllTasksRequest() : IRequest<List<GetAllTasksResponse>>;
}
