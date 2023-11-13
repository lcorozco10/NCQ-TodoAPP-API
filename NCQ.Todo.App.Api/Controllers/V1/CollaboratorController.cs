using MediatR;
using Microsoft.AspNetCore.Mvc;
using NCQ.Todo.App.Api.Models;
using NCQ.Todo.App.Application.Features.CollaboratorFeature.GetAllCollaborators;
using Swashbuckle.AspNetCore.Annotations;

namespace NCQ.Todo.App.Api.Controllers.V1
{
    [ApiVersion("1.0")]
    public class CollaboratorController : BaseController
    {
        private readonly IMediator _mediator;

        public CollaboratorController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Get all collaborators
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpGet]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(OkResultData<List<GetAllCollaboratorsResponse>>))]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GetAllCollaboratorsRequest(), cancellationToken);
            return Ok(response);
        }
    }
}