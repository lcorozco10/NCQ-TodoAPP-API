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
                   new Collaborator() { Id = new Guid("f6c25425-c52e-4022-a82f-0241537767aa"), Name = "Luis Orozco" },
                   new Collaborator() { Id = new Guid("0e33f791-6bf2-4657-b8d3-157e0746e8f9"), Name = "Carlos Velasquez" }
                   );
        }
    }
}
