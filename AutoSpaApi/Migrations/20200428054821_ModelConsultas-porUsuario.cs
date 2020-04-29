using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoSpaApi.Migrations
{
    public partial class ModelConsultasporUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsuarioSoporteId",
                table: "Consultas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Usuarioid",
                table: "Consultas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Consultas_Usuarioid",
                table: "Consultas",
                column: "Usuarioid");

            migrationBuilder.AddForeignKey(
                name: "FK_Consultas_Usuarios_Usuarioid",
                table: "Consultas",
                column: "Usuarioid",
                principalTable: "Usuarios",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consultas_Usuarios_Usuarioid",
                table: "Consultas");

            migrationBuilder.DropIndex(
                name: "IX_Consultas_Usuarioid",
                table: "Consultas");

            migrationBuilder.DropColumn(
                name: "UsuarioSoporteId",
                table: "Consultas");

            migrationBuilder.DropColumn(
                name: "Usuarioid",
                table: "Consultas");
        }
    }
}
