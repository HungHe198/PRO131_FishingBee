using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data_FishingBee.Migrations
{
    public partial class lan28 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cart_Products_Products_ProductId",
                table: "Cart_Products");

            migrationBuilder.AlterColumn<Guid>(
                name: "ProductId",
                table: "Cart_Products",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "ProductDetailId",
                table: "Cart_Products",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Cart_Products_ProductDetailId",
                table: "Cart_Products",
                column: "ProductDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_Products_ProductDetail_ProductDetailId",
                table: "Cart_Products",
                column: "ProductDetailId",
                principalTable: "ProductDetail",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_Products_Products_ProductId",
                table: "Cart_Products",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cart_Products_ProductDetail_ProductDetailId",
                table: "Cart_Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Cart_Products_Products_ProductId",
                table: "Cart_Products");

            migrationBuilder.DropIndex(
                name: "IX_Cart_Products_ProductDetailId",
                table: "Cart_Products");

            migrationBuilder.DropColumn(
                name: "ProductDetailId",
                table: "Cart_Products");

            migrationBuilder.AlterColumn<Guid>(
                name: "ProductId",
                table: "Cart_Products",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_Products_Products_ProductId",
                table: "Cart_Products",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
