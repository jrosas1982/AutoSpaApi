using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoSpaApi.Migrations
{
    public partial class usuarios_y_perfiles_correccion_unoAuno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_perfiles_Usuarios_Usuarioid1",
                table: "perfiles");

            migrationBuilder.DropIndex(
                name: "IX_perfiles_Usuarioid1",
                table: "perfiles");

            migrationBuilder.DropColumn(
                name: "Perfilid",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Usuarioid1",
                table: "perfiles");

            migrationBuilder.CreateIndex(
                name: "IX_perfiles_Usuarioid",
                table: "perfiles",
                column: "Usuarioid",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_perfiles_Usuarios_Usuarioid",
                table: "perfiles",
                column: "Usuarioid",
                principalTable: "Usuarios",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_perfiles_Usuarios_Usuarioid",
                table: "perfiles");

            migrationBuilder.DropIndex(
                name: "IX_perfiles_Usuarioid",
                table: "perfiles");

            migrationBuilder.AddColumn<int>(
                name: "Perfilid",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Usuarioid1",
                table: "perfiles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_perfiles_Usuarioid1",
                table: "perfiles",
                column: "Usuarioid1");

            migrationBuilder.AddForeignKey(
                name: "FK_perfiles_Usuarios_Usuarioid1",
                table: "perfiles",
                column: "Usuarioid1",
                principalTable: "Usuarios",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
