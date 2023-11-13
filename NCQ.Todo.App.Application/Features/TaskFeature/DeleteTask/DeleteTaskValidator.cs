using FluentValidation;

namespace NCQ.Todo.App.Application.Features.TaskFeature.DeleteTask
{
    public sealed class DeleteTaskValidator : AbstractValidator<DeleteTaskRequest>
    {
        public DeleteTaskValidator()
        {
            RuleFor(model => model.Id)
                .NotNull()
                .NotEmpty()
                .WithMessage("Campo no puede esta vacio");

        }
    }
}
