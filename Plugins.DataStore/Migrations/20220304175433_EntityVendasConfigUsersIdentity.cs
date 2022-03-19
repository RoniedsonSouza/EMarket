using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plugins.DataStore.Migrations
{
    public partial class EntityVendasConfigUsersIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vendas",
                columns: table => new
                {
                    VendaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    VendedorId = table.Column<int>(type: "int", nullable: false),
                    Data_Venda = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Previsao_Entrega = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProdutoId = table.Column<int>(type: "int", nullable: false),
                    Forma_Envio = table.Column<int>(type: "int", nullable: false),
                    Valor_Frete = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Valor_Venda = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendas", x => x.VendaId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vendas");
        }
    }
}
