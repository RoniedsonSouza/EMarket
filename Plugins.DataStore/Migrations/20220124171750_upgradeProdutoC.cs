using Microsoft.EntityFrameworkCore.Migrations;

namespace Plugins.DataStore.Migrations
{
    public partial class upgradeProdutoC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Categorias_FotoID",
                table: "Produtos");

            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Fotos_Foto_Do_ProdutoFotoID",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_Foto_Do_ProdutoFotoID",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "Foto_Do_ProdutoFotoID",
                table: "Produtos");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_CategoryId",
                table: "Produtos",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Categorias_CategoryId",
                table: "Produtos",
                column: "CategoryId",
                principalTable: "Categorias",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Fotos_FotoID",
                table: "Produtos",
                column: "FotoID",
                principalTable: "Fotos",
                principalColumn: "FotoID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Categorias_CategoryId",
                table: "Produtos");

            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Fotos_FotoID",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_CategoryId",
                table: "Produtos");

            migrationBuilder.AddColumn<int>(
                name: "Foto_Do_ProdutoFotoID",
                table: "Produtos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_Foto_Do_ProdutoFotoID",
                table: "Produtos",
                column: "Foto_Do_ProdutoFotoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Categorias_FotoID",
                table: "Produtos",
                column: "FotoID",
                principalTable: "Categorias",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Fotos_Foto_Do_ProdutoFotoID",
                table: "Produtos",
                column: "Foto_Do_ProdutoFotoID",
                principalTable: "Fotos",
                principalColumn: "FotoID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
