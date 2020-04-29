using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoSpaApi.Migrations
{
    public partial class usuarios_y_perfiles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Perfilid",
                table: "Usuarios",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Usuarios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "pass",
                table: "Usuarios",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "perfiles",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titular_tarjeta = table.Column<string>(nullable: true),
                    num_tarjeta = table.Column<string>(nullable: true),
                    datos_vehiculos = table.Column<string>(nullable: true),
                    Usuarioid1 = table.Column<int>(nullable: true),
                    Usuarioid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_perfiles", x => x.id);
                    table.ForeignKey(
                        name: "FK_perfiles_Usuarios_Usuarioid1",
                        column: x => x.Usuarioid1,
                        principalTable: "Usuarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_perfiles_Usuarioid1",
                table: "perfiles",
                column: "Usuarioid1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "perfiles");

            migrationBuilder.DropColumn(
                name: "Perfilid",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "email",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "pass",
                table: "Usuarios");
        }
    }
}
