using AutoMapper;
using MediatR;
using NCQ.Todo.App.Application.Repositories;

namespace NCQ.Todo.App.Application.Features.UserFeature.GetAllUsers
{
    public sealed class GetAllUsersHandler : IRequestHandler<GetAllUsersRequest, GetAllUsersResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public GetAllUsersHandler(IUnitOfWork unitOfWork, IUserRepository userRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<GetAllUsersResponse> Handle(GetAllUsersRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            /*var user = _mapper.Map<User>(request);
            _userRepository.Create(user);
            await _unitOfWork.Save(cancellationToken);

            return _mapper.Map<GetAllUsersResponse>(user);*/
        }
    }
}
