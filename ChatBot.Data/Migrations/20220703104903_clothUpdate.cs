using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChatBot.Data.Migrations
{
    public partial class clothUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ClothTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Shirt");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ColorTypeId", "Description", "MaterialTypeId", "Name" },
                values: new object[] { 13, "ყველაზე ხარისხიანი პერანგი", 2, "მაიკლ კორსის პერანგი" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ClothTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Shoe");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ColorTypeId", "Description", "MaterialTypeId", "Name" },
                values: new object[] { 120, "ყველაზე ხარისხიანი კეტები", 1, "Eco კეტები" });
        }
    }
}
