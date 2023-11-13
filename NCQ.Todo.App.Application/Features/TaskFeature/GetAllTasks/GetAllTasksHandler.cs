using AutoMapper;
using MediatR;
using NCQ.Todo.App.Application.Repositories;

namespace NCQ.Todo.App.Application.Features.TaskFeature.GetAllTasks
{
    public sealed class GetAllTasksHandler : IRequestHandler<GetAllTasksRequest, List<GetAllTasksResponse>>
    {
        private readonly ICollaboratorRepository _collaboratorRepository;
        private readonly IMapper _mapper;

        public GetAllTasksHandler(
            ICollaboratorRepository collaboratorRepository,
            IMapper mapper)
        {
            _collaboratorRepository = collaboratorRepository;
            _mapper = mapper;
        }

        public async Task<List<GetAllTasksResponse>> Handle(GetAllTasksRequest request, CancellationToken cancellationToken)
        {
            var collaborators = await _collaboratorRepository.GetAll(cancellationToken);

            return _mapper.Map<List<GetAllTasksResponse>>(collaborators);
        }
    }
}
