using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plugins.DataStore.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    TransactionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataTransacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProdutoId = table.Column<int>(type: "int", nullable: false),
                    NomeProduto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Preco = table.Column<double>(type: "float", nullable: false),
                    QtdAnterior = table.Column<int>(type: "int", nullable: false),
                    QuantidadeVendida = table.Column<int>(type: "int", nullable: false),
                    NomeCaixa = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.TransactionId);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    ProdutoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    Preco = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.ProdutoId);
                    table.ForeignKey(
                        name: "FK_Produtos_Categorias_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categorias",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "CategoryId", "Description", "Name" },
                values: new object[] { 1, "Blusa", "Blusa" });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "CategoryId", "Description", "Name" },
                values: new object[] { 2, "Calçados", "Calçados" });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "CategoryId", "Description", "Name" },
                values: new object[] { 3, "Acessórios", "Acessórios" });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "ProdutoId", "CategoryId", "Name", "Preco", "Quantidade" },
                values: new object[,]
                {
                    { 1, 1, "Produto Teste", 100.0, 50 },
                    { 2, 1, "Short", 5.9900000000000002, 10 },
                    { 3, 1, "Camisa", 59.990000000000002, 8 },
                    { 4, 2, "Corta Vento", 3.9900000000000002, 100 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_CategoryId",
                table: "Produtos",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Categorias");
        }
    }
}
