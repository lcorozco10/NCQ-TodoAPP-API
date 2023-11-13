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
                   new Collaborator() { Id = new Guid("0e33f791-6bf2-4657-b8d3-157e0746e8f9"), Name = "Carlos Velasquez" },
                   new Collaborator() { Id = new Guid("745650e1-6872-48fa-8d6a-c581c16a43df"), Name = "Juan Perez" },
                   new Collaborator() { Id = new Guid("71232824-0b3c-47be-b027-c1fb5b38da65"), Name = "Daniel Rodriguez" },
                   new Collaborator() { Id = new Guid("42f9161f-5dcb-4c9f-b926-3fcd54a3a2b6"), Name = "Emily Thompson" },
                   new Collaborator() { Id = new Guid("c30b3991-a2c9-4528-b3cb-c0e342223340"), Name = "Isabella Baker" },
                   new Collaborator() { Id = new Guid("98497980-fcf6-4c5d-8c15-1ec350f0bb8f"), Name = "Alice Johnson" },
                   new Collaborator() { Id = new Guid("06b23a7e-6d78-4c47-9d85-1ead1681e717"), Name = "Benjamin Mitchell" },
                   new Collaborator() { Id = new Guid("fc6f6891-c621-489a-87de-e32dae6f47cc"), Name = "Henry Clark" },
                   new Collaborator() { Id = new Guid("22c3fb20-8f72-4d32-b84a-f0464d58e3b4"), Name = "Alberto Ruiz" }
            );

            modelBuilder.Entity<Domain.Entities.Task>().HasData(
                new Domain.Entities.Task()
                {
                    Description = "Create login mockup",
                    Id = new Guid("a0b0c806-d454-482f-9bf3-4f2d958d212b"),
                    Status = Domain.Entities.TaskStatus.InProgress,
                    PripriorityCode = TaskPripriority.Medium,
                    StartDate = new DateTime(2023, 10, 8),
                    EndDate = new DateTime(2023, 11, 27),
                    CollaboratorId = new Guid("f6c25425-c52e-4022-a82f-0241537767aa"),
                    Notes = "Validate open source mockup tools app"
                },
                new Domain.Entities.Task()
                {
                    Description = "Create database diagram",
                    Id = new Guid("24e34a73-9485-485f-80c4-71cd393a96f7"),
                    Status = Domain.Entities.TaskStatus.Pending,
                    PripriorityCode = TaskPripriority.Low,
                    StartDate = new DateTime(2023, 11, 5),
                    EndDate = new DateTime(2023, 11, 25),
                    CollaboratorId = new Guid("0e33f791-6bf2-4657-b8d3-157e0746e8f9"),
                    Notes = "Create mockup login page style"
                },
                new Domain.Entities.Task()
                {
                    Description = "Read project spesifications",
                    Id = new Guid("49ab83dc-f5a5-4c28-98c1-ac03f20e9796"),
                    Status = Domain.Entities.TaskStatus.Completed,
                    PripriorityCode = TaskPripriority.Medium,
                    StartDate = new DateTime(2023, 10, 18),
                    EndDate = new DateTime(2023, 11, 5),
                    CollaboratorId = new Guid("0e33f791-6bf2-4657-b8d3-157e0746e8f9"),
                    Notes = "Question and answer customer"
                },
                new Domain.Entities.Task()
                {
                    Description = "Create first sprint on Jira",
                    Id = new Guid("295d9a48-3dc3-4161-9154-6b319d99a16e"),
                    Status = Domain.Entities.TaskStatus.InProgress,
                    PripriorityCode = TaskPripriority.High,
                    StartDate = new DateTime(2023, 11, 13),
                    EndDate = new DateTime(2023, 11, 18),
                    CollaboratorId = new Guid("71232824-0b3c-47be-b027-c1fb5b38da65"),
                    Notes = ""
                },
                new Domain.Entities.Task()
                {
                    Description = "Set up Net core web API",
                    Id = new Guid("91652b59-705c-4e93-9fae-116a48ba3b7a"),
                    Status = Domain.Entities.TaskStatus.Pending,
                    PripriorityCode = TaskPripriority.Medium,
                    StartDate = new DateTime(2023, 11, 9),
                    EndDate = new DateTime(2023, 11, 11),
                    CollaboratorId = new Guid("42f9161f-5dcb-4c9f-b926-3fcd54a3a2b6"),
                    Notes = ""
                }
            );
        }
    }
}
