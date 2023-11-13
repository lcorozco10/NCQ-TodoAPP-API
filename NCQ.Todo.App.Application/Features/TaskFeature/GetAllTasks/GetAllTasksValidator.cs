using FluentValidation;
using NCQ.Todo.App.Application.Features.CollaboratorFeature.GetAllCollaborators;

namespace NCQ.Todo.App.Application.Features.TaskFeature.GetAllTasks
{
    public sealed class GetAllTasksValidator : AbstractValidator<GetAllCollaboratorsRequest>
    {
        public GetAllTasksValidator()
        {
        }
    }
}
