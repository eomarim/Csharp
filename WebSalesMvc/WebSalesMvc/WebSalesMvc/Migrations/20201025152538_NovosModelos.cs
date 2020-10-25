using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebSalesMvc.Migrations
{
    public partial class NovosModelos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vendedor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Nascimento = table.Column<DateTime>(nullable: false),
                    SalarioBase = table.Column<double>(nullable: false),
                    DepartamentoVendedorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendedor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vendedor_Departamento_DepartamentoVendedorId",
                        column: x => x.DepartamentoVendedorId,
                        principalTable: "Departamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Venda",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Data = table.Column<DateTime>(nullable: false),
                    Valor = table.Column<double>(nullable: false),
                    StatusVenda = table.Column<int>(nullable: false),
                    VendedorVendaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Venda_Vendedor_VendedorVendaId",
                        column: x => x.VendedorVendaId,
                        principalTable: "Vendedor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Venda_VendedorVendaId",
                table: "Venda",
                column: "VendedorVendaId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendedor_DepartamentoVendedorId",
                table: "Vendedor",
                column: "DepartamentoVendedorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Venda");

            migrationBuilder.DropTable(
                name: "Vendedor");
        }
    }
}
