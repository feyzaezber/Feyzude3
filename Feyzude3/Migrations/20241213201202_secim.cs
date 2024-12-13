using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Feyzude3.Migrations
{
    /// <inheritdoc />
    public partial class secim : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_Category_Id1",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_SubCategories_Categories_Category_Id1",
                table: "SubCategories");

            migrationBuilder.DropIndex(
                name: "IX_SubCategories_Category_Id1",
                table: "SubCategories");

            migrationBuilder.DropIndex(
                name: "IX_Products_Category_Id1",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Category_Id1",
                table: "SubCategories");

            migrationBuilder.DropColumn(
                name: "Category_Id1",
                table: "Products");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_Category_Id",
                table: "SubCategories",
                column: "Category_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Category_Id",
                table: "Products",
                column: "Category_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_Category_Id",
                table: "Products",
                column: "Category_Id",
                principalTable: "Categories",
                principalColumn: "Category_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategories_Categories_Category_Id",
                table: "SubCategories",
                column: "Category_Id",
                principalTable: "Categories",
                principalColumn: "Category_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_Category_Id",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_SubCategories_Categories_Category_Id",
                table: "SubCategories");

            migrationBuilder.DropIndex(
                name: "IX_SubCategories_Category_Id",
                table: "SubCategories");

            migrationBuilder.DropIndex(
                name: "IX_Products_Category_Id",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "Category_Id1",
                table: "SubCategories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Category_Id1",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_Category_Id1",
                table: "SubCategories",
                column: "Category_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Category_Id1",
                table: "Products",
                column: "Category_Id1");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_Category_Id1",
                table: "Products",
                column: "Category_Id1",
                principalTable: "Categories",
                principalColumn: "Category_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategories_Categories_Category_Id1",
                table: "SubCategories",
                column: "Category_Id1",
                principalTable: "Categories",
                principalColumn: "Category_Id");
        }
    }
}
