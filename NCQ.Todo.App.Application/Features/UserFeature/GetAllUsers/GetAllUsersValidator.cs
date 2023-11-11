using FluentValidation;

namespace NCQ.Todo.App.Application.Features.UserFeature.GetAllUsers
{
    public sealed class GetAllUsersValidator : AbstractValidator<GetAllUsersRequest>
    {
        public GetAllUsersValidator()
        {
            // RuleFor(x => x.Name).NotEmpty().MinimumLength(3).MaximumLength(50);
        }
    }
}
