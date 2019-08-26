using Microsoft.EntityFrameworkCore.Migrations;

namespace QuickBuy.Repositorio.Migrations
{
    public partial class _20190826_DB01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Pedido_PedidoId",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_PedidoId",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "PedidoId",
                table: "Usuario");

            migrationBuilder.AddColumn<int>(
                name: "PedidoId",
                table: "ItemPedido",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemPedido_PedidoId",
                table: "ItemPedido",
                column: "PedidoId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemPedido_Pedido_PedidoId",
                table: "ItemPedido",
                column: "PedidoId",
                principalTable: "Pedido",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemPedido_Pedido_PedidoId",
                table: "ItemPedido");

            migrationBuilder.DropIndex(
                name: "IX_ItemPedido_PedidoId",
                table: "ItemPedido");

            migrationBuilder.DropColumn(
                name: "PedidoId",
                table: "ItemPedido");

            migrationBuilder.AddColumn<int>(
                name: "PedidoId",
                table: "Usuario",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_PedidoId",
                table: "Usuario",
                column: "PedidoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Pedido_PedidoId",
                table: "Usuario",
                column: "PedidoId",
                principalTable: "Pedido",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
