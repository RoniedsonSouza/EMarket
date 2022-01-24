using Microsoft.EntityFrameworkCore.Migrations;

namespace Plugins.DataStore.Migrations
{
    public partial class upgradeProdutoA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Destaque",
                table: "Produtos",
                type: "bit",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(1,0)");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 1,
                columns: new[] { "Descricao", "Destaque", "Foto_Do_Produto" },
                values: new object[] { "", false, "" });

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 2,
                columns: new[] { "Descricao", "Destaque", "Foto_Do_Produto" },
                values: new object[] { "", false, "" });

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 3,
                columns: new[] { "Descricao", "Destaque", "Foto_Do_Produto" },
                values: new object[] { "", false, "" });

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 4,
                columns: new[] { "Descricao", "Destaque", "Foto_Do_Produto" },
                values: new object[] { "", false, "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Destaque",
                table: "Produtos",
                type: "numeric(1,0)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 1,
                columns: new[] { "Descricao", "Destaque", "Foto_Do_Produto" },
                values: new object[] { null, 0m, null });

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 2,
                columns: new[] { "Descricao", "Destaque", "Foto_Do_Produto" },
                values: new object[] { null, 0m, null });

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 3,
                columns: new[] { "Descricao", "Destaque", "Foto_Do_Produto" },
                values: new object[] { null, 0m, null });

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 4,
                columns: new[] { "Descricao", "Destaque", "Foto_Do_Produto" },
                values: new object[] { null, 0m, null });
        }
    }
}
