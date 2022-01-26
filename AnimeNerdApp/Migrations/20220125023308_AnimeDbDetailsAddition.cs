using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimeNerdApp.Migrations
{
    public partial class AnimeDbDetailsAddition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberOfEpisodes",
                table: "Anime",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfHusbandos",
                table: "Anime",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfEpisodes",
                table: "Anime");

            migrationBuilder.DropColumn(
                name: "NumberOfHusbandos",
                table: "Anime");
        }
    }
}
