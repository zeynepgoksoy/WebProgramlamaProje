using Microsoft.EntityFrameworkCore.Migrations;

namespace KitapKatalog.Migrations
{
    public partial class DüzenlemeYapildi3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Durum",
                table: "Kitaps",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Durum",
                table: "Kitaps");
        }
    }
}
