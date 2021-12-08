using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KitapKatalog.Migrations
{
    public partial class baslangic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AdminId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullanıcıAdi = table.Column<string>(maxLength: 30, nullable: true),
                    Sifre = table.Column<string>(maxLength: 30, nullable: true),
                    Yetki = table.Column<string>(maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AdminId);
                });

            migrationBuilder.CreateTable(
                name: "KitapListes",
                columns: table => new
                {
                    ListeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KitapAdet = table.Column<int>(nullable: false),
                    Tarih = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KitapListes", x => x.ListeId);
                });

            migrationBuilder.CreateTable(
                name: "Turs",
                columns: table => new
                {
                    TurId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TurAd = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turs", x => x.TurId);
                });

            migrationBuilder.CreateTable(
                name: "Yazars",
                columns: table => new
                {
                    YazarId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YazarAd = table.Column<string>(maxLength: 20, nullable: true),
                    YazarSoyad = table.Column<string>(maxLength: 20, nullable: true),
                    YazarGorsel = table.Column<string>(maxLength: 250, nullable: true),
                    KitapListeListeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yazars", x => x.YazarId);
                    table.ForeignKey(
                        name: "FK_Yazars_KitapListes_KitapListeListeId",
                        column: x => x.KitapListeListeId,
                        principalTable: "KitapListes",
                        principalColumn: "ListeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Kitaps",
                columns: table => new
                {
                    KitapId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KitapAdi = table.Column<int>(maxLength: 40, nullable: false),
                    KitapGorsel = table.Column<string>(maxLength: 250, nullable: true),
                    KitapPuan = table.Column<int>(nullable: false),
                    YazarId = table.Column<int>(nullable: false),
                    TurId = table.Column<int>(nullable: false),
                    KitapListeListeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kitaps", x => x.KitapId);
                    table.ForeignKey(
                        name: "FK_Kitaps_KitapListes_KitapListeListeId",
                        column: x => x.KitapListeListeId,
                        principalTable: "KitapListes",
                        principalColumn: "ListeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Kitaps_Turs_TurId",
                        column: x => x.TurId,
                        principalTable: "Turs",
                        principalColumn: "TurId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kitaps_Yazars_YazarId",
                        column: x => x.YazarId,
                        principalTable: "Yazars",
                        principalColumn: "YazarId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kitaps_KitapListeListeId",
                table: "Kitaps",
                column: "KitapListeListeId");

            migrationBuilder.CreateIndex(
                name: "IX_Kitaps_TurId",
                table: "Kitaps",
                column: "TurId");

            migrationBuilder.CreateIndex(
                name: "IX_Kitaps_YazarId",
                table: "Kitaps",
                column: "YazarId");

            migrationBuilder.CreateIndex(
                name: "IX_Yazars_KitapListeListeId",
                table: "Yazars",
                column: "KitapListeListeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Kitaps");

            migrationBuilder.DropTable(
                name: "Turs");

            migrationBuilder.DropTable(
                name: "Yazars");

            migrationBuilder.DropTable(
                name: "KitapListes");
        }
    }
}
