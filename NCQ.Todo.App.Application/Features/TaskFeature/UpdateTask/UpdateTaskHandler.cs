using AutoMapper;
using MediatR;
using NCQ.Todo.App.Application.Common.Exceptions;
using NCQ.Todo.App.Application.Repositories;

namespace NCQ.Todo.App.Application.Features.TaskFeature.UpdateTask
{
    public sealed class UpdateTaskHandler : IRequestHandler<UpdateTaskRequest, UpdateTaskResponse>
    {
        private readonly ITaskRepository _taskRepository;
        private readonly ICollaboratorRepository _collaboratorRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateTaskHandler(
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

        public async Task<UpdateTaskResponse> Handle(UpdateTaskRequest request, CancellationToken cancellationToken)
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

            var task = await _taskRepository.Get(request.Id, cancellationToken);
            if (task == null)
            {
                throw new NotFoundException($"No se encontro la tarea {request.Id}");
            }

            if (task.Status == Domain.Entities.TaskStatus.Completed)
            {
                throw new BadRequestException("La tarea no puede ser modificada en estado Finalizado");
            }

            // Mapping request to Task model
            task.Description = request.Description;
            task.Status = request.Status;
            task.PripriorityCode = request.PripriorityCode ?? Domain.Entities.TaskPripriority.Low;
            task.CollaboratorId = request.CollaboratorId;
            task.StartDate = request.StartDate ?? DateTime.Now;
            task.EndDate = request.EndDate ?? DateTime.Now;
            task.Notes = request.Notes;
            task.DateUpdated = DateTime.Now;

            // Add Task record to the context
            _taskRepository.Update(task);

            // Save value
            await _unitOfWork.Save(cancellationToken);

            return _mapper.Map<UpdateTaskResponse>(task);
        }
    }
}
