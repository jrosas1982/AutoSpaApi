using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoSpaApi.Migrations
{
    public partial class EncuestaPorUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Encuesta",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipo_encuesta = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Encuesta", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "EncuestaPorUsuario",
                columns: table => new
                {
                    Encuestaid = table.Column<int>(nullable: false),
                    Usuarioid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EncuestaPorUsuario", x => new { x.Encuestaid, x.Usuarioid });
                    table.ForeignKey(
                        name: "FK_EncuestaPorUsuario_Encuesta_Encuestaid",
                        column: x => x.Encuestaid,
                        principalTable: "Encuesta",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EncuestaPorUsuario_Usuarios_Usuarioid",
                        column: x => x.Usuarioid,
                        principalTable: "Usuarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EncuestaPorUsuario_Usuarioid",
                table: "EncuestaPorUsuario",
                column: "Usuarioid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EncuestaPorUsuario");

            migrationBuilder.DropTable(
                name: "Encuesta");
        }
    }
}
