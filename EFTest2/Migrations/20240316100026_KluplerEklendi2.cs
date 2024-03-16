using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFTest2.Migrations
{
    /// <inheritdoc />
    public partial class KluplerEklendi2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KlupOgrenci_Klup_KluplerId",
                table: "KlupOgrenci");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Klup",
                table: "Klup");

            migrationBuilder.RenameTable(
                name: "Klup",
                newName: "Klupler");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Klupler",
                table: "Klupler",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_KlupOgrenci_Klupler_KluplerId",
                table: "KlupOgrenci",
                column: "KluplerId",
                principalTable: "Klupler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KlupOgrenci_Klupler_KluplerId",
                table: "KlupOgrenci");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Klupler",
                table: "Klupler");

            migrationBuilder.RenameTable(
                name: "Klupler",
                newName: "Klup");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Klup",
                table: "Klup",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_KlupOgrenci_Klup_KluplerId",
                table: "KlupOgrenci",
                column: "KluplerId",
                principalTable: "Klup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
