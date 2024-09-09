using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab7MVC.Migrations
{
    /// <inheritdoc />
    public partial class V2AddStorageQuantityColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.AddColumn<int>(
                name: "Storage",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 128);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Storage",
                table: "Products");
        }
    }
}
