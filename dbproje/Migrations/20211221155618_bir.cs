using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dbproje.Migrations
{
    public partial class bir : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Arabalar",
                columns: table => new
                {
                    ArabaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MarkaAdı = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KasaTipi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VitesTipi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModelYılı = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arabalar", x => x.ArabaID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Arabalar");
        }
    }
}
