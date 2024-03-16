using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFTest2.Migrations
{
    /// <inheritdoc />
    public partial class OgrenciMdeliEkledim : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ogrenciler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Nu = table.Column<int>(type: "int", nullable: false),
                    SinifId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrenciler", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ogrenciler");
        }
    }
}
