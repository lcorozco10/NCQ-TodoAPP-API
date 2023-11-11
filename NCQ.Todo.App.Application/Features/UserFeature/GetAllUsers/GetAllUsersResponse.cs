namespace NCQ.Todo.App.Application.Features.UserFeature.GetAllUsers
{
    public sealed record GetAllUsersResponse
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
    }
}
