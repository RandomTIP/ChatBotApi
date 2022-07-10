using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChatBot.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClothTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClothTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ColorTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColorTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaterialTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SizeEuTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SizeEuTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SizeUsTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SizeUsTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GenderTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserCarts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Sum = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCarts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserCarts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductPhoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SizeEuTypeId = table.Column<int>(type: "int", nullable: false),
                    SizeUsTypeId = table.Column<int>(type: "int", nullable: false),
                    ClothTypeId = table.Column<int>(type: "int", nullable: false),
                    MaterialTypeId = table.Column<int>(type: "int", nullable: false),
                    ColorTypeId = table.Column<int>(type: "int", nullable: false),
                    UserCartId = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_ClothTypes_ClothTypeId",
                        column: x => x.ClothTypeId,
                        principalTable: "ClothTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_ColorTypes_ColorTypeId",
                        column: x => x.ColorTypeId,
                        principalTable: "ColorTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_MaterialTypes_MaterialTypeId",
                        column: x => x.MaterialTypeId,
                        principalTable: "MaterialTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_SizeEuTypes_SizeEuTypeId",
                        column: x => x.SizeEuTypeId,
                        principalTable: "SizeEuTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_SizeUsTypes_SizeUsTypeId",
                        column: x => x.SizeUsTypeId,
                        principalTable: "SizeUsTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_UserCarts_UserCartId",
                        column: x => x.UserCartId,
                        principalTable: "UserCarts",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "ClothTypes",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, null, "Pants" },
                    { 2, null, "Dress" },
                    { 3, null, "Shirt" },
                    { 4, null, "Hat" }
                });

            migrationBuilder.InsertData(
                table: "ColorTypes",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, null, "Transparent" },
                    { 2, null, "AliceBlue" },
                    { 3, null, "AntiqueWhite" },
                    { 4, null, "Aqua" },
                    { 5, null, "Aquamarine" },
                    { 6, null, "Azure" },
                    { 7, null, "Beige" },
                    { 8, null, "Bisque" },
                    { 9, null, "Black" },
                    { 10, null, "BlanchedAlmond" },
                    { 11, null, "Blue" },
                    { 12, null, "BlueViolet" },
                    { 13, null, "Brown" },
                    { 14, null, "BurlyWood" },
                    { 15, null, "CadetBlue" },
                    { 16, null, "Chartreuse" },
                    { 17, null, "Chocolate" },
                    { 18, null, "Coral" },
                    { 19, null, "CornflowerBlue" },
                    { 20, null, "Cornsilk" },
                    { 21, null, "Crimson" },
                    { 22, null, "Cyan" },
                    { 23, null, "DarkBlue" },
                    { 24, null, "DarkCyan" },
                    { 25, null, "DarkGoldenrod" },
                    { 26, null, "DarkGray" },
                    { 27, null, "DarkGreen" },
                    { 28, null, "DarkKhaki" },
                    { 29, null, "DarkMagenta" },
                    { 30, null, "DarkOliveGreen" },
                    { 31, null, "DarkOrange" },
                    { 32, null, "DarkOrchid" },
                    { 33, null, "DarkRed" },
                    { 34, null, "DarkSalmon" },
                    { 35, null, "DarkSeaGreen" },
                    { 36, null, "DarkSlateBlue" },
                    { 37, null, "DarkSlateGray" },
                    { 38, null, "DarkTurquoise" }
                });

            migrationBuilder.InsertData(
                table: "ColorTypes",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 39, null, "DarkViolet" },
                    { 40, null, "DeepPink" },
                    { 41, null, "DeepSkyBlue" },
                    { 42, null, "DimGray" },
                    { 43, null, "DodgerBlue" },
                    { 44, null, "Firebrick" },
                    { 45, null, "FloralWhite" },
                    { 46, null, "ForestGreen" },
                    { 47, null, "Fuchsia" },
                    { 48, null, "Gainsboro" },
                    { 49, null, "GhostWhite" },
                    { 50, null, "Gold" },
                    { 51, null, "Goldenrod" },
                    { 52, null, "Gray" },
                    { 53, null, "Green" },
                    { 54, null, "GreenYellow" },
                    { 55, null, "Honeydew" },
                    { 56, null, "HotPink" },
                    { 57, null, "IndianRed" },
                    { 58, null, "Indigo" },
                    { 59, null, "Ivory" },
                    { 60, null, "Khaki" },
                    { 61, null, "Lavender" },
                    { 62, null, "LavenderBlush" },
                    { 63, null, "LawnGreen" },
                    { 64, null, "LemonChiffon" },
                    { 65, null, "LightBlue" },
                    { 66, null, "LightCoral" },
                    { 67, null, "LightCyan" },
                    { 68, null, "LightGoldenrodYellow" },
                    { 69, null, "LightGray" },
                    { 70, null, "LightGreen" },
                    { 71, null, "LightPink" },
                    { 72, null, "LightSalmon" },
                    { 73, null, "LightSeaGreen" },
                    { 74, null, "LightSkyBlue" },
                    { 75, null, "LightSlateGray" },
                    { 76, null, "LightSteelBlue" },
                    { 77, null, "LightYellow" },
                    { 78, null, "Lime" },
                    { 79, null, "LimeGreen" },
                    { 80, null, "Linen" }
                });

            migrationBuilder.InsertData(
                table: "ColorTypes",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 81, null, "Magenta" },
                    { 82, null, "Maroon" },
                    { 83, null, "MediumAquamarine" },
                    { 84, null, "MediumBlue" },
                    { 85, null, "MediumOrchid" },
                    { 86, null, "MediumPurple" },
                    { 87, null, "MediumSeaGreen" },
                    { 88, null, "MediumSlateBlue" },
                    { 89, null, "MediumSpringGreen" },
                    { 90, null, "MediumTurquoise" },
                    { 91, null, "MediumVioletRed" },
                    { 92, null, "MidnightBlue" },
                    { 93, null, "MintCream" },
                    { 94, null, "MistyRose" },
                    { 95, null, "Moccasin" },
                    { 96, null, "NavajoWhite" },
                    { 97, null, "Navy" },
                    { 98, null, "OldLace" },
                    { 99, null, "Olive" },
                    { 100, null, "OliveDrab" },
                    { 101, null, "Orange" },
                    { 102, null, "OrangeRed" },
                    { 103, null, "Orchid" },
                    { 104, null, "PaleGoldenrod" },
                    { 105, null, "PaleGreen" },
                    { 106, null, "PaleTurquoise" },
                    { 107, null, "PaleVioletRed" },
                    { 108, null, "PapayaWhip" },
                    { 109, null, "PeachPuff" },
                    { 110, null, "Peru" },
                    { 111, null, "Pink" },
                    { 112, null, "Plum" },
                    { 113, null, "PowderBlue" },
                    { 114, null, "Purple" },
                    { 115, null, "Red" },
                    { 116, null, "RosyBrown" },
                    { 117, null, "RoyalBlue" },
                    { 118, null, "SaddleBrown" },
                    { 119, null, "Salmon" },
                    { 120, null, "SandyBrown" },
                    { 121, null, "SeaGreen" },
                    { 122, null, "SeaShell" }
                });

            migrationBuilder.InsertData(
                table: "ColorTypes",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 123, null, "Sienna" },
                    { 124, null, "Silver" },
                    { 125, null, "SkyBlue" },
                    { 126, null, "SlateBlue" },
                    { 127, null, "SlateGray" },
                    { 128, null, "Snow" },
                    { 129, null, "SpringGreen" },
                    { 130, null, "SteelBlue" },
                    { 131, null, "Tan" },
                    { 132, null, "Teal" },
                    { 133, null, "Thistle" },
                    { 134, null, "Tomato" },
                    { 135, null, "Turquoise" },
                    { 136, null, "Violet" },
                    { 137, null, "Wheat" },
                    { 138, null, "White" },
                    { 139, null, "WhiteSmoke" },
                    { 140, null, "Yellow" },
                    { 141, null, "YellowGreen" }
                });

            migrationBuilder.InsertData(
                table: "MaterialTypes",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, null, "Leather" },
                    { 2, null, "Cotton" },
                    { 3, null, "Silk" },
                    { 4, null, "Kashmir" },
                    { 5, null, "Wool" },
                    { 6, null, "Synthetics" },
                    { 7, null, "Satin" },
                    { 8, null, "Linen" },
                    { 9, null, "Lace" },
                    { 10, null, "Denim" },
                    { 11, null, "Crepe" },
                    { 12, null, "Chiffon" }
                });

            migrationBuilder.InsertData(
                table: "SizeEuTypes",
                columns: new[] { "Id", "Description", "Value" },
                values: new object[,]
                {
                    { 32, null, 32 },
                    { 33, null, 33 },
                    { 34, null, 34 },
                    { 35, null, 35 },
                    { 36, null, 36 },
                    { 37, null, 37 },
                    { 38, null, 38 },
                    { 39, null, 39 },
                    { 40, null, 40 },
                    { 41, null, 41 },
                    { 42, null, 42 }
                });

            migrationBuilder.InsertData(
                table: "SizeEuTypes",
                columns: new[] { "Id", "Description", "Value" },
                values: new object[,]
                {
                    { 43, null, 43 },
                    { 44, null, 44 },
                    { 45, null, 45 },
                    { 46, null, 46 }
                });

            migrationBuilder.InsertData(
                table: "SizeUsTypes",
                columns: new[] { "Id", "Description", "Value" },
                values: new object[,]
                {
                    { 34, null, "Xs" },
                    { 36, null, "S" },
                    { 38, null, "M" },
                    { 40, null, "L" },
                    { 42, null, "Xl" },
                    { 44, null, "XXl" },
                    { 46, null, "XXXl" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ClothTypeId", "ColorTypeId", "Description", "MaterialTypeId", "Name", "Price", "ProductPhoto", "SizeEuTypeId", "SizeUsTypeId", "UserCartId" },
                values: new object[,]
                {
                    { 1, 1, 9, "ყველაზე მაგარი ბრენდული შარვალი", 2, "მასიმო დუტის შარვალი", 399.99000000000001, "1d407629-87e5-4702-b9fc-e3b19de93570.jpg", 39, 38, null },
                    { 2, 2, 46, "ყველაზე ძერსკი კაბა", 4, "ზარას კაბა", 899.99000000000001, "6b779a54-4cdc-4205-ba1f-9597c779a683.jpg", 36, 36, null },
                    { 3, 3, 13, "ყველაზე ხარისხიანი პერანგი", 2, "მაიკლ კორსის პერანგი", 299.99000000000001, "0d293c69-ba4f-4ffc-b6b9-fa05316a02c5.jpg", 43, 42, null },
                    { 4, 4, 107, "ყველაზე ლამაზი ქუდი", 7, "ლუი ვიტონის ქუდი", 99.989999999999995, "a47cd387-993a-4e23-b8a8-259d036cf37b.jpg", 40, 40, null },
                    { 5, 3, 11, "ძალიან ლამაზი პერანგი", 2, "ლამაზი პერანგი", 399.99000000000001, "0d293c69-ba4f-4ffc-b6b9-fa05316a02c5.jpg", 39, 38, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ClothTypeId",
                table: "Products",
                column: "ClothTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ColorTypeId",
                table: "Products",
                column: "ColorTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_MaterialTypeId",
                table: "Products",
                column: "MaterialTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SizeEuTypeId",
                table: "Products",
                column: "SizeEuTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SizeUsTypeId",
                table: "Products",
                column: "SizeUsTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_UserCartId",
                table: "Products",
                column: "UserCartId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCarts_UserId",
                table: "UserCarts",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ClothTypes");

            migrationBuilder.DropTable(
                name: "ColorTypes");

            migrationBuilder.DropTable(
                name: "MaterialTypes");

            migrationBuilder.DropTable(
                name: "SizeEuTypes");

            migrationBuilder.DropTable(
                name: "SizeUsTypes");

            migrationBuilder.DropTable(
                name: "UserCarts");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
