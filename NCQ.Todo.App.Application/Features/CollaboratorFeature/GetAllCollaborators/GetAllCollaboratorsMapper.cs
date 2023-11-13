using AutoMapper;
using NCQ.Todo.App.Domain.Entities;

namespace NCQ.Todo.App.Application.Features.CollaboratorFeature.GetAllCollaborators
{
    public sealed class GetAllCollaboratorsMapper : Profile
    {
        public GetAllCollaboratorsMapper()
        {
            CreateMap<Collaborator, GetAllCollaboratorsResponse>();
        }
    }
}
