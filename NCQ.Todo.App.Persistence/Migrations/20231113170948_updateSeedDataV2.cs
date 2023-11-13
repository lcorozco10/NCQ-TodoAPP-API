using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NCQ.Todo.App.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class updateSeedDataV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("a0b0c806-d454-482f-9bf3-4f2d958d212b"),
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "CollaboratorId", "DateCreated", "DateDeleted", "DateUpdated", "Description", "EndDate", "PripriorityCode", "StartDate", "Status" },
                values: new object[,]
                {
                    { new Guid("24e34a73-9485-485f-80c4-71cd393a96f7"), new Guid("0e33f791-6bf2-4657-b8d3-157e0746e8f9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, "Create database diagram", new DateTime(2023, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { new Guid("295d9a48-3dc3-4161-9154-6b319d99a16e"), new Guid("71232824-0b3c-47be-b027-c1fb5b38da65"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, "Create first sprint on Jira", new DateTime(2023, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { new Guid("49ab83dc-f5a5-4c28-98c1-ac03f20e9796"), new Guid("0e33f791-6bf2-4657-b8d3-157e0746e8f9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, "Read project spesifications", new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { new Guid("91652b59-705c-4e93-9fae-116a48ba3b7a"), new Guid("42f9161f-5dcb-4c9f-b926-3fcd54a3a2b6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, "Set up Net core web API", new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 }
                });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "Id", "Content", "DateCreated", "DateDeleted", "DateUpdated", "TaskId" },
                values: new object[] { new Guid("42088927-ec5d-43ab-9cc3-104ada060aee"), "Question and answer customer", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, new Guid("49ab83dc-f5a5-4c28-98c1-ac03f20e9796") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: new Guid("42088927-ec5d-43ab-9cc3-104ada060aee"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("24e34a73-9485-485f-80c4-71cd393a96f7"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("295d9a48-3dc3-4161-9154-6b319d99a16e"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("91652b59-705c-4e93-9fae-116a48ba3b7a"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("49ab83dc-f5a5-4c28-98c1-ac03f20e9796"));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("a0b0c806-d454-482f-9bf3-4f2d958d212b"),
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
