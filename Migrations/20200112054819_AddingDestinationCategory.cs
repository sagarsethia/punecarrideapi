using Microsoft.EntityFrameworkCore.Migrations;

namespace Tours_Travels.Migrations
{
    public partial class AddingDestinationCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Destinations",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Destinations");
        }
    }
}
