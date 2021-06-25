using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryData.Migrations
{
    public partial class CorrectDirector : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "LibraryAssets");

            migrationBuilder.AddColumn<string>(
                name: "Director",
                table: "LibraryAssets",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Director",
                table: "LibraryAssets");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "LibraryAssets",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
