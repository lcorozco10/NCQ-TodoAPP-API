using AutoMapper;
using MediatR;
using NCQ.Todo.App.Application.Repositories;

namespace NCQ.Todo.App.Application.Features.TaskFeature.CreateTask
{
    public sealed class CreateTaskHandler : IRequestHandler<CreateTaskRequest, CreateTaskResponse>
    {
        private readonly ITaskRepository _taskRepository;
        private readonly IMapper _mapper;

        public CreateTaskHandler(
            ITaskRepository taskRepository,
            IMapper mapper)
        {
            _taskRepository = taskRepository;
            _mapper = mapper;
        }

        public async Task<CreateTaskResponse> Handle(CreateTaskRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            //var collaborators = await _taskRepository.GetTaskWithNotes(cancellationToken);

            //return _mapper.Map<CreateTaskResponse>(collaborators);
        }
    }
}
