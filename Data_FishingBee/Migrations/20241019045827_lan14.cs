using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data_FishingBee.Migrations
{
    public partial class lan14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DailyRevenues_MonthRevenues_MonthRevenueId",
                table: "DailyRevenues");

            migrationBuilder.DropIndex(
                name: "IX_DailyRevenues_MonthRevenueId",
                table: "DailyRevenues");

            migrationBuilder.DropColumn(
                name: "DailyRevenuesId",
                table: "MonthRevenues");

            migrationBuilder.DropColumn(
                name: "MonthRevenueId",
                table: "DailyRevenues");

            migrationBuilder.AddColumn<int>(
                name: "WeekOfYear",
                table: "WeekRevenues",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WeekOfYear",
                table: "DailyRevenues",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WeekOfYear",
                table: "WeekRevenues");

            migrationBuilder.DropColumn(
                name: "WeekOfYear",
                table: "DailyRevenues");

            migrationBuilder.AddColumn<Guid>(
                name: "DailyRevenuesId",
                table: "MonthRevenues",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "MonthRevenueId",
                table: "DailyRevenues",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DailyRevenues_MonthRevenueId",
                table: "DailyRevenues",
                column: "MonthRevenueId");

            migrationBuilder.AddForeignKey(
                name: "FK_DailyRevenues_MonthRevenues_MonthRevenueId",
                table: "DailyRevenues",
                column: "MonthRevenueId",
                principalTable: "MonthRevenues",
                principalColumn: "Id");
        }
    }
}
