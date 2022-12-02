using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace server.Migrations
{
    /// <inheritdoc />
    public partial class KurdTech123 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductDetails",
                table: "ProductDetails");

            migrationBuilder.RenameTable(
                name: "ProductDetails",
                newName: "PhoneDetail");

            migrationBuilder.RenameColumn(
                name: "Features_camera",
                table: "PhoneDetail",
                newName: "camera_Features");

            migrationBuilder.RenameColumn(
                name: "Battery_FastCharg",
                table: "PhoneDetail",
                newName: "Battery_FastCharge");

            migrationBuilder.AddColumn<int>(
                name: "AccessoriesId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LaptopDetailId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PhoneDetailId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PhoneDetail",
                table: "PhoneDetail",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "AccessoriesDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessoriesDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LaptopDetails",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Processor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RAM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ROM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GPU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Display = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperatingSystem = table.Column<string>(name: "Operating_System", type: "nvarchar(max)", nullable: true),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExtraDetail = table.Column<string>(name: "Extra_Detail", type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaptopDetails", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "PhoneDetail",
                columns: new[] { "Id", "AUX", "Announced", "Battery_FastCharge", "CPU", "Card_Memory", "ChargingPort", "Chipset", "Color", "Dimensions", "FingerPrint", "Front", "GPU", "Main", "OS_UI", "RAM", "ROM", "SIM", "Size_Type_Display", "Status", "Stereo", "Weight", "camera_Features", "resolution_RefreshRate" },
                values: new object[] { 1, null, "Nov 2021", "25 watt", "Apple A15 Bionic", null, null, null, "White", null, null, null, "Apple GPU", null, null, "6GB", "256GB", null, null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AccessoriesId", "ImageUrl", "LaptopDetailId", "PhoneDetailId" },
                values: new object[] { null, "/images/Phone/IPhone14ProMax.png", null, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AccessoriesId", "ImageUrl", "LaptopDetailId", "PhoneDetailId" },
                values: new object[] { null, "/images/Phone/IPhone13ProMax.png", null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AccessoriesId", "Description", "ImageUrl", "LaptopDetailId", "Name", "PhoneDetailId" },
                values: new object[] { null, "بەرهەمی کۆمپانیای ئینفینیکس", "/ images / Phone /InfinixZeroUltra.png", null, "Infinx Zero Ultra", null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AccessoriesId", "ImageUrl", "LaptopDetailId", "PhoneDetailId" },
                values: new object[] { null, "/images/Phone/GalaxyS22Ultra.png", null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AccessoriesId", "Description", "ImageUrl", "LaptopDetailId", "Name", "PhoneDetailId" },
                values: new object[] { null, "بەرهەمی کۆمپانیای ئۆپۆ", "/images/Phone/F11Pro.png", null, "F11 Pro", null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AccessoriesId", "CategoryId", "Description", "ImageUrl", "LaptopDetailId", "Name", "PhoneDetailId", "Price", "Rating" },
                values: new object[] { null, 1, "بەرهەمی کۆمپانیای وەنپلەس ", "/images/Phone/OnePlus9Pro.png", null, "One Plus9 Pro", null, 450.0, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AccessoriesId", "CategoryId", "Description", "ImageUrl", "LaptopDetailId", "Name", "PhoneDetailId", "Price", "Quantity" },
                values: new object[] { null, 1, "بەرهەمی کۆمپانیای گوگڵ ", "/images/Phone/Pixel6Pro.png", null, "Pixel 6 Pro", null, 400.0, 40 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AccessoriesId", "CategoryId", "Description", "ImageUrl", "LaptopDetailId", "Name", "PhoneDetailId", "Price", "Quantity", "Rating" },
                values: new object[,]
                {
                    { 8, null, 1, "بەرهەمی کۆمپانیای ریدمی ", "/images/Phone/RedmiNote12Pro.png", null, "Redmi Note 12 Pro", null, 350.0, 30, 3 },
                    { 9, null, 5, "بەرهەمی کۆمپانیای ئەپڵ", "/images/Laptops/DellXps17.jpg", null, "Dell Xps 17", null, 700.0, 10, 3 },
                    { 10, null, 5, "بەرهەمی کۆمپانیای ئێچ پی", "/images/Laptops/HpOmen.jpg", null, "Hp Omen", null, 800.0, 9, 3 },
                    { 11, null, 5, "بەرهەمی کۆمپانیای لینۆڤۆ", "/images/Laptops/LenovoIdeaPad.jpg", null, "Lenovo Idea Pad", null, 900.0, 15, 4 },
                    { 12, null, 5, "بەرهەمی کۆمپانیای ئەپڵ", "/images/Laptops/MacbookAirM1.jpg", null, "Macbook AirM1", null, 1000.0, 5, 4 },
                    { 13, null, 5, "بەرهەمی کۆمپانیای ئەپڵ", "/images/Laptops/MacbookAirM2.jpg", null, "Macbook AirM2", null, 1100.0, 6, 4 },
                    { 14, null, 5, "بەرهەمی کۆمپانیای ئەپڵ", "/images/Laptops/MacbookPro.jpg", null, "Macbook Pro", null, 1200.0, 5, 4 },
                    { 15, null, 2, "بەرهەمی کۆمپانیای ئەپڵ", "/images/Laptops/IPadPro12.9.png", null, "Ipad Pro 12.9", null, 950.0, 10, 4 },
                    { 16, null, 2, "بەرهەمی کۆمپانیای سامسونگ", "/images/Laptops/SamsungTabS8Ultra.png", null, "Samsung Tab S8 Ultra", null, 950.0, 10, 4 },
                    { 17, null, 4, "بەرهەمی کۆمپانیای ئەپڵ", "/images/Laptops/AirPodsPro2.png", null, "Air Pods Pro2", null, 100.0, 40, 4 },
                    { 18, null, 4, "بەرهەمی کۆمپانیای ئەپڵ", "/images/Laptops/AppleAirPodsMax.png", null, "Apple Air Pods Max", null, 110.0, 35, 4 },
                    { 19, null, 4, "بەرهەمی کۆمپانیای هایپەر ئێکس", "/images/Laptops/HyperxCloud2.png", null, "Hyperx Cloud2", null, 99.0, 33, 4 },
                    { 20, null, 4, "بەرهەمی کۆمپانیای ڕەیزەر", "/images/Laptops/KrakenX.png", null, "KrakenX", null, 120.0, 32, 4 },
                    { 21, null, 4, "بەرهەمی کۆمپانیای سۆنی", "/images/Laptops/WF1000XM4.png", null, "WF1000XM4", null, 130.0, 30, 4 },
                    { 22, null, 4, "بەرهەمی کۆمپانیای سۆنی", "/images/Laptops/WH1000XM4.png", null, "WH1000XM4", null, 140.0, 30, 4 },
                    { 23, null, 3, "بەرهەمی کۆمپانیای ئەپڵ", "/images/Laptops/AppleMagSafe.jpg", null, "Apple Mag Safe", null, 70.0, 30, 4 },
                    { 24, null, 3, "بەرهەمی کۆمپانیای ئەپڵ", "/images/Laptops/AppleMultiPort.jpg", null, "Apple Multi Port", null, 40.0, 30, 4 },
                    { 25, null, 3, "بەرهەمی کۆمپانیای ئەپڵ", "/images/Laptops/AppleTag.jpg", null, "Apple Tag", null, 50.0, 30, 4 },
                    { 26, null, 3, "بەرهەمی کۆمپانیای ئەپڵ", "/images/Laptops/AppleUSBCPowerAdapter.jpg", null, "Apple USBCPower Adapter", null, 60.0, 30, 4 },
                    { 27, null, 3, "بەرهەمی کۆمپانیای ئەپڵ", "/images/Laptops/AppleUSBPowerCable.jpg", null, "Apple USBPower Cable", null, 40.0, 30, 4 },
                    { 28, null, 3, "بەرهەمی کۆمپانیای سامسونگ", "/images/Laptops/GalaxyTag.jpg", null, "Galaxy Tag", null, 20.0, 30, 4 },
                    { 29, null, 3, "بەرهەمی کۆمپانیای سامسونگ", "/images/Laptops/SamsungPortableProjector.jpg", null, "Samsung Portable Projector", null, 20.0, 30, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_AccessoriesId",
                table: "Products",
                column: "AccessoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_LaptopDetailId",
                table: "Products",
                column: "LaptopDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_PhoneDetailId",
                table: "Products",
                column: "PhoneDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_AccessoriesDetail_AccessoriesId",
                table: "Products",
                column: "AccessoriesId",
                principalTable: "AccessoriesDetail",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_LaptopDetails_LaptopDetailId",
                table: "Products",
                column: "LaptopDetailId",
                principalTable: "LaptopDetails",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_PhoneDetail_PhoneDetailId",
                table: "Products",
                column: "PhoneDetailId",
                principalTable: "PhoneDetail",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_AccessoriesDetail_AccessoriesId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_LaptopDetails_LaptopDetailId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_PhoneDetail_PhoneDetailId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "AccessoriesDetail");

            migrationBuilder.DropTable(
                name: "LaptopDetails");

            migrationBuilder.DropIndex(
                name: "IX_Products_AccessoriesId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_LaptopDetailId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_PhoneDetailId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PhoneDetail",
                table: "PhoneDetail");

            migrationBuilder.DeleteData(
                table: "PhoneDetail",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DropColumn(
                name: "AccessoriesId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "LaptopDetailId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "PhoneDetailId",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "PhoneDetail",
                newName: "ProductDetails");

            migrationBuilder.RenameColumn(
                name: "camera_Features",
                table: "ProductDetails",
                newName: "Features_camera");

            migrationBuilder.RenameColumn(
                name: "Battery_FastCharge",
                table: "ProductDetails",
                newName: "Battery_FastCharg");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductDetails",
                table: "ProductDetails",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "/image/Iphone/iPhone14pm.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "/image/Iphone/iPhone13pm.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "بەرهەمی کۆمپانیای ڕییەڵمی", "/image/realme/realme-gt-master.jpg", "Realme GT Master" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "/image/phone/s22ultra5G.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "بەرهەمی کۆمپانیای هواوی", "/image/huawei/p40 pro.jpg", "Huawei P40 Pro" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Name", "Price", "Rating" },
                values: new object[] { 5, " بەرهەمی کۆمپانیای دێڵ ", "/image/phone/s22ultra5G.jpg", "Deel xps 17", 950.0, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[] { 5, " بەرهەمی کۆمپانیای ئێچ پی ", "/image/phone/s22ultra5G.jpg", "HP Omen", 800.0, 7 });
        }
    }
}
