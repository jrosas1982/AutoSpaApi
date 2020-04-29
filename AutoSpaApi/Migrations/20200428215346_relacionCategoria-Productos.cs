using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoSpaApi.Migrations
{
    public partial class relacionCategoriaProductos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Categorias_categoriasid",
                table: "Productos");

            migrationBuilder.AlterColumn<int>(
                name: "categoriasid",
                table: "Productos",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Categorias_categoriasid",
                table: "Productos",
                column: "categoriasid",
                principalTable: "Categorias",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Categorias_categoriasid",
                table: "Productos");

            migrationBuilder.AlterColumn<int>(
                name: "categoriasid",
                table: "Productos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Categorias_categoriasid",
                table: "Productos",
                column: "categoriasid",
                principalTable: "Categorias",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
