using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeekShopping.ProductAPI.Migrations
{
    public partial class SeedProductDataTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category", "description", "image_url", "name", "price" },
                values: new object[,]
                {
                    { 3L, "", "", "", "Iphone 7", 1000m },
                    { 4L, "", "", "", "Iphone 8", 1200m },
                    { 5L, "", "", "", "Iphone X", 1400m },
                    { 6L, "", "", "", "Iphone XR", 1500m },
                    { 7L, "", "", "", "Iphone XS", 1600m },
                    { 8L, "", "", "", "Iphone XS Max", 1800m },
                    { 9L, "", "", "", "Iphone 11 Mini", 2000m },
                    { 10L, "", "", "", "Iphone 11", 2200m },
                    { 11L, "", "", "", "Iphone 11 Pro", 2400m },
                    { 12L, "", "", "", "Iphone 12 Mini", 2500m },
                    { 13L, "", "", "", "Iphone 12", 2600m },
                    { 14L, "", "", "", "Iphone 12 Pro", 2800m },
                    { 15L, "", "", "", "Iphone 13 Mini", 3000m },
                    { 16L, "", "", "", "Iphone 11", 3200m },
                    { 17L, "", "", "", "Iphone 13 Pro", 3400m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 17L);
        }
    }
}
