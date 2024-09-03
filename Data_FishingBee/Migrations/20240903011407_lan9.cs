using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data_FishingBee.Migrations
{
    public partial class lan9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "DailyRevenuesId",
                table: "WeekRevenues",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "MonthRevenueId",
                table: "WeekRevenues",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DailyRevenuesId",
                table: "MonthRevenues",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "WeekRevenuesId",
                table: "MonthRevenues",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "MonthRevenueId",
                table: "DailyRevenues",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "WeekRevenueId",
                table: "DailyRevenues",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WeekRevenues_MonthRevenueId",
                table: "WeekRevenues",
                column: "MonthRevenueId");

            migrationBuilder.CreateIndex(
                name: "IX_DailyRevenues_MonthRevenueId",
                table: "DailyRevenues",
                column: "MonthRevenueId");

            migrationBuilder.CreateIndex(
                name: "IX_DailyRevenues_WeekRevenueId",
                table: "DailyRevenues",
                column: "WeekRevenueId");

            migrationBuilder.AddForeignKey(
                name: "FK_DailyRevenues_MonthRevenues_MonthRevenueId",
                table: "DailyRevenues",
                column: "MonthRevenueId",
                principalTable: "MonthRevenues",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DailyRevenues_WeekRevenues_WeekRevenueId",
                table: "DailyRevenues",
                column: "WeekRevenueId",
                principalTable: "WeekRevenues",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WeekRevenues_MonthRevenues_MonthRevenueId",
                table: "WeekRevenues",
                column: "MonthRevenueId",
                principalTable: "MonthRevenues",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DailyRevenues_MonthRevenues_MonthRevenueId",
                table: "DailyRevenues");

            migrationBuilder.DropForeignKey(
                name: "FK_DailyRevenues_WeekRevenues_WeekRevenueId",
                table: "DailyRevenues");

            migrationBuilder.DropForeignKey(
                name: "FK_WeekRevenues_MonthRevenues_MonthRevenueId",
                table: "WeekRevenues");

            migrationBuilder.DropIndex(
                name: "IX_WeekRevenues_MonthRevenueId",
                table: "WeekRevenues");

            migrationBuilder.DropIndex(
                name: "IX_DailyRevenues_MonthRevenueId",
                table: "DailyRevenues");

            migrationBuilder.DropIndex(
                name: "IX_DailyRevenues_WeekRevenueId",
                table: "DailyRevenues");

            migrationBuilder.DropColumn(
                name: "DailyRevenuesId",
                table: "WeekRevenues");

            migrationBuilder.DropColumn(
                name: "MonthRevenueId",
                table: "WeekRevenues");

            migrationBuilder.DropColumn(
                name: "DailyRevenuesId",
                table: "MonthRevenues");

            migrationBuilder.DropColumn(
                name: "WeekRevenuesId",
                table: "MonthRevenues");

            migrationBuilder.DropColumn(
                name: "MonthRevenueId",
                table: "DailyRevenues");

            migrationBuilder.DropColumn(
                name: "WeekRevenueId",
                table: "DailyRevenues");
        }
    }
}
