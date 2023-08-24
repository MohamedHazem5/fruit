using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fruit.Migrations
{
    /// <inheritdoc />
    public partial class EditOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "date",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "quantities",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "total",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "Orders",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "shippingaddress",
                table: "Orders",
                newName: "ShippingAddress");

            migrationBuilder.RenameColumn(
                name: "itemspurchased",
                table: "Orders",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "Customer_name",
                table: "Orders",
                newName: "CustomerName");

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Note",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Orders",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "ShippingAddress",
                table: "Orders",
                newName: "shippingaddress");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Orders",
                newName: "itemspurchased");

            migrationBuilder.RenameColumn(
                name: "CustomerName",
                table: "Orders",
                newName: "Customer_name");

            migrationBuilder.AddColumn<int>(
                name: "date",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "quantities",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "total",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
