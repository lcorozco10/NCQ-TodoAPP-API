using Microsoft.EntityFrameworkCore;
using NCQ.Todo.App.Domain.Entities;
using NCQ.Todo.App.Persistence.ModelConfiguration;
using NCQ.Todo.App.Persistence.Seeding;

namespace NCQ.Todo.App.Persistence.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CollaboratorConfiguration());
            new DbInitializer(modelBuilder).Seed();
        }

        public DbSet<Collaborator> Collaborators { get; set; }
    }
}
