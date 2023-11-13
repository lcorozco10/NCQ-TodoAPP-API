using Microsoft.EntityFrameworkCore;
using NCQ.Todo.App.Domain.Entities;
using NCQ.Todo.App.Persistence.ModelConfiguration;
using NCQ.Todo.App.Persistence.Seeding;
using Task = NCQ.Todo.App.Domain.Entities.Task;

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

            modelBuilder.Entity<Collaborator>()
            .HasMany(e => e.Tasks)
            .WithOne(e => e.Collaborator)
            .HasForeignKey(e => e.CollaboratorId)
            .IsRequired(false);

            modelBuilder.ApplyConfiguration(new CollaboratorConfiguration());
            new DbInitializer(modelBuilder).Seed();
        }

        public DbSet<Collaborator> Collaborators { get; set; }
        public DbSet<Task> Tasks { get; set; }
    }
}
