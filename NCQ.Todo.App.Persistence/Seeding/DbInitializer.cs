using Microsoft.EntityFrameworkCore;
using NCQ.Todo.App.Domain.Entities;

namespace NCQ.Todo.App.Persistence.Seeding
{
    public class DbInitializer
    {
        private readonly ModelBuilder modelBuilder;

        public DbInitializer(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }

        public void Seed()
        {
            modelBuilder.Entity<Collaborator>().HasData(
                   new Collaborator() { Id = Guid.NewGuid(), Name = "Luis Orozco" },
                   new Collaborator() { Id = Guid.NewGuid(), Name = "Carlos Velasquez" }
                   );
        }
    }
}
