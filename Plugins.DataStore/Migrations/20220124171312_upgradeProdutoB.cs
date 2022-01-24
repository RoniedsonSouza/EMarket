using Microsoft.EntityFrameworkCore.Migrations;

namespace Plugins.DataStore.Migrations
{
    public partial class upgradeProdutoB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Categorias_CategoryId",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_CategoryId",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "Foto_Do_Produto",
                table: "Produtos");

            migrationBuilder.AddColumn<int>(
                name: "FotoID",
                table: "Produtos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Foto_Do_ProdutoFotoID",
                table: "Produtos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Fotos",
                columns: table => new
                {
                    FotoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imagem = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fotos", x => x.FotoID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_Foto_Do_ProdutoFotoID",
                table: "Produtos",
                column: "Foto_Do_ProdutoFotoID");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_FotoID",
                table: "Produtos",
                column: "FotoID");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Categorias_FotoID",
                table: "Produtos");

            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Fotos_Foto_Do_ProdutoFotoID",
                table: "Produtos");

            migrationBuilder.DropTable(
                name: "Fotos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_Foto_Do_ProdutoFotoID",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_FotoID",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "FotoID",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "Foto_Do_ProdutoFotoID",
                table: "Produtos");

            migrationBuilder.AddColumn<string>(
                name: "Foto_Do_Produto",
                table: "Produtos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 1,
                column: "Foto_Do_Produto",
                value: "");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 2,
                column: "Foto_Do_Produto",
                value: "");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 3,
                column: "Foto_Do_Produto",
                value: "");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 4,
                column: "Foto_Do_Produto",
                value: "");

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
        }
    }
}
