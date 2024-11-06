using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eshop.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class add_data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Elektronik" },
                    { 2, "Kırtasiye" },
                    { 3, "Mobilya" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "ImageUrl", "Name", "Price", "StockCount", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, null, "Dell süperdir", "https://picsum.photos/seed/picsum/200/300", "Dell", 100m, 100, null },
                    { 2, 1, null, "Yüksek performanslı HP laptop", "https://picsum.photos/seed/picsum/200/300", "HP Laptop", 120m, 80, null },
                    { 3, 1, null, "Apple kalitesinde iPhone", "https://picsum.photos/seed/picsum/200/300", "Apple iPhone", 200m, 50, null },
                    { 4, 1, null, "Samsung Galaxy telefon", "https://picsum.photos/seed/picsum/200/300", "Samsung Galaxy", 150m, 60, null },
                    { 5, 1, null, "Sony kaliteli kulaklık", "https://picsum.photos/seed/picsum/200/300", "Sony Kulaklık", 60m, 150, null },
                    { 6, 1, null, "Canon profesyonel kamera", "https://picsum.photos/seed/picsum/200/300", "Canon Kamera", 300m, 40, null },
                    { 7, 1, null, "LG geniş ekran TV", "https://picsum.photos/seed/picsum/200/300", "LG Televizyon", 500m, 25, null },
                    { 8, 2, null, "Rahat yazım için Pilot kalem", "https://picsum.photos/seed/picsum/200/300", "Pilot Kalem", 5m, 500, null },
                    { 9, 2, null, "100 yapraklı kaliteli defter", "https://picsum.photos/seed/picsum/200/300", "Defter", 10m, 300, null },
                    { 10, 2, null, "Ofis için organizer", "https://picsum.photos/seed/picsum/200/300", "Masaüstü Organizer", 20m, 120, null },
                    { 11, 2, null, "Belgeler için dosya", "https://picsum.photos/seed/picsum/200/300", "Dosya", 2m, 400, null },
                    { 12, 2, null, "Matematik için cetvel seti", "https://picsum.photos/seed/picsum/200/300", "Cetvel Seti", 8m, 200, null },
                    { 13, 2, null, "Mavi tükenmez kalem", "https://picsum.photos/seed/picsum/200/300", "Tükenmez Kalem", 3m, 600, null },
                    { 14, 2, null, "Yumuşak yapıda silgi", "https://picsum.photos/seed/picsum/200/300", "Silgi", 1m, 1000, null },
                    { 15, 3, null, "Rahat ofis sandalyesi", "https://picsum.photos/seed/picsum/200/300", "Ofis Sandalyesi", 150m, 70, null },
                    { 16, 3, null, "Modern tasarımlı çalışma masası", "https://picsum.photos/seed/picsum/200/300", "Çalışma Masası", 200m, 50, null },
                    { 17, 3, null, "Geniş kitaplık", "https://picsum.photos/seed/picsum/200/300", "Kitaplık", 120m, 40, null },
                    { 18, 3, null, "Konforlu L koltuk", "https://picsum.photos/seed/picsum/200/300", "L Koltuk", 600m, 20, null },
                    { 19, 3, null, "Şık sehpa", "https://picsum.photos/seed/picsum/200/300", "Sehpa", 70m, 100, null },
                    { 20, 3, null, "3 kapılı geniş gardırop", "https://picsum.photos/seed/picsum/200/300", "Gardırop", 300m, 30, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
