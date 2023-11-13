using MediatR;

namespace NCQ.Todo.App.Application.Features.CollaboratorFeature.GetAllCollaborators
{

    public sealed record GetAllCollaboratorsRequest() : IRequest<List<GetAllCollaboratorsResponse>>;
}
