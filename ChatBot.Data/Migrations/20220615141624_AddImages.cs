using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChatBot.Data.Migrations
{
    public partial class AddImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductPhotoId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProductPhotos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Data = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPhotos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ProductPhotos",
                columns: new[] { "Id", "Data", "Path" },
                values: new object[,]
                {
                    { 1, null, "C:\\Users\\ramazi\\Desktop\\photos\\dress.jpg" },
                    { 2, null, "C:\\Users\\ramazi\\Desktop\\photos\\hat.jpg" },
                    { 3, null, "C:\\Users\\ramazi\\Desktop\\photos\\pants.jpg" },
                    { 4, null, "C:\\Users\\ramazi\\Desktop\\photos\\shoes.jpg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductPhotoId",
                table: "Products",
                column: "ProductPhotoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductPhotos_ProductPhotoId",
                table: "Products",
                column: "ProductPhotoId",
                principalTable: "ProductPhotos",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductPhotos_ProductPhotoId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "ProductPhotos");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductPhotoId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductPhotoId",
                table: "Products");
        }
    }
}
