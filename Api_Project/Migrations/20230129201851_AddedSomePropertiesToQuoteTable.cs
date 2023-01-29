using Microsoft.EntityFrameworkCore.Migrations;

namespace Api_Project.Migrations
{
    public partial class AddedSomePropertiesToQuoteTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "Quotes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Quotes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Quotes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Author",
                table: "Quotes");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Quotes");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Quotes");
        }
    }
}
