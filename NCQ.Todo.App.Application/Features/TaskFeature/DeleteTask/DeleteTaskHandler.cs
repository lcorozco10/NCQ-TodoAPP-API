using MediatR;
using NCQ.Todo.App.Application.Common.Exceptions;
using NCQ.Todo.App.Application.Repositories;

namespace NCQ.Todo.App.Application.Features.TaskFeature.DeleteTask
{
    public sealed class DeleteTaskHandler : IRequestHandler<DeleteTaskRequest, bool>
    {
        private readonly ITaskRepository _taskRepository;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteTaskHandler(
            ITaskRepository taskRepository,
            IUnitOfWork unitOfWork
        )
        {
            _taskRepository = taskRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(DeleteTaskRequest request, CancellationToken cancellationToken)
        {
            var task = await _taskRepository.Get(request.Id, cancellationToken);
            if (task == null || task.DateDeleted != null)
            {
                throw new NotFoundException($"No se encontro la tarea {request.Id}");
            }

            if (task.Status == Domain.Entities.TaskStatus.InProgress)
            {
                throw new BadRequestException("La tarea no puede ser eliminada en estado En Progreso");
            }

            // Soft Delete Strategy used
            task.DateDeleted = DateTime.Now;

            // Add Task record to the context
            _taskRepository.Update(task);

            // Save value
            await _unitOfWork.Save(cancellationToken);

            return true;
        }
    }
}
