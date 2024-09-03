using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data_FishingBee.Migrations
{
    public partial class lan8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_DailyRevenues_DailyRevenueId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_DailyRevenueId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DailyRevenueId",
                table: "Products");

            migrationBuilder.AddColumn<Guid>(
                name: "DailyRevenuesId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<Guid>(
                name: "ProductId",
                table: "DailyRevenues",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateIndex(
                name: "IX_DailyRevenues_ProductId",
                table: "DailyRevenues",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_DailyRevenues_Products_ProductId",
                table: "DailyRevenues",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DailyRevenues_Products_ProductId",
                table: "DailyRevenues");

            migrationBuilder.DropIndex(
                name: "IX_DailyRevenues_ProductId",
                table: "DailyRevenues");

            migrationBuilder.DropColumn(
                name: "DailyRevenuesId",
                table: "Products");

            migrationBuilder.AddColumn<Guid>(
                name: "DailyRevenueId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ProductId",
                table: "DailyRevenues",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_DailyRevenueId",
                table: "Products",
                column: "DailyRevenueId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_DailyRevenues_DailyRevenueId",
                table: "Products",
                column: "DailyRevenueId",
                principalTable: "DailyRevenues",
                principalColumn: "Id");
        }
    }
}
