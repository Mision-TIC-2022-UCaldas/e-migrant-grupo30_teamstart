using Microsoft.EntityFrameworkCore.Migrations;

namespace Emigrant.App.Persistencia.Migrations
{
    public partial class Migracioninicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tipodocumento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    numeroidentificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    paisorigen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fechanacimiento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    direccionactual = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    situacionlaboral = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}
