using FluentValidation;
using NCQ.Todo.App.Application.Features.CollaboratorFeature.GetAllCollaborators;

namespace NCQ.Todo.App.Application.Features.TaskFeature.CreateTask
{
    public sealed class CreateTaskValidator : AbstractValidator<GetAllCollaboratorsRequest>
    {
        public CreateTaskValidator()
        {
        }
    }
}
