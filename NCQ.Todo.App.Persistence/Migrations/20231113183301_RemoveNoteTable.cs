using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NCQ.Todo.App.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class RemoveNoteTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notes");

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Tasks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("24e34a73-9485-485f-80c4-71cd393a96f7"),
                column: "Notes",
                value: "Create mockup login page style");

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("295d9a48-3dc3-4161-9154-6b319d99a16e"),
                column: "Notes",
                value: "");

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("49ab83dc-f5a5-4c28-98c1-ac03f20e9796"),
                column: "Notes",
                value: "Question and answer customer");

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("91652b59-705c-4e93-9fae-116a48ba3b7a"),
                column: "Notes",
                value: "");

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("a0b0c806-d454-482f-9bf3-4f2d958d212b"),
                column: "Notes",
                value: "Validate open source mockup tools app");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Tasks");

            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TaskId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DateDeleted = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DateUpdated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notes_Tasks_TaskId",
                        column: x => x.TaskId,
                        principalTable: "Tasks",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "Id", "Content", "DateCreated", "DateDeleted", "DateUpdated", "TaskId" },
                values: new object[,]
                {
                    { new Guid("42088927-ec5d-43ab-9cc3-104ada060aee"), "Question and answer customer", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, new Guid("49ab83dc-f5a5-4c28-98c1-ac03f20e9796") },
                    { new Guid("47953270-b6cb-4d75-8168-025885c223db"), "Validate open source mockup tools app", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, new Guid("a0b0c806-d454-482f-9bf3-4f2d958d212b") },
                    { new Guid("fc74ca35-eb14-42b0-bd41-85d14d2ad9b8"), "Create mockup login page style", new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, new Guid("a0b0c806-d454-482f-9bf3-4f2d958d212b") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Notes_TaskId",
                table: "Notes",
                column: "TaskId");
        }
    }
}
