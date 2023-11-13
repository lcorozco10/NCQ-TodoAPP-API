using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NCQ.Todo.App.Application.Repositories;
using NCQ.Todo.App.Persistence.Context;
using NCQ.Todo.App.Persistence.Repositories;

namespace NCQ.Todo.App.Persistence
{
    public static class ServiceExtensions
    {
        public static void ConfigurePersistence(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("TodoDB");
            services.AddDbContextPool<DataContext>(opt => opt.UseSqlServer(connectionString));

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ICollaboratorRepository, CollaboratorRepository>();
            services.AddScoped<ITaskRepository, TaskRepository>();
        }
    }
}
