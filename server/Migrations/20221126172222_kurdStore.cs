using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace server.Migrations
{
    /// <inheritdoc />
    public partial class kurdStore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductDetailId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ProductDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Announced = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SizeTypeDisplay = table.Column<string>(name: "Size_Type_Display", type: "nvarchar(max)", nullable: true),
                    resolutionRefreshRate = table.Column<string>(name: "resolution_RefreshRate", type: "nvarchar(max)", nullable: true),
                    OSUI = table.Column<string>(name: "OS_UI", type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SIM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RAM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ROM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardMemory = table.Column<string>(name: "Card_Memory", type: "nvarchar(max)", nullable: true),
                    CPU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GPU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Chipset = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Main = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Features = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Front = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BatteryFastCharg = table.Column<string>(name: "Battery_FastCharg", type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDetails", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ProductDetails",
                columns: new[] { "Id", "Announced", "Battery_FastCharg", "CPU", "Card_Memory", "Chipset", "Color", "Dimensions", "Features", "Front", "GPU", "Main", "OS_UI", "Price", "RAM", "ROM", "SIM", "Size_Type_Display", "Status", "Weight", "resolution_RefreshRate" },
                values: new object[] { 1, null, null, null, null, null, null, null, null, null, null, null, null, 0.0, null, null, null, null, "14/11/2022", null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProductDetailId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProductDetailId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ProductDetailId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ProductDetailId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ProductDetailId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ProductDetailId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "ProductDetailId",
                value: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "ProductDetailId",
                table: "Products");
        }
    }
}
