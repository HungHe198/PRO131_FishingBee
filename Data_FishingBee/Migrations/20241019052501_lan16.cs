using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data_FishingBee.Migrations
{
    public partial class lan16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CartId",
                table: "Cart_Products",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ProductId",
                table: "Cart_Products",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Cart_Products_CartId",
                table: "Cart_Products",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_Cart_Products_ProductId",
                table: "Cart_Products",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_Products_Carts_CartId",
                table: "Cart_Products",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_Products_Products_ProductId",
                table: "Cart_Products",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cart_Products_Carts_CartId",
                table: "Cart_Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Cart_Products_Products_ProductId",
                table: "Cart_Products");

            migrationBuilder.DropIndex(
                name: "IX_Cart_Products_CartId",
                table: "Cart_Products");

            migrationBuilder.DropIndex(
                name: "IX_Cart_Products_ProductId",
                table: "Cart_Products");

            migrationBuilder.DropColumn(
                name: "CartId",
                table: "Cart_Products");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Cart_Products");
        }
    }
}
