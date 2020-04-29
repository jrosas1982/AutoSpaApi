using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoSpaApi.Migrations
{
    public partial class DetalleReservaServicios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DetallesReserva",
                columns: table => new
                {
                    Reservaid = table.Column<int>(nullable: false),
                    Servicioid = table.Column<int>(nullable: false),
                    precioServicio = table.Column<decimal>(nullable: false),
                    turno = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesReserva", x => new { x.Servicioid, x.Reservaid });
                    table.ForeignKey(
                        name: "FK_DetallesReserva_Reservas_Reservaid",
                        column: x => x.Reservaid,
                        principalTable: "Reservas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetallesReserva_Servicios_Servicioid",
                        column: x => x.Servicioid,
                        principalTable: "Servicios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetallesReserva_Reservaid",
                table: "DetallesReserva",
                column: "Reservaid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetallesReserva");
        }
    }
}
