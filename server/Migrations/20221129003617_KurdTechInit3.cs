using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace server.Migrations
{
    /// <inheritdoc />
    public partial class KurdTechInit3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DropColumn(
                name: "ProductDetailId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "ProductDetails");

            migrationBuilder.RenameColumn(
                name: "Features",
                table: "ProductDetails",
                newName: "Stereo");

            migrationBuilder.AddColumn<string>(
                name: "AUX",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ChargingPort",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Features_camera",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FingerPrint",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "AUX",
                table: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "ChargingPort",
                table: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "Features_camera",
                table: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "FingerPrint",
                table: "ProductDetails");

            migrationBuilder.RenameColumn(
                name: "Stereo",
                table: "ProductDetails",
                newName: "Features");

            migrationBuilder.AddColumn<int>(
                name: "ProductDetailId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "ProductDetails",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Name" },
                values: new object[,]
                {
                    { 1, "@Icons.Filled.PhoneIphone", "مۆبایل" },
                    { 2, "@Icons.Filled.Tablet", "تابلێت" },
                    { 3, "@Icons.Filled.EarbudsBattery", "ئێکسسوارات" },
                    { 4, "@Icons.Filled.Headphones", "بیستۆک" },
                    { 5, "@Icons.Filled.Laptop", "لاپتۆپ" }
                });

            migrationBuilder.InsertData(
                table: "ProductDetails",
                columns: new[] { "Id", "Announced", "Battery_FastCharg", "CPU", "Card_Memory", "Chipset", "Color", "Dimensions", "Features", "Front", "GPU", "Main", "OS_UI", "Price", "RAM", "ROM", "SIM", "Size_Type_Display", "Status", "Weight", "resolution_RefreshRate" },
                values: new object[] { 1, null, null, null, null, null, null, null, null, null, null, null, null, 0.0, null, null, null, null, "14/11/2022", null, null });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Name", "Price", "ProductDetailId", "Quantity", "Rating" },
                values: new object[,]
                {
                    { 1, 1, "بەرهەمی کۆمپانیای ئەپڵ", "/image/Iphone/iPhone14pm.jpg", "Iphone 14 Pro max", 1300.0, 1, 100, 5 },
                    { 2, 1, "بەرهەمی کۆمپانیای ئەپڵ", "/image/Iphone/iPhone13pm.jpg", "Iphone 13 Pro max", 1200.0, 0, 90, 4 },
                    { 3, 1, "بەرهەمی کۆمپانیای ڕییەڵمی", "/image/realme/realme-gt-master.jpg", "Realme GT Master", 300.0, 0, 100, 3 },
                    { 4, 1, "بەرهەمی کۆمپانیای سامسونگ", "/image/phone/s22ultra5G.jpg", "Galaxy S22 Ultra", 1350.0, 0, 15, 5 },
                    { 5, 1, "بەرهەمی کۆمپانیای هواوی", "/image/huawei/p40 pro.jpg", "Huawei P40 Pro", 700.0, 0, 115, 3 },
                    { 6, 5, " بەرهەمی کۆمپانیای دێڵ ", "/image/phone/s22ultra5G.jpg", "Deel xps 17", 950.0, 0, 10, 3 },
                    { 7, 5, " بەرهەمی کۆمپانیای ئێچ پی ", "/image/phone/s22ultra5G.jpg", "HP Omen", 800.0, 0, 7, 3 }
                });
        }
    }
}
