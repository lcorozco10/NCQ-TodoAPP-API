using Amazon.CognitoIdentityProvider;
using Amazon.CognitoIdentityProvider.Model;
using Amazon.Extensions.CognitoAuthentication;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NCQ.Todo.App.Api.Models;
using NCQ.Todo.App.Application.Features.CollaboratorFeature.GetAllCollaborators;
using Swashbuckle.AspNetCore.Annotations;

namespace NCQ.Todo.App.Api.Controllers.V1
{
    [ApiVersion("1.0")]
    [Authorize(Policy = "NCQ1")]
    public class CollaboratorController : BaseController
    {
        private readonly IMediator _mediator;
        private readonly IAmazonCognitoIdentityProvider _cognitoService;
        private readonly CognitoUserPool _cognitoUserPool;

        /*private readonly AmazonCognitoIdentityProviderClient adminAmazonCognitoIdentityProviderClient;
        private readonly AmazonCognitoIdentityProviderClient anonymousAmazonCognitoIdentityProviderClient;*/
        //private readonly AWSCredentials awsCredentials;



        public CollaboratorController(IMediator mediator, IAmazonCognitoIdentityProvider cognitoService, CognitoUserPool cognitoUserPool)
        {
            _mediator = mediator;
            _cognitoService = cognitoService;
            _cognitoUserPool = cognitoUserPool;
        }

        /// <summary>
        /// Get all collaborators
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>        
        [HttpGet]
        [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(OkResultData<List<GetAllCollaboratorsResponse>>))]
        public async Task<IActionResult> GetAllLincecia(CancellationToken cancellationToken)
        {
            var x = User;
            var y = _cognitoUserPool.GetUser("c16be550-7021-701a-8eac-ef254f8a327d");

            var request = new ListUsersRequest
            {
                UserPoolId = "us-east-2_9vCkq5idW"
            };

            var users = new List<UserType>();

            //_cognitoService.AdminCreateUserAsync()
            var usersPaginator = _cognitoService.Paginators.ListUsers(request);
            await foreach (var response in usersPaginator.Responses)
            {
                users.AddRange(response.Users);
            }

            return Ok(users);
            //var response = "test";
            //var response = await _mediator.Send(new GetAllCollaboratorsRequest(), cancellationToken);
            //return Ok(response);
        }
    }
}