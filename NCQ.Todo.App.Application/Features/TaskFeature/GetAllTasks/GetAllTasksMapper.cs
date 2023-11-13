using AutoMapper;
using NCQ.Todo.App.Application.Dtos;

namespace NCQ.Todo.App.Application.Features.TaskFeature.GetAllTasks
{
    public sealed class GetAllTasksMapper : Profile
    {
        public GetAllTasksMapper()
        {
            CreateMap<Domain.Entities.Task, GetAllTasksResponse>();
            CreateMap<TaskDto, GetAllTasksResponse>();
        }
    }
}
