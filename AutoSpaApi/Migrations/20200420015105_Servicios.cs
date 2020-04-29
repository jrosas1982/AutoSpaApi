using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoSpaApi.Migrations
{
    public partial class Servicios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_perfiles_Usuarios_Usuarioid",
                table: "perfiles");

            migrationBuilder.DropForeignKey(
                name: "FK_roles_Usuarios_Usuarioid",
                table: "roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_roles",
                table: "roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_perfiles",
                table: "perfiles");

            migrationBuilder.RenameTable(
                name: "roles",
                newName: "Roles");

            migrationBuilder.RenameTable(
                name: "perfiles",
                newName: "Perfiles");

            migrationBuilder.RenameIndex(
                name: "IX_roles_Usuarioid",
                table: "Roles",
                newName: "IX_Roles_Usuarioid");

            migrationBuilder.RenameIndex(
                name: "IX_perfiles_Usuarioid",
                table: "Perfiles",
                newName: "IX_Perfiles_Usuarioid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roles",
                table: "Roles",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Perfiles",
                table: "Perfiles",
                column: "id");

            migrationBuilder.CreateTable(
                name: "Servicios",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(nullable: true),
                    precio = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicios", x => x.id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Perfiles_Usuarios_Usuarioid",
                table: "Perfiles",
                column: "Usuarioid",
                principalTable: "Usuarios",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_Usuarios_Usuarioid",
                table: "Roles",
                column: "Usuarioid",
                principalTable: "Usuarios",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Perfiles_Usuarios_Usuarioid",
                table: "Perfiles");

            migrationBuilder.DropForeignKey(
                name: "FK_Roles_Usuarios_Usuarioid",
                table: "Roles");

            migrationBuilder.DropTable(
                name: "Servicios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roles",
                table: "Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Perfiles",
                table: "Perfiles");

            migrationBuilder.RenameTable(
                name: "Roles",
                newName: "roles");

            migrationBuilder.RenameTable(
                name: "Perfiles",
                newName: "perfiles");

            migrationBuilder.RenameIndex(
                name: "IX_Roles_Usuarioid",
                table: "roles",
                newName: "IX_roles_Usuarioid");

            migrationBuilder.RenameIndex(
                name: "IX_Perfiles_Usuarioid",
                table: "perfiles",
                newName: "IX_perfiles_Usuarioid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_roles",
                table: "roles",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_perfiles",
                table: "perfiles",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_perfiles_Usuarios_Usuarioid",
                table: "perfiles",
                column: "Usuarioid",
                principalTable: "Usuarios",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_roles_Usuarios_Usuarioid",
                table: "roles",
                column: "Usuarioid",
                principalTable: "Usuarios",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
