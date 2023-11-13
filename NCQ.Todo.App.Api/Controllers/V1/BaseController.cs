using Microsoft.AspNetCore.Mvc;
using NCQ.Todo.App.Api.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace NCQ.Todo.App.Api.Controllers.V1
{

    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [Consumes("application/json")]
    [Produces("application/json")]
    [SwaggerResponse(StatusCodes.Status400BadRequest, type: typeof(ErrorDetailValidation))]
    [SwaggerResponse(StatusCodes.Status500InternalServerError, type: typeof(ErrorDetails))]
    public class BaseController : ControllerBase
    {
        new protected IActionResult Ok(object? data)
        {
            return new OkObjectResult(new OkResultData<object>
            {
                Data = data,
                StatusCode = 200
            });
        }
    }
}
