using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data_FishingBee.Migrations
{
    public partial class lan24 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ProductId",
                table: "ProductRevenues",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CategoryId",
                table: "CategoryRevenues",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductRevenues_ProductId",
                table: "ProductRevenues",
                column: "ProductId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CategoryRevenues_CategoryId",
                table: "CategoryRevenues",
                column: "CategoryId",
                unique: true,
                filter: "[CategoryId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryRevenues_Categories_CategoryId",
                table: "CategoryRevenues",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductRevenues_Products_ProductId",
                table: "ProductRevenues",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryRevenues_Categories_CategoryId",
                table: "CategoryRevenues");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductRevenues_Products_ProductId",
                table: "ProductRevenues");

            migrationBuilder.DropIndex(
                name: "IX_ProductRevenues_ProductId",
                table: "ProductRevenues");

            migrationBuilder.DropIndex(
                name: "IX_CategoryRevenues_CategoryId",
                table: "CategoryRevenues");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "ProductRevenues");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "CategoryRevenues");
        }
    }
}
