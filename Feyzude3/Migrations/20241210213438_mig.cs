using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Feyzude3.Migrations
{
    /// <inheritdoc />
    public partial class mig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AdminId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdminPass = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AdminId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Category_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category_Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Category_Id);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    SubCategory_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubCategory_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category_Id = table.Column<int>(type: "int", nullable: false),
                    Category_Id1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.SubCategory_Id);
                    table.ForeignKey(
                        name: "FK_SubCategories_Categories_Category_Id1",
                        column: x => x.Category_Id1,
                        principalTable: "Categories",
                        principalColumn: "Category_Id");
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Product_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Product_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Product_Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Product_Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Product_Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category_Id = table.Column<int>(type: "int", nullable: false),
                    Category_Id1 = table.Column<int>(type: "int", nullable: true),
                    SubCategory_Id = table.Column<int>(type: "int", nullable: false),
                    SubCategory_Id1 = table.Column<int>(type: "int", nullable: true),
                    Product_Feature = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Product_Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_Category_Id1",
                        column: x => x.Category_Id1,
                        principalTable: "Categories",
                        principalColumn: "Category_Id");
                    table.ForeignKey(
                        name: "FK_Products_SubCategories_SubCategory_Id1",
                        column: x => x.SubCategory_Id1,
                        principalTable: "SubCategories",
                        principalColumn: "SubCategory_Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_Category_Id1",
                table: "Products",
                column: "Category_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SubCategory_Id1",
                table: "Products",
                column: "SubCategory_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_Category_Id1",
                table: "SubCategories",
                column: "Category_Id1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
