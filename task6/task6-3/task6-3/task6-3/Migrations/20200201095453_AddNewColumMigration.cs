using Microsoft.EntityFrameworkCore.Migrations;

namespace task6_3.Migrations
{
    public partial class AddNewColumMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "Books",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Count",
                table: "Phones");

        }
    }
}
