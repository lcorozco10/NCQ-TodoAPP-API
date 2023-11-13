using AutoMapper;
using MediatR;
using NCQ.Todo.App.Application.Common.Exceptions;
using NCQ.Todo.App.Application.Repositories;
using Task = NCQ.Todo.App.Domain.Entities.Task;

namespace NCQ.Todo.App.Application.Features.TaskFeature.CreateTask
{
    public sealed class CreateTaskHandler : IRequestHandler<CreateTaskRequest, CreateTaskResponse>
    {
        private readonly ITaskRepository _taskRepository;
        private readonly ICollaboratorRepository _collaboratorRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateTaskHandler(
            ITaskRepository taskRepository,
            ICollaboratorRepository collaboratorRepository,
            IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _taskRepository = taskRepository;
            _collaboratorRepository = collaboratorRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<CreateTaskResponse> Handle(CreateTaskRequest request, CancellationToken cancellationToken)
        {
            // Validate Collborator id is valid
            if (request.CollaboratorId != null)
            {
                var isValidCollaborator = await _collaboratorRepository.Exist((Guid)request.CollaboratorId, cancellationToken);
                if (!isValidCollaborator)
                {
                    throw new BadRequestException("El Id del colaborador es invalido");
                }
            }

            // Mapping request to Task model
            var task = _mapper.Map<Task>(request);

            // Add Task record to the context
            task = await _taskRepository.AddAsync(task);

            // Save value
            await _unitOfWork.Save(cancellationToken);

            return _mapper.Map<CreateTaskResponse>(task);
        }
    }
}
