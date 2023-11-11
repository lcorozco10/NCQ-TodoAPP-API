using MediatR;
using Microsoft.AspNetCore.Mvc;
using NCQ.Todo.App.Application.Features.UserFeature.GetAllUsers;

namespace NCQ.Todo.App.Api.Controllers
{
    [ApiController]
    [Route("user")]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<GetAllUsersResponse>>> GetAll(CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GetAllUsersRequest(), cancellationToken);
            return Ok(response);
        }
    }
}