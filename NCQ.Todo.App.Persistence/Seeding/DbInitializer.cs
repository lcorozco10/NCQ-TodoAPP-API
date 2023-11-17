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
                    Notes = "Checkout sprint"
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
                },


                new Domain.Entities.Task()
                {
                    Description = "Create readme file documentation",
                    Id = new Guid("a113570f-91c7-41f2-9182-776d36225d2f"),
                    Status = Domain.Entities.TaskStatus.InProgress,
                    PripriorityCode = TaskPripriority.Medium,
                    StartDate = new DateTime(2023, 11, 19),
                    EndDate = new DateTime(2023, 11, 23),
                    CollaboratorId = new Guid("22c3fb20-8f72-4d32-b84a-f0464d58e3b4"),
                    Notes = "Schedule meeting"
                },
                new Domain.Entities.Task()
                {
                    Description = "Create angular project",
                    Id = new Guid("4162c0fd-288c-4ff7-8787-09907dc2397e"),
                    Status = Domain.Entities.TaskStatus.InProgress,
                    PripriorityCode = TaskPripriority.Medium,
                    StartDate = new DateTime(2023, 11, 19),
                    EndDate = new DateTime(2023, 11, 23),
                    CollaboratorId = new Guid("06b23a7e-6d78-4c47-9d85-1ead1681e717"),
                    Notes = ""
                },
                new Domain.Entities.Task()
                {
                    Description = "Validate flowbite as base framework on angular",
                    Id = new Guid("a2741a94-af29-4776-96db-fcb2ba2d428f"),
                    Status = Domain.Entities.TaskStatus.Pending,
                    PripriorityCode = TaskPripriority.High,
                    StartDate = new DateTime(2023, 12, 5),
                    EndDate = new DateTime(2023, 12, 8),
                    CollaboratorId = new Guid("c30b3991-a2c9-4528-b3cb-c0e342223340"),
                    Notes = "Validate with the teams"
                },
                new Domain.Entities.Task()
                {
                    Description = "Read tailwind documentation",
                    Id = new Guid("752be9a9-0571-4852-88f5-27f780d28a0b"),
                    Status = Domain.Entities.TaskStatus.Pending,
                    PripriorityCode = TaskPripriority.High,
                    StartDate = new DateTime(2023, 12, 11),
                    EndDate = new DateTime(2023, 12, 16),
                    CollaboratorId = new Guid("fc6f6891-c621-489a-87de-e32dae6f47cc"),
                    Notes = ""
                },
                new Domain.Entities.Task()
                {
                    Description = "Deploy Angular app to production",
                    Id = new Guid("af3df707-1e92-4363-9348-fc8a379d5354"),
                    Status = Domain.Entities.TaskStatus.Pending,
                    PripriorityCode = TaskPripriority.High,
                    StartDate = new DateTime(2023, 12, 15),
                    EndDate = new DateTime(2023, 12, 19),
                    CollaboratorId = new Guid("98497980-fcf6-4c5d-8c15-1ec350f0bb8f"),
                    Notes = "Validate cloud service"
                },



                new Domain.Entities.Task()
                {
                    Description = "Create database Diagram E-R",
                    Id = new Guid("12541a1d-baf4-4ee6-8b2b-3ab76969c32d"),
                    Status = Domain.Entities.TaskStatus.InProgress,
                    PripriorityCode = TaskPripriority.Medium,
                    StartDate = new DateTime(2023, 11, 19),
                    EndDate = new DateTime(2023, 11, 23),
                    CollaboratorId = new Guid("745650e1-6872-48fa-8d6a-c581c16a43df"),
                    Notes = "Schedule meeting"
                },
                new Domain.Entities.Task()
                {
                    Description = "Read Project specification",
                    Id = new Guid("156a6e52-03f8-4c13-a72d-2199503f5ccc"),
                    Status = Domain.Entities.TaskStatus.InProgress,
                    PripriorityCode = TaskPripriority.Medium,
                    StartDate = new DateTime(2023, 11, 19),
                    EndDate = new DateTime(2023, 11, 23),
                    CollaboratorId = new Guid("42f9161f-5dcb-4c9f-b926-3fcd54a3a2b6"),
                    Notes = ""
                },
                new Domain.Entities.Task()
                {
                    Description = "Create edit task endpoint",
                    Id = new Guid("704222bc-c05f-4c0d-b114-41a9b4b5d62b"),
                    Status = Domain.Entities.TaskStatus.Pending,
                    PripriorityCode = TaskPripriority.High,
                    StartDate = new DateTime(2023, 12, 5),
                    EndDate = new DateTime(2023, 12, 8),
                    CollaboratorId = new Guid("0e33f791-6bf2-4657-b8d3-157e0746e8f9"),
                    Notes = "Validate with the teams"
                },
                new Domain.Entities.Task()
                {
                    Description = "Create delete task endpoint",
                    Id = new Guid("7c67a113-e7df-4a43-871f-1208b60e216e"),
                    Status = Domain.Entities.TaskStatus.Pending,
                    PripriorityCode = TaskPripriority.High,
                    StartDate = new DateTime(2023, 12, 11),
                    EndDate = new DateTime(2023, 12, 16),
                    CollaboratorId = new Guid("fc6f6891-c621-489a-87de-e32dae6f47cc"),
                    Notes = ""
                },
                new Domain.Entities.Task()
                {
                    Description = "Create new task endpoint",
                    Id = new Guid("8f31bb68-8cfb-4194-abf2-a9de9624f63b"),
                    Status = Domain.Entities.TaskStatus.Pending,
                    PripriorityCode = TaskPripriority.High,
                    StartDate = new DateTime(2023, 12, 15),
                    EndDate = new DateTime(2023, 12, 19),
                    CollaboratorId = new Guid("c30b3991-a2c9-4528-b3cb-c0e342223340"),
                    Notes = ""
                }
            );
        }
    }
}
