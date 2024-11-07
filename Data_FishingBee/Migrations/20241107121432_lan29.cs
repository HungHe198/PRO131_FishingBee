using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data_FishingBee.Migrations
{
    public partial class lan29 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cart_Products_Products_ProductId",
                table: "Cart_Products");

            migrationBuilder.DropIndex(
                name: "IX_Cart_Products_ProductId",
                table: "Cart_Products");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Cart_Products");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ProductId",
                table: "Cart_Products",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cart_Products_ProductId",
                table: "Cart_Products",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_Products_Products_ProductId",
                table: "Cart_Products",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }
    }
}
