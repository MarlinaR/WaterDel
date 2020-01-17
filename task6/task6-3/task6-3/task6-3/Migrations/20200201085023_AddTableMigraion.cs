using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace task6_3.Migrations
{
    public partial class AddTableMigraion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
            name: "NewTable",  // название таблицы
            columns: table => new    // столбцы
            {
                Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                Name = table.Column<string>(nullable: true)
            }, 
            constraints: table =>
            {
                table.PrimaryKey("PK_NewTable", x => x.Id);
            });


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropTable(
                name: "NewTable");
        }
    }
}
