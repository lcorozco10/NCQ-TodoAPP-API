using MediatR;
using Microsoft.AspNetCore.Mvc;
using NCQ.Todo.App.Api.Models;
using NCQ.Todo.App.Application.Features.TaskFeature.CreateTask;
using NCQ.Todo.App.Application.Features.TaskFeature.DeleteTask;
using NCQ.Todo.App.Application.Features.TaskFeature.GetAllTasks;
using NCQ.Todo.App.Application.Features.TaskFeature.UpdateTask;
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
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpGet]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(OkResultData<List<GetAllTasksResponse>>))]
        public async Task<IActionResult> GetAll([FromQuery] GetAllTasksRequest request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
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

        /// <summary>
        /// Update a task record
        /// </summary>
        /// <param name="requestBody"></param>
        /// <param name="cancellationToken"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(OkResultData<UpdateTaskResponse>))]
        public async Task<IActionResult> Edit([FromRoute] Guid id, [FromBody] UpdateTaskRequestDto requestBody, CancellationToken cancellationToken)
        {
            var request = new UpdateTaskRequest
            {
                Id = id,
                Description = requestBody.Description,
                Status = requestBody.Status,
                PripriorityCode = requestBody.PripriorityCode,
                CollaboratorId = requestBody.CollaboratorId,
                StartDate = requestBody.StartDate,
                EndDate = requestBody.EndDate,
                Notes = requestBody.Notes
            };
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        /// <summary>
        /// Delete a task record
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(OkResultData<UpdateTaskResponse>))]
        public async Task<IActionResult> Delete([FromRoute] Guid id, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new DeleteTaskRequest { Id = id }, cancellationToken);
            return Ok(response);
        }
    }
}
