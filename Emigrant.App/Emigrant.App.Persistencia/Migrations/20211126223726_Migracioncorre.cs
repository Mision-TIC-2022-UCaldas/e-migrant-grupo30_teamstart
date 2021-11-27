using Microsoft.EntityFrameworkCore.Migrations;

namespace Emigrant.App.Persistencia.Migrations
{
    public partial class Migracioncorre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "pais_oigen",
                table: "Personas");

            migrationBuilder.RenameColumn(
                name: "situacion_laboral",
                table: "Personas",
                newName: "pais_origen");

            migrationBuilder.AddColumn<string>(
                name: "situacion_laboral",
                table: "Migrantes",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "situacion_laboral",
                table: "Migrantes");

            migrationBuilder.RenameColumn(
                name: "pais_origen",
                table: "Personas",
                newName: "situacion_laboral");

            migrationBuilder.AddColumn<string>(
                name: "pais_oigen",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
