using Microsoft.EntityFrameworkCore.Migrations;

namespace KitapKatalog.Migrations
{
    public partial class DüzenlemeYapildi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Yazars_KitapListes_KitapListeListeId",
                table: "Yazars");

            migrationBuilder.DropIndex(
                name: "IX_Yazars_KitapListeListeId",
                table: "Yazars");

            migrationBuilder.DropColumn(
                name: "KitapListeListeId",
                table: "Yazars");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KitapListeListeId",
                table: "Yazars",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Yazars_KitapListeListeId",
                table: "Yazars",
                column: "KitapListeListeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Yazars_KitapListes_KitapListeListeId",
                table: "Yazars",
                column: "KitapListeListeId",
                principalTable: "KitapListes",
                principalColumn: "ListeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
