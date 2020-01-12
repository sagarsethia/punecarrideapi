using Microsoft.EntityFrameworkCore.Migrations;

namespace Tours_Travels.Migrations
{
    public partial class ThingstoDoCOlumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ThingsToDo",
                table: "Destinations",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ThingsToDo",
                table: "Destinations");
        }
    }
}
