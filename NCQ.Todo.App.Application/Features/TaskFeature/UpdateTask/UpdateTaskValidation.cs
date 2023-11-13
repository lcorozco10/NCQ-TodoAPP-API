using FluentValidation;

namespace NCQ.Todo.App.Application.Features.TaskFeature.UpdateTask
{
    public sealed class UpdateTaskValidation : AbstractValidator<UpdateTaskRequest>
    {
        public UpdateTaskValidation()
        {
            RuleFor(model => model.Description)
                .NotNull()
                .WithMessage("Campo description requerido")
                .NotEmpty()
                .WithMessage("Campo no puede esta vacio")
                .MaximumLength(400)
                .WithMessage("El tamaño maximo de caracters permidos es 400 para el caompo Description");

            RuleFor(x => x.Status)
                .IsInEnum()
                .WithMessage("El valor status es invalido, debe esta el rango Pendiente = 0, En Progreso = 1, Finalizado = 2");

            When(model => model.Status == Domain.Entities.TaskStatus.InProgress || model.Status == Domain.Entities.TaskStatus.Completed, () =>
            {
                RuleFor(model => model.CollaboratorId).NotNull().WithMessage("El Colaborador es requerido cuando la tarea ha sido iniciada o finalizada");
            });

            RuleFor(model => model.PripriorityCode)
                .NotNull()
                .WithMessage("Campo pripriorityCode requerido")
                .IsInEnum()
                .WithMessage("El valor pripriorityCode es invalido, debe esta el rango Alta = 0, Media = 1, Baja = 2");

            RuleFor(model => model.StartDate)
                .NotNull()
                .WithMessage("Campo startDate requerido");

            RuleFor(model => model.EndDate)
                .NotNull()
                .WithMessage("Campo endDate requerido.")
                .GreaterThanOrEqualTo(model => model.StartDate)
                .WithMessage("La fecha de fin debe ser posterior a la fecha inicio");
        }
    }
}
