using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NCQ.Todo.App.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedDataV3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("295d9a48-3dc3-4161-9154-6b319d99a16e"),
                column: "Notes",
                value: "Checkout sprint");

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "CollaboratorId", "DateCreated", "DateDeleted", "DateUpdated", "Description", "EndDate", "Notes", "PripriorityCode", "StartDate", "Status" },
                values: new object[,]
                {
                    { new Guid("12541a1d-baf4-4ee6-8b2b-3ab76969c32d"), new Guid("745650e1-6872-48fa-8d6a-c581c16a43df"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, "Create database Diagram E-R", new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Schedule meeting", 1, new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { new Guid("156a6e52-03f8-4c13-a72d-2199503f5ccc"), new Guid("42f9161f-5dcb-4c9f-b926-3fcd54a3a2b6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, "Read Project specification", new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 1, new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { new Guid("4162c0fd-288c-4ff7-8787-09907dc2397e"), new Guid("06b23a7e-6d78-4c47-9d85-1ead1681e717"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, "Create angular project", new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 1, new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { new Guid("704222bc-c05f-4c0d-b114-41a9b4b5d62b"), new Guid("0e33f791-6bf2-4657-b8d3-157e0746e8f9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, "Create edit task endpoint", new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Validate with the teams", 0, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { new Guid("752be9a9-0571-4852-88f5-27f780d28a0b"), new Guid("fc6f6891-c621-489a-87de-e32dae6f47cc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, "Read tailwind documentation", new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { new Guid("7c67a113-e7df-4a43-871f-1208b60e216e"), new Guid("fc6f6891-c621-489a-87de-e32dae6f47cc"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, "Create delete task endpoint", new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { new Guid("8f31bb68-8cfb-4194-abf2-a9de9624f63b"), new Guid("c30b3991-a2c9-4528-b3cb-c0e342223340"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, "Create new task endpoint", new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0, new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { new Guid("a113570f-91c7-41f2-9182-776d36225d2f"), new Guid("22c3fb20-8f72-4d32-b84a-f0464d58e3b4"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, "Create readme file documentation", new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Schedule meeting", 1, new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { new Guid("a2741a94-af29-4776-96db-fcb2ba2d428f"), new Guid("c30b3991-a2c9-4528-b3cb-c0e342223340"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, "Validate flowbite as base framework on angular", new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Validate with the teams", 0, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { new Guid("af3df707-1e92-4363-9348-fc8a379d5354"), new Guid("98497980-fcf6-4c5d-8c15-1ec350f0bb8f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, "Deploy Angular app to production", new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Validate cloud service", 0, new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("12541a1d-baf4-4ee6-8b2b-3ab76969c32d"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("156a6e52-03f8-4c13-a72d-2199503f5ccc"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("4162c0fd-288c-4ff7-8787-09907dc2397e"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("704222bc-c05f-4c0d-b114-41a9b4b5d62b"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("752be9a9-0571-4852-88f5-27f780d28a0b"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("7c67a113-e7df-4a43-871f-1208b60e216e"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("8f31bb68-8cfb-4194-abf2-a9de9624f63b"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("a113570f-91c7-41f2-9182-776d36225d2f"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("a2741a94-af29-4776-96db-fcb2ba2d428f"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("af3df707-1e92-4363-9348-fc8a379d5354"));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("295d9a48-3dc3-4161-9154-6b319d99a16e"),
                column: "Notes",
                value: "");
        }
    }
}
