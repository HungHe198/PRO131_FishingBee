using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data_FishingBee.Migrations
{
    public partial class lan25 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Coupons");

            migrationBuilder.AddColumn<Guid>(
                name: "ProductId",
                table: "WishLists",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<decimal>(
                name: "Profit",
                table: "WishLists",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<float>(
                name: "ProfitPercentage",
                table: "WishLists",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "QuantitySaled",
                table: "WishLists",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "CustomerId",
                table: "UserActivityLogs",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<decimal>(
                name: "Amount",
                table: "TransactionHistories",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<Guid>(
                name: "BillId",
                table: "TransactionHistories",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                table: "TransactionHistories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeName",
                table: "TransactionHistories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PaymentMethod",
                table: "TransactionHistories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "PurchaseHistoryId",
                table: "TransactionHistories",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TransactionType",
                table: "TransactionHistories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "PurchaseHistory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TotalQuantity = table.Column<int>(type: "int", nullable: false),
                    TotalCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SupplierName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdminName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdminId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SupplierId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchaseHistory_Admins_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PurchaseHistory_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PurchaseHistory_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WishLists_ProductId",
                table: "WishLists",
                column: "ProductId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserActivityLogs_CustomerId",
                table: "UserActivityLogs",
                column: "CustomerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TransactionHistories_BillId",
                table: "TransactionHistories",
                column: "BillId",
                unique: true,
                filter: "[BillId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionHistories_PurchaseHistoryId",
                table: "TransactionHistories",
                column: "PurchaseHistoryId",
                unique: true,
                filter: "[PurchaseHistoryId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseHistory_AdminId",
                table: "PurchaseHistory",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseHistory_ProductId",
                table: "PurchaseHistory",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseHistory_SupplierId",
                table: "PurchaseHistory",
                column: "SupplierId");

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionHistories_Bills_BillId",
                table: "TransactionHistories",
                column: "BillId",
                principalTable: "Bills",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionHistories_PurchaseHistory_PurchaseHistoryId",
                table: "TransactionHistories",
                column: "PurchaseHistoryId",
                principalTable: "PurchaseHistory",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserActivityLogs_Customers_CustomerId",
                table: "UserActivityLogs",
                column: "CustomerId",
                principalTable: "Customers",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransactionHistories_Bills_BillId",
                table: "TransactionHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_TransactionHistories_PurchaseHistory_PurchaseHistoryId",
                table: "TransactionHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_UserActivityLogs_Customers_CustomerId",
                table: "UserActivityLogs");

            migrationBuilder.DropForeignKey(
                name: "FK_WishLists_Products_ProductId",
                table: "WishLists");

            migrationBuilder.DropTable(
                name: "PurchaseHistory");

            migrationBuilder.DropIndex(
                name: "IX_WishLists_ProductId",
                table: "WishLists");

            migrationBuilder.DropIndex(
                name: "IX_UserActivityLogs_CustomerId",
                table: "UserActivityLogs");

            migrationBuilder.DropIndex(
                name: "IX_TransactionHistories_BillId",
                table: "TransactionHistories");

            migrationBuilder.DropIndex(
                name: "IX_TransactionHistories_PurchaseHistoryId",
                table: "TransactionHistories");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "WishLists");

            migrationBuilder.DropColumn(
                name: "Profit",
                table: "WishLists");

            migrationBuilder.DropColumn(
                name: "ProfitPercentage",
                table: "WishLists");

            migrationBuilder.DropColumn(
                name: "QuantitySaled",
                table: "WishLists");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "UserActivityLogs");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "TransactionHistories");

            migrationBuilder.DropColumn(
                name: "BillId",
                table: "TransactionHistories");

            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "TransactionHistories");

            migrationBuilder.DropColumn(
                name: "EmployeeName",
                table: "TransactionHistories");

            migrationBuilder.DropColumn(
                name: "PaymentMethod",
                table: "TransactionHistories");

            migrationBuilder.DropColumn(
                name: "PurchaseHistoryId",
                table: "TransactionHistories");

            migrationBuilder.DropColumn(
                name: "TransactionType",
                table: "TransactionHistories");

            migrationBuilder.CreateTable(
                name: "Coupons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupons", x => x.Id);
                });
        }
    }
}
