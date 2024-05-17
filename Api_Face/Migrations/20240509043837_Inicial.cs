using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api_Face.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PERSONAS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cui = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nombres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    clave = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    image_64 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PERSONAS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ROSTROS",
                columns: table => new
                {
                    request_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    time_used = table.Column<int>(type: "int", nullable: false),
                    image_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    face_num = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PERSONAS");

            migrationBuilder.DropTable(
                name: "ROSTROS");
        }
    }
}
