using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChatBot.Data.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ColorTypeId",
                value: 11);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ClothTypeId", "ColorTypeId", "Description", "MaterialTypeId", "Name", "Price", "ProductPhoto", "SizeEuTypeId", "SizeUsTypeId", "UserCartId" },
                values: new object[,]
                {
                    { 6, 2, 111, "ყველაზე ლამაზი კაბა", 4, "ვარდისფერი კაშმირის კაბა", 99.989999999999995, "5cb8b297-de57-4ee2-984a-7c9cdc748558.jpg", 36, 36, null },
                    { 7, 2, 11, "ყველაზე ლამაზი კაბა", 2, "ლურჯი ბამბის კაბა", 29.989999999999998, "6e143162-9472-43c3-8db1-04eeea838ae8.jpg", 36, 36, null },
                    { 8, 2, 107, "მოდური კაბა", 2, "მუქი ლურჯი ბამბის კაბა", 29.989999999999998, "6eaff8d0-517f-4fad-ad54-4249b8c53ff9.jpg", 36, 36, null },
                    { 9, 2, 138, "მოდური კაბა", 4, "თეთრი კაბა", 59.990000000000002, "7fc487f9-81a1-4285-aef9-45574cc8adce.jpg", 36, 36, null },
                    { 10, 1, 11, "შესანიშნავი შარვალი", 1, "მუქი ლურჯი შარვალი", 159.99000000000001, "0ccc318a-7d69-4d7f-a442-aac1f88bc453.jpg", 36, 36, null },
                    { 11, 1, 11, "შესანიშნავი შარვალი", 1, "ტყავის ლურჯი შარვალი", 129.99000000000001, "8acbe013-6f78-400b-a9e6-66144cf8574d.jpg", 36, 36, null },
                    { 12, 1, 115, "შესანიშნავი შარვალი", 3, "აბრეშუმის წითელი შარვალი", 2259.9899999999998, "119518b0-abfc-49a1-88dc-016f2dbd17ff.jpg", 35, 36, null },
                    { 13, 1, 140, "ყველაზე მოდური შარვალი", 3, "აბრეშუმის ყვითელი შარვალი", 1259.99, "300963e8-f469-471c-a7dd-9eed99ddad4f.jpg", 36, 36, null },
                    { 14, 4, 115, "ყველაზე მოდური შარვალი", 1, "წითელი ქუდი", 259.99000000000001, "1febd681-151b-4c8c-baff-ddc52d16c6c0.jpg", 39, 38, null },
                    { 15, 4, 115, "მაღალი ხარისხის წითელი ქუდი", 1, "ნაიკის ქუდი", 259.99000000000001, "2f96b4e8-3af7-4b3f-9488-69a51df7a917.jpg", 39, 38, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ColorTypeId",
                value: 46);
        }
    }
}
