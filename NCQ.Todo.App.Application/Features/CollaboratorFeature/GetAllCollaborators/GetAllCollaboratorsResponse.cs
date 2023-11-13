namespace NCQ.Todo.App.Application.Features.CollaboratorFeature.GetAllCollaborators
{
    public sealed record GetAllCollaboratorsResponse
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
    }
}
