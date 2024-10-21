using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data_FishingBee.Migrations
{
    public partial class lan20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "MonthRevenueId1",
                table: "WeekRevenues",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Product_Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Categories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_Categories_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WeekRevenues_MonthRevenueId1",
                table: "WeekRevenues",
                column: "MonthRevenueId1");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Categories_CategoryId",
                table: "Product_Categories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Categories_ProductId",
                table: "Product_Categories",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_WeekRevenues_Product_Categories_MonthRevenueId1",
                table: "WeekRevenues",
                column: "MonthRevenueId1",
                principalTable: "Product_Categories",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WeekRevenues_Product_Categories_MonthRevenueId1",
                table: "WeekRevenues");

            migrationBuilder.DropTable(
                name: "Product_Categories");

            migrationBuilder.DropIndex(
                name: "IX_WeekRevenues_MonthRevenueId1",
                table: "WeekRevenues");

            migrationBuilder.DropColumn(
                name: "MonthRevenueId1",
                table: "WeekRevenues");
        }
    }
}
