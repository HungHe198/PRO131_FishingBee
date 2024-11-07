using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data_FishingBee.Migrations
{
    public partial class lan27 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillDetails_Products_ProductId",
                table: "BillDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_DailyRevenues_Products_ProductId",
                table: "DailyRevenues");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventories_Products_ProductId",
                table: "Inventories");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductRevenues_Products_ProductId",
                table: "ProductRevenues");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseHistory_Products_ProductId",
                table: "PurchaseHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_WishLists_Products_ProductId",
                table: "WishLists");

            migrationBuilder.DropIndex(
                name: "IX_DailyRevenues_ProductId",
                table: "DailyRevenues");

            migrationBuilder.DropColumn(
                name: "DailyRevenuesId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Stock",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "DailyRevenues");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "WishLists",
                newName: "ProductDetailId");

            migrationBuilder.RenameIndex(
                name: "IX_WishLists_ProductId",
                table: "WishLists",
                newName: "IX_WishLists_ProductDetailId");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "PurchaseHistory",
                newName: "ProductDetailId");

            migrationBuilder.RenameIndex(
                name: "IX_PurchaseHistory_ProductId",
                table: "PurchaseHistory",
                newName: "IX_PurchaseHistory_ProductDetailId");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "ProductRevenues",
                newName: "ProductDetailId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductRevenues_ProductId",
                table: "ProductRevenues",
                newName: "IX_ProductRevenues_ProductDetailId");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Inventories",
                newName: "ProductDetailId");

            migrationBuilder.RenameIndex(
                name: "IX_Inventories_ProductId",
                table: "Inventories",
                newName: "IX_Inventories_ProductDetailId");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "BillDetails",
                newName: "ProductDetailId");

            migrationBuilder.RenameIndex(
                name: "IX_BillDetails_ProductId",
                table: "BillDetails",
                newName: "IX_BillDetails_ProductDetailId");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "ProductDetail",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Stock",
                table: "ProductDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "ProductDetailId",
                table: "DailyRevenues",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_DailyRevenues_ProductDetailId",
                table: "DailyRevenues",
                column: "ProductDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_BillDetails_ProductDetail_ProductDetailId",
                table: "BillDetails",
                column: "ProductDetailId",
                principalTable: "ProductDetail",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DailyRevenues_ProductDetail_ProductDetailId",
                table: "DailyRevenues",
                column: "ProductDetailId",
                principalTable: "ProductDetail",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Inventories_ProductDetail_ProductDetailId",
                table: "Inventories",
                column: "ProductDetailId",
                principalTable: "ProductDetail",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductRevenues_ProductDetail_ProductDetailId",
                table: "ProductRevenues",
                column: "ProductDetailId",
                principalTable: "ProductDetail",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseHistory_ProductDetail_ProductDetailId",
                table: "PurchaseHistory",
                column: "ProductDetailId",
                principalTable: "ProductDetail",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WishLists_ProductDetail_ProductDetailId",
                table: "WishLists",
                column: "ProductDetailId",
                principalTable: "ProductDetail",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillDetails_ProductDetail_ProductDetailId",
                table: "BillDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_DailyRevenues_ProductDetail_ProductDetailId",
                table: "DailyRevenues");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventories_ProductDetail_ProductDetailId",
                table: "Inventories");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductRevenues_ProductDetail_ProductDetailId",
                table: "ProductRevenues");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseHistory_ProductDetail_ProductDetailId",
                table: "PurchaseHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_WishLists_ProductDetail_ProductDetailId",
                table: "WishLists");

            migrationBuilder.DropIndex(
                name: "IX_DailyRevenues_ProductDetailId",
                table: "DailyRevenues");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "ProductDetail");

            migrationBuilder.DropColumn(
                name: "Stock",
                table: "ProductDetail");

            migrationBuilder.DropColumn(
                name: "ProductDetailId",
                table: "DailyRevenues");

            migrationBuilder.RenameColumn(
                name: "ProductDetailId",
                table: "WishLists",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_WishLists_ProductDetailId",
                table: "WishLists",
                newName: "IX_WishLists_ProductId");

            migrationBuilder.RenameColumn(
                name: "ProductDetailId",
                table: "PurchaseHistory",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_PurchaseHistory_ProductDetailId",
                table: "PurchaseHistory",
                newName: "IX_PurchaseHistory_ProductId");

            migrationBuilder.RenameColumn(
                name: "ProductDetailId",
                table: "ProductRevenues",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductRevenues_ProductDetailId",
                table: "ProductRevenues",
                newName: "IX_ProductRevenues_ProductId");

            migrationBuilder.RenameColumn(
                name: "ProductDetailId",
                table: "Inventories",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Inventories_ProductDetailId",
                table: "Inventories",
                newName: "IX_Inventories_ProductId");

            migrationBuilder.RenameColumn(
                name: "ProductDetailId",
                table: "BillDetails",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_BillDetails_ProductDetailId",
                table: "BillDetails",
                newName: "IX_BillDetails_ProductId");

            migrationBuilder.AddColumn<Guid>(
                name: "DailyRevenuesId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Stock",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "ProductId",
                table: "DailyRevenues",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DailyRevenues_ProductId",
                table: "DailyRevenues",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_BillDetails_Products_ProductId",
                table: "BillDetails",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DailyRevenues_Products_ProductId",
                table: "DailyRevenues",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventories_Products_ProductId",
                table: "Inventories",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductRevenues_Products_ProductId",
                table: "ProductRevenues",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseHistory_Products_ProductId",
                table: "PurchaseHistory",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WishLists_Products_ProductId",
                table: "WishLists",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
