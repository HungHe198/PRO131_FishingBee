using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data_FishingBee.Migrations
{
    public partial class lan21 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WeekRevenues_Product_Categories_MonthRevenueId1",
                table: "WeekRevenues");

            migrationBuilder.DropIndex(
                name: "IX_WeekRevenues_MonthRevenueId1",
                table: "WeekRevenues");

            migrationBuilder.DropColumn(
                name: "MonthRevenueId1",
                table: "WeekRevenues");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "MonthRevenueId1",
                table: "WeekRevenues",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WeekRevenues_MonthRevenueId1",
                table: "WeekRevenues",
                column: "MonthRevenueId1");

            migrationBuilder.AddForeignKey(
                name: "FK_WeekRevenues_Product_Categories_MonthRevenueId1",
                table: "WeekRevenues",
                column: "MonthRevenueId1",
                principalTable: "Product_Categories",
                principalColumn: "Id");
        }
    }
}
