using MediatR;
using Microsoft.AspNetCore.Mvc;
using NCQ.Todo.App.Api.Models;
using NCQ.Todo.App.Application.Features.UserFeature.GetAllUsers;
using Swashbuckle.AspNetCore.Annotations;

namespace NCQ.Todo.App.Api.Controllers.V1
{
    [ApiVersion("1.0")]
    public class UserController : BaseController
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Test endpoint
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpGet]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(OkResultData<List<GetAllUsersResponse>>))]
        public async Task<ActionResult<List<GetAllUsersResponse>>> GetAll([FromQuery] GetAllUsersRequest request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }
    }
}