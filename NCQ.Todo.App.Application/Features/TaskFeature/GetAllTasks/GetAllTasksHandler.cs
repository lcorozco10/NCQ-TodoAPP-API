using AutoMapper;
using MediatR;
using NCQ.Todo.App.Application.Dtos;
using NCQ.Todo.App.Application.Repositories;

namespace NCQ.Todo.App.Application.Features.TaskFeature.GetAllTasks
{
    public sealed class GetAllTasksHandler : IRequestHandler<GetAllTasksRequest, List<GetAllTasksResponse>>
    {
        private readonly ITaskRepository _taskRepository;
        private readonly IMapper _mapper;

        public GetAllTasksHandler(
            ITaskRepository taskRepository,
            IMapper mapper)
        {
            _taskRepository = taskRepository;
            _mapper = mapper;
        }

        public async Task<List<GetAllTasksResponse>> Handle(GetAllTasksRequest request, CancellationToken cancellationToken)
        {
            var filter = _mapper.Map<TaskFilterDto>(request);
            var collaborators = await _taskRepository.GetTaskWithNotes(filter, cancellationToken);

            return _mapper.Map<List<GetAllTasksResponse>>(collaborators);
        }
    }
}
