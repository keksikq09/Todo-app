using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TodoApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class removeDescriptionFromTaskAndAddBasicTasks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "TodoTasks");

            migrationBuilder.InsertData(
                table: "TodoTasks",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Call Mom" },
                    { 2, "Do HomeWork" },
                    { 3, "Learn c#" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TodoTasks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TodoTasks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TodoTasks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "TodoTasks",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
