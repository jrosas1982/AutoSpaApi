using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoSpaApi.Migrations
{
    public partial class relacionCategoriaProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Categorias_Categoriaid",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Productos_Categoriaid",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "Categoriaid",
                table: "Productos");

            migrationBuilder.AddColumn<int>(
                name: "categoriasid",
                table: "Productos",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nombreCategoria",
                table: "Categorias",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Productos_categoriasid",
                table: "Productos",
                column: "categoriasid");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Categorias_categoriasid",
                table: "Productos",
                column: "categoriasid",
                principalTable: "Categorias",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Categorias_categoriasid",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Productos_categoriasid",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "categoriasid",
                table: "Productos");

            migrationBuilder.AddColumn<int>(
                name: "Categoriaid",
                table: "Productos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "nombreCategoria",
                table: "Categorias",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.CreateIndex(
                name: "IX_Productos_Categoriaid",
                table: "Productos",
                column: "Categoriaid");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Categorias_Categoriaid",
                table: "Productos",
                column: "Categoriaid",
                principalTable: "Categorias",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
