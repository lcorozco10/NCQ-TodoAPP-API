using AutoMapper;

namespace NCQ.Todo.App.Application.Features.TaskFeature.UpdateTask
{
    public sealed class UpdateTaskMapper : Profile
    {
        public UpdateTaskMapper()
        {
            CreateMap<Domain.Entities.Task, UpdateTaskRequest>();
            CreateMap<UpdateTaskRequest, Domain.Entities.Task>();

            CreateMap<Domain.Entities.Task, UpdateTaskResponse>();
            CreateMap<UpdateTaskResponse, Domain.Entities.Task>();
        }
    }
}
