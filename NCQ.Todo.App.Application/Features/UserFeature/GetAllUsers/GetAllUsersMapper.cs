using AutoMapper;
using NCQ.Todo.App.Domain.Entities;

namespace NCQ.Todo.App.Application.Features.UserFeature.GetAllUsers
{
    public sealed class GetAllUsersMapper : Profile
    {
        public GetAllUsersMapper()
        {
            CreateMap<Collaborator, GetAllUsersResponse>();
        }
    }
}
