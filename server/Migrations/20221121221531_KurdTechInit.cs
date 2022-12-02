using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace server.Migrations
{
    /// <inheritdoc />
    public partial class KurdTechInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Category",
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
                table: "Product",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Name", "Price", "Quantity", "Rating" },
                values: new object[,]
                {
                    { 1, 1, "بەرهەمی کۆمپانیای ئەپڵ", "/image/Iphone/iPhone14pm.jpg", "Iphone 14 Pro max", 1300.0, 100, 5 },
                    { 2, 1, "بەرهەمی کۆمپانیای ئەپڵ", "/image/Iphone/iPhone13pm.jpg", "Iphone 13 Pro max", 1200.0, 90, 4 },
                    { 3, 1, "بەرهەمی کۆمپانیای ڕییەڵمی", "/image/realme/realme-gt-master.jpg", "Realme GT Master", 300.0, 100, 3 },
                    { 4, 1, "بەرهەمی کۆمپانیای سامسونگ", "/image/phone/s22ultra5G.jpg", "Galaxy S22 Ultra", 1350.0, 15, 5 },
                    { 5, 1, "بەرهەمی کۆمپانیای هواوی", "/image/huawei/p40 pro.jpg", "Huawei P40 Pro", 700.0, 115, 3 },
                    { 6, 5, " بەرهەمی کۆمپانیای دێڵ ", "/image/phone/s22ultra5G.jpg", "Deel xps 17", 950.0, 10, 3 },
                    { 7, 5, " بەرهەمی کۆمپانیای ئێچ پی ", "/image/phone/s22ultra5G.jpg", "HP Omen", 800.0, 7, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
