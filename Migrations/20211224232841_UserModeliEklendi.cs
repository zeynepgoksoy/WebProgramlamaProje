using Microsoft.EntityFrameworkCore.Migrations;

namespace KitapKatalog.Migrations
{
    public partial class UserModeliEklendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kitaps_KitapListes_KitapListeListeId",
                table: "Kitaps");

            migrationBuilder.DropIndex(
                name: "IX_Kitaps_KitapListeListeId",
                table: "Kitaps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KitapListes",
                table: "KitapListes");

            migrationBuilder.DropColumn(
                name: "KitapListeListeId",
                table: "Kitaps");

            migrationBuilder.DropColumn(
                name: "ListeId",
                table: "KitapListes");

            migrationBuilder.DropColumn(
                name: "KullanıcıAdi",
                table: "Admins");

            migrationBuilder.AddColumn<int>(
                name: "KitapListeId",
                table: "Kitaps",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KitapListeId",
                table: "KitapListes",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "KitapListes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "KullaniciAdi",
                table: "Admins",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_KitapListes",
                table: "KitapListes",
                column: "KitapListeId");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserAd = table.Column<string>(maxLength: 30, nullable: false),
                    UserSoyad = table.Column<string>(maxLength: 30, nullable: false),
                    UserMail = table.Column<string>(maxLength: 50, nullable: true),
                    Sifre = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kitaps_KitapListeId",
                table: "Kitaps",
                column: "KitapListeId");

            migrationBuilder.CreateIndex(
                name: "IX_KitapListes_UserId",
                table: "KitapListes",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_KitapListes_Users_UserId",
                table: "KitapListes",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kitaps_KitapListes_KitapListeId",
                table: "Kitaps",
                column: "KitapListeId",
                principalTable: "KitapListes",
                principalColumn: "KitapListeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KitapListes_Users_UserId",
                table: "KitapListes");

            migrationBuilder.DropForeignKey(
                name: "FK_Kitaps_KitapListes_KitapListeId",
                table: "Kitaps");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Kitaps_KitapListeId",
                table: "Kitaps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KitapListes",
                table: "KitapListes");

            migrationBuilder.DropIndex(
                name: "IX_KitapListes_UserId",
                table: "KitapListes");

            migrationBuilder.DropColumn(
                name: "KitapListeId",
                table: "Kitaps");

            migrationBuilder.DropColumn(
                name: "KitapListeId",
                table: "KitapListes");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "KitapListes");

            migrationBuilder.DropColumn(
                name: "KullaniciAdi",
                table: "Admins");

            migrationBuilder.AddColumn<int>(
                name: "KitapListeListeId",
                table: "Kitaps",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ListeId",
                table: "KitapListes",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "KullanıcıAdi",
                table: "Admins",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_KitapListes",
                table: "KitapListes",
                column: "ListeId");

            migrationBuilder.CreateIndex(
                name: "IX_Kitaps_KitapListeListeId",
                table: "Kitaps",
                column: "KitapListeListeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kitaps_KitapListes_KitapListeListeId",
                table: "Kitaps",
                column: "KitapListeListeId",
                principalTable: "KitapListes",
                principalColumn: "ListeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
