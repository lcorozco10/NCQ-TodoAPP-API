using AutoMapper;

namespace NCQ.Todo.App.Application.Features.TaskFeature.CreateTask
{
    public sealed class CreateTaskMapper : Profile
    {
        public CreateTaskMapper()
        {
            CreateMap<Domain.Entities.Task, CreateTaskRequest>();
            CreateMap<CreateTaskRequest, Domain.Entities.Task>();

            CreateMap<Domain.Entities.Task, CreateTaskResponse>();
            CreateMap<CreateTaskResponse, Domain.Entities.Task>();
        }
    }
}
