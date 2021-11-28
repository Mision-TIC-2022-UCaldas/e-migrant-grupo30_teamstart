using Microsoft.EntityFrameworkCore.Migrations;

namespace Emigrant.App.Persistencia.Migrations
{
    public partial class MigraEntidad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Entidades",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    razón_social = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ciudad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    direccion_electronica = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pagina_web = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sector = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tipo_servicio = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entidades", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Entidades");
        }
    }
}
