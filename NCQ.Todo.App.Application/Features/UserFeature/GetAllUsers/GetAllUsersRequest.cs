using MediatR;

namespace NCQ.Todo.App.Application.Features.UserFeature.GetAllUsers
{

    public sealed record GetAllUsersRequest() : IRequest<GetAllUsersResponse>;
}
