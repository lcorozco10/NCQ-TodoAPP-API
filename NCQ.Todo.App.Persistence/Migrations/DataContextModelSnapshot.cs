﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NCQ.Todo.App.Persistence.Context;

#nullable disable

namespace NCQ.Todo.App.Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NCQ.Todo.App.Domain.Entities.Collaborator", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetimeoffset")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<DateTimeOffset?>("DateDeleted")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DateUpdated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetimeoffset")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Collaborators");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f6c25425-c52e-4022-a82f-0241537767aa"),
                            DateCreated = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Luis Orozco"
                        },
                        new
                        {
                            Id = new Guid("0e33f791-6bf2-4657-b8d3-157e0746e8f9"),
                            DateCreated = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Carlos Velasquez"
                        },
                        new
                        {
                            Id = new Guid("745650e1-6872-48fa-8d6a-c581c16a43df"),
                            DateCreated = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Juan Perez"
                        },
                        new
                        {
                            Id = new Guid("71232824-0b3c-47be-b027-c1fb5b38da65"),
                            DateCreated = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Daniel Rodriguez"
                        },
                        new
                        {
                            Id = new Guid("42f9161f-5dcb-4c9f-b926-3fcd54a3a2b6"),
                            DateCreated = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Emily Thompson"
                        },
                        new
                        {
                            Id = new Guid("c30b3991-a2c9-4528-b3cb-c0e342223340"),
                            DateCreated = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Isabella Baker"
                        },
                        new
                        {
                            Id = new Guid("98497980-fcf6-4c5d-8c15-1ec350f0bb8f"),
                            DateCreated = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Alice Johnson"
                        },
                        new
                        {
                            Id = new Guid("06b23a7e-6d78-4c47-9d85-1ead1681e717"),
                            DateCreated = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Benjamin Mitchell"
                        },
                        new
                        {
                            Id = new Guid("fc6f6891-c621-489a-87de-e32dae6f47cc"),
                            DateCreated = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Henry Clark"
                        },
                        new
                        {
                            Id = new Guid("22c3fb20-8f72-4d32-b84a-f0464d58e3b4"),
                            DateCreated = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Alberto Ruiz"
                        });
                });

            modelBuilder.Entity("NCQ.Todo.App.Domain.Entities.Task", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CollaboratorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("DateCreated")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DateDeleted")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DateUpdated")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PripriorityCode")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CollaboratorId");

                    b.ToTable("Tasks");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a0b0c806-d454-482f-9bf3-4f2d958d212b"),
                            CollaboratorId = new Guid("f6c25425-c52e-4022-a82f-0241537767aa"),
                            DateCreated = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "Create login mockup",
                            EndDate = new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Notes = "Validate open source mockup tools app",
                            PripriorityCode = 1,
                            StartDate = new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1
                        },
                        new
                        {
                            Id = new Guid("24e34a73-9485-485f-80c4-71cd393a96f7"),
                            CollaboratorId = new Guid("0e33f791-6bf2-4657-b8d3-157e0746e8f9"),
                            DateCreated = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "Create database diagram",
                            EndDate = new DateTime(2023, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Notes = "Create mockup login page style",
                            PripriorityCode = 2,
                            StartDate = new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 0
                        },
                        new
                        {
                            Id = new Guid("49ab83dc-f5a5-4c28-98c1-ac03f20e9796"),
                            CollaboratorId = new Guid("0e33f791-6bf2-4657-b8d3-157e0746e8f9"),
                            DateCreated = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "Read project spesifications",
                            EndDate = new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Notes = "Question and answer customer",
                            PripriorityCode = 1,
                            StartDate = new DateTime(2023, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 2
                        },
                        new
                        {
                            Id = new Guid("295d9a48-3dc3-4161-9154-6b319d99a16e"),
                            CollaboratorId = new Guid("71232824-0b3c-47be-b027-c1fb5b38da65"),
                            DateCreated = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "Create first sprint on Jira",
                            EndDate = new DateTime(2023, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Notes = "Checkout sprint",
                            PripriorityCode = 0,
                            StartDate = new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1
                        },
                        new
                        {
                            Id = new Guid("91652b59-705c-4e93-9fae-116a48ba3b7a"),
                            CollaboratorId = new Guid("42f9161f-5dcb-4c9f-b926-3fcd54a3a2b6"),
                            DateCreated = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "Set up Net core web API",
                            EndDate = new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Notes = "",
                            PripriorityCode = 1,
                            StartDate = new DateTime(2023, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 0
                        },
                        new
                        {
                            Id = new Guid("a113570f-91c7-41f2-9182-776d36225d2f"),
                            CollaboratorId = new Guid("22c3fb20-8f72-4d32-b84a-f0464d58e3b4"),
                            DateCreated = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "Create readme file documentation",
                            EndDate = new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Notes = "Schedule meeting",
                            PripriorityCode = 1,
                            StartDate = new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1
                        },
                        new
                        {
                            Id = new Guid("4162c0fd-288c-4ff7-8787-09907dc2397e"),
                            CollaboratorId = new Guid("06b23a7e-6d78-4c47-9d85-1ead1681e717"),
                            DateCreated = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "Create angular project",
                            EndDate = new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Notes = "",
                            PripriorityCode = 1,
                            StartDate = new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1
                        },
                        new
                        {
                            Id = new Guid("a2741a94-af29-4776-96db-fcb2ba2d428f"),
                            CollaboratorId = new Guid("c30b3991-a2c9-4528-b3cb-c0e342223340"),
                            DateCreated = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "Validate flowbite as base framework on angular",
                            EndDate = new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Notes = "Validate with the teams",
                            PripriorityCode = 0,
                            StartDate = new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 0
                        },
                        new
                        {
                            Id = new Guid("752be9a9-0571-4852-88f5-27f780d28a0b"),
                            CollaboratorId = new Guid("fc6f6891-c621-489a-87de-e32dae6f47cc"),
                            DateCreated = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "Read tailwind documentation",
                            EndDate = new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Notes = "",
                            PripriorityCode = 0,
                            StartDate = new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 0
                        },
                        new
                        {
                            Id = new Guid("af3df707-1e92-4363-9348-fc8a379d5354"),
                            CollaboratorId = new Guid("98497980-fcf6-4c5d-8c15-1ec350f0bb8f"),
                            DateCreated = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "Deploy Angular app to production",
                            EndDate = new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Notes = "Validate cloud service",
                            PripriorityCode = 0,
                            StartDate = new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 0
                        },
                        new
                        {
                            Id = new Guid("12541a1d-baf4-4ee6-8b2b-3ab76969c32d"),
                            CollaboratorId = new Guid("745650e1-6872-48fa-8d6a-c581c16a43df"),
                            DateCreated = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "Create database Diagram E-R",
                            EndDate = new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Notes = "Schedule meeting",
                            PripriorityCode = 1,
                            StartDate = new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1
                        },
                        new
                        {
                            Id = new Guid("156a6e52-03f8-4c13-a72d-2199503f5ccc"),
                            CollaboratorId = new Guid("42f9161f-5dcb-4c9f-b926-3fcd54a3a2b6"),
                            DateCreated = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "Read Project specification",
                            EndDate = new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Notes = "",
                            PripriorityCode = 1,
                            StartDate = new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1
                        },
                        new
                        {
                            Id = new Guid("704222bc-c05f-4c0d-b114-41a9b4b5d62b"),
                            CollaboratorId = new Guid("0e33f791-6bf2-4657-b8d3-157e0746e8f9"),
                            DateCreated = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "Create edit task endpoint",
                            EndDate = new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Notes = "Validate with the teams",
                            PripriorityCode = 0,
                            StartDate = new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 0
                        },
                        new
                        {
                            Id = new Guid("7c67a113-e7df-4a43-871f-1208b60e216e"),
                            CollaboratorId = new Guid("fc6f6891-c621-489a-87de-e32dae6f47cc"),
                            DateCreated = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "Create delete task endpoint",
                            EndDate = new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Notes = "",
                            PripriorityCode = 0,
                            StartDate = new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 0
                        },
                        new
                        {
                            Id = new Guid("8f31bb68-8cfb-4194-abf2-a9de9624f63b"),
                            CollaboratorId = new Guid("c30b3991-a2c9-4528-b3cb-c0e342223340"),
                            DateCreated = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "Create new task endpoint",
                            EndDate = new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Notes = "",
                            PripriorityCode = 0,
                            StartDate = new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 0
                        });
                });

            modelBuilder.Entity("NCQ.Todo.App.Domain.Entities.Task", b =>
                {
                    b.HasOne("NCQ.Todo.App.Domain.Entities.Collaborator", "Collaborator")
                        .WithMany("Tasks")
                        .HasForeignKey("CollaboratorId");

                    b.Navigation("Collaborator");
                });

            modelBuilder.Entity("NCQ.Todo.App.Domain.Entities.Collaborator", b =>
                {
                    b.Navigation("Tasks");
                });
#pragma warning restore 612, 618
        }
    }
}
