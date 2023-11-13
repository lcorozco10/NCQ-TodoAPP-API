using AutoMapper;
using MediatR;
using NCQ.Todo.App.Application.Repositories;

namespace NCQ.Todo.App.Application.Features.CollaboratorFeature.GetAllCollaborators
{
    public sealed class GetAllCollaboratorsHandler : IRequestHandler<GetAllCollaboratorsRequest, List<GetAllCollaboratorsResponse>>
    {
        private readonly ICollaboratorRepository _collaboratorRepository;
        private readonly IMapper _mapper;

        public GetAllCollaboratorsHandler(
            ICollaboratorRepository collaboratorRepository,
            IMapper mapper)
        {
            _collaboratorRepository = collaboratorRepository;
            _mapper = mapper;
        }

        public async Task<List<GetAllCollaboratorsResponse>> Handle(GetAllCollaboratorsRequest request, CancellationToken cancellationToken)
        {
            var collaborators = await _collaboratorRepository.GetAll(cancellationToken);

            return _mapper.Map<List<GetAllCollaboratorsResponse>>(collaborators);
        }
    }
}
