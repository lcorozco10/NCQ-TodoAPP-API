using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NCQ.Todo.App.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTastStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StateCode",
                table: "Tasks",
                newName: "Status");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Tasks",
                newName: "StateCode");
        }
    }
}
