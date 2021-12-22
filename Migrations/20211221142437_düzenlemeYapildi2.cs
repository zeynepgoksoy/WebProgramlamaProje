using Microsoft.EntityFrameworkCore.Migrations;

namespace KitapKatalog.Migrations
{
    public partial class düzenlemeYapildi2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "YazarOzgecmis",
                table: "Yazars",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KitapTanıtım",
                table: "Kitaps",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "YazarOzgecmis",
                table: "Yazars");

            migrationBuilder.DropColumn(
                name: "KitapTanıtım",
                table: "Kitaps");
        }
    }
}
