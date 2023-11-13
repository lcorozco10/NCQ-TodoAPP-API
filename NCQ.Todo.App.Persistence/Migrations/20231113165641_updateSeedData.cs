using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NCQ.Todo.App.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class updateSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Collaborators",
                columns: new[] { "Id", "DateDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("06b23a7e-6d78-4c47-9d85-1ead1681e717"), null, "Benjamin Mitchell" },
                    { new Guid("22c3fb20-8f72-4d32-b84a-f0464d58e3b4"), null, "Alberto Ruiz" },
                    { new Guid("42f9161f-5dcb-4c9f-b926-3fcd54a3a2b6"), null, "Emily Thompson" },
                    { new Guid("71232824-0b3c-47be-b027-c1fb5b38da65"), null, "Daniel Rodriguez" },
                    { new Guid("745650e1-6872-48fa-8d6a-c581c16a43df"), null, "Juan Perez" },
                    { new Guid("98497980-fcf6-4c5d-8c15-1ec350f0bb8f"), null, "Alice Johnson" },
                    { new Guid("c30b3991-a2c9-4528-b3cb-c0e342223340"), null, "Isabella Baker" },
                    { new Guid("fc6f6891-c621-489a-87de-e32dae6f47cc"), null, "Henry Clark" }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "CollaboratorId", "DateCreated", "DateDeleted", "DateUpdated", "Description", "EndDate", "PripriorityCode", "StartDate", "Status" },
                values: new object[] { new Guid("a0b0c806-d454-482f-9bf3-4f2d958d212b"), new Guid("f6c25425-c52e-4022-a82f-0241537767aa"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, "Create login mockup", new DateTime(2023, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "Id", "Content", "DateCreated", "DateDeleted", "DateUpdated", "TaskId" },
                values: new object[,]
                {
                    { new Guid("47953270-b6cb-4d75-8168-025885c223db"), "Validate open source mockup tools app", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, new Guid("a0b0c806-d454-482f-9bf3-4f2d958d212b") },
                    { new Guid("fc74ca35-eb14-42b0-bd41-85d14d2ad9b8"), "Create mockup login page style", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, new Guid("a0b0c806-d454-482f-9bf3-4f2d958d212b") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Collaborators",
                keyColumn: "Id",
                keyValue: new Guid("06b23a7e-6d78-4c47-9d85-1ead1681e717"));

            migrationBuilder.DeleteData(
                table: "Collaborators",
                keyColumn: "Id",
                keyValue: new Guid("22c3fb20-8f72-4d32-b84a-f0464d58e3b4"));

            migrationBuilder.DeleteData(
                table: "Collaborators",
                keyColumn: "Id",
                keyValue: new Guid("42f9161f-5dcb-4c9f-b926-3fcd54a3a2b6"));

            migrationBuilder.DeleteData(
                table: "Collaborators",
                keyColumn: "Id",
                keyValue: new Guid("71232824-0b3c-47be-b027-c1fb5b38da65"));

            migrationBuilder.DeleteData(
                table: "Collaborators",
                keyColumn: "Id",
                keyValue: new Guid("745650e1-6872-48fa-8d6a-c581c16a43df"));

            migrationBuilder.DeleteData(
                table: "Collaborators",
                keyColumn: "Id",
                keyValue: new Guid("98497980-fcf6-4c5d-8c15-1ec350f0bb8f"));

            migrationBuilder.DeleteData(
                table: "Collaborators",
                keyColumn: "Id",
                keyValue: new Guid("c30b3991-a2c9-4528-b3cb-c0e342223340"));

            migrationBuilder.DeleteData(
                table: "Collaborators",
                keyColumn: "Id",
                keyValue: new Guid("fc6f6891-c621-489a-87de-e32dae6f47cc"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("47953270-b6cb-4d75-8168-025885c223db"));

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("fc74ca35-eb14-42b0-bd41-85d14d2ad9b8"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("a0b0c806-d454-482f-9bf3-4f2d958d212b"));
        }
    }
}
