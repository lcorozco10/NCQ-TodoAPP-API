using AutoMapper;
using NCQ.Todo.App.Application.Dtos;

namespace NCQ.Todo.App.Application.Features.TaskFeature.GetAllTasks
{
    public sealed class GetAllTasksMapper : Profile
    {
        public GetAllTasksMapper()
        {
            CreateMap<Domain.Entities.Task, GetAllTasksResponse>();
            CreateMap<Domain.Entities.Note, GetAllTaskNoteResponse>();

            CreateMap<TaskDto, GetAllTasksResponse>();
            CreateMap<NoteDto, GetAllTaskNoteResponse>();
        }
    }
}
