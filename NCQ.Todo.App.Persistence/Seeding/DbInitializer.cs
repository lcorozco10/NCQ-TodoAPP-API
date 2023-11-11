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
            modelBuilder.Entity<User>().HasData(
                   new User() { Id = Guid.NewGuid(), Name = "Luis", DateCreated = DateTime.UtcNow },
                   new User() { Id = Guid.NewGuid(), Name = "Orozco", DateCreated = DateTime.UtcNow }
                   );
        }
    }
}
