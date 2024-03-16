using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFTest2.Migrations
{
    /// <inheritdoc />
    public partial class SinifSeviyeEklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Seviye",
                table: "Siniflar",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Seviye",
                table: "Siniflar");
        }
    }
}
