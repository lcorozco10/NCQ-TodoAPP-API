using Amazon;
using Amazon.CognitoIdentityProvider;
using Amazon.Extensions.CognitoAuthentication;
using Amazon.Runtime;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using NCQ.Todo.App.Api.Common;
using NCQ.Todo.App.Api.Extensions;
using NCQ.Todo.App.Application;
using NCQ.Todo.App.Persistence;
using NCQ.Todo.App.Persistence.Context;
using Newtonsoft.Json;
using System.IdentityModel.Tokens.Jwt;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "NCQ ToDo APP API",
        Description = "NCQ Documentation API",
    });

    // using System.Reflection;
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));

    options.SchemaFilter<EnumTypesSchemaFilter>();
});

builder.Services.ConfigurePersistence(builder.Configuration);
builder.Services.ConfigureApplication();

builder.Services.ConfigureApiBehavior();
builder.Services.ConfigureCorsPolicy();

var amazonCognitoIdentityProvider = new AmazonCognitoIdentityProviderClient(RegionEndpoint.USEast2);
var cognitoUserPool = new CognitoUserPool("us-east-2_9vCkq5idW", "rn7vu5qesihbjb1pfcl9egnr4", amazonCognitoIdentityProvider);

builder.Services.AddSingleton<IAmazonCognitoIdentityProvider>(x => amazonCognitoIdentityProvider);
builder.Services.AddSingleton(x => cognitoUserPool);

//builder.Services.AddCognitoIdentity();

/*List<string> authorizedDomains = new List<string>()
    {
        "NCQ",        
    };

builder.Services
    .AddAuthorization(options =>
    {
        options.AddPolicy("NCQ", policy => policy.RequireClaim("cognito:groups", authorizedDomains));
    });*/


builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            IssuerSigningKeyResolver = (s, securityToken, identifier, parameters) =>
            {
                var data1 = new HttpClient().GetAsync(parameters.ValidIssuer + "/.well-known/jwks.json").Result;
                var jsonString = data1.Content.ReadAsStringAsync().Result;
                var value = JsonConvert.DeserializeObject<JsonWebKeySet>(jsonString);
                return value != null ? (IEnumerable<SecurityKey>)value.Keys : null;
            },

            ValidIssuer = "https://cognito-idp.us-east-2.amazonaws.com/us-east-2_9vCkq5idW",
            ValidateIssuerSigningKey = true,
            ValidateIssuer = true,
            ValidateLifetime = true,
            ValidateAudience = true,
            AudienceValidator = (IEnumerable<string> audiences, SecurityToken securityToken, TokenValidationParameters validationParameters) =>
            {
                var castedToken = securityToken as JwtSecurityToken;
                var clientId = castedToken?.Claims.FirstOrDefault(x => x.Type == "client_id")?.Value;
                // Do Nothing
                return clientId == "6m7hj7g2vpcjh3rll3fc6or55o";
            },

        };
        options.MetadataAddress = "https://cognito-idp.us-east-2.amazonaws.com/us-east-2_9vCkq5idW/.well-known/openid-configuration";
    });


//  Set API Version
builder.Services.AddApiVersioning(opt =>
{
    opt.DefaultApiVersion = new ApiVersion(1, 0);
    opt.AssumeDefaultVersionWhenUnspecified = true;
    opt.ReportApiVersions = true;
    opt.ApiVersionReader = ApiVersionReader.Combine(new UrlSegmentApiVersionReader(),
                                                    new HeaderApiVersionReader("x-api-version"),
                                                    new MediaTypeApiVersionReader("x-api-version"));
});

// Add ApiExplorer to discover versions
builder.Services.AddVersionedApiExplorer(setup =>
{
    setup.GroupNameFormat = "'v'VVV";
    setup.SubstituteApiVersionInUrl = true;
});

var app = builder.Build();

app.UseAuthentication();

var serviceScope = app.Services.CreateScope();
var dataContext = serviceScope.ServiceProvider.GetService<DataContext>();
//dataContext?.Database.EnsureCreated();


var apiVersionDescriptionProvider = app.Services.GetRequiredService<IApiVersionDescriptionProvider>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        foreach (var description in apiVersionDescriptionProvider.ApiVersionDescriptions)
        {
            options.SwaggerEndpoint($"/swagger/{description.GroupName}/swagger.json",
                description.GroupName.ToUpperInvariant());
        }
    });
}

//app.UseErrorHandler();
app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

