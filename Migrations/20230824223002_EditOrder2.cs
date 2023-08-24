using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fruit.Migrations
{
    /// <inheritdoc />
    public partial class EditOrder2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Inventories_InventoryId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_InventoryId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "InventoryId",
                table: "Orders");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InventoryId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_InventoryId",
                table: "Orders",
                column: "InventoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Inventories_InventoryId",
                table: "Orders",
                column: "InventoryId",
                principalTable: "Inventories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
