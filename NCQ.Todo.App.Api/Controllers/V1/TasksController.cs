using MediatR;
using Microsoft.AspNetCore.Mvc;
using NCQ.Todo.App.Api.Models;
using NCQ.Todo.App.Application.Features.TaskFeature.CreateTask;
using NCQ.Todo.App.Application.Features.TaskFeature.GetAllTasks;
using Swashbuckle.AspNetCore.Annotations;

namespace NCQ.Todo.App.Api.Controllers.V1
{
    [ApiVersion("1.0")]
    public class TasksController : BaseController
    {
        private readonly IMediator _mediator;

        public TasksController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Get all tasks
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpGet]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(OkResultData<List<GetAllTasksResponse>>))]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GetAllTasksRequest(), cancellationToken);
            return Ok(response);
        }

        /// <summary>
        /// Create a new task record
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpPost]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(OkResultData<CreateTaskResponse>))]
        public async Task<IActionResult> Create([FromBody] CreateTaskRequest request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }
    }
}
