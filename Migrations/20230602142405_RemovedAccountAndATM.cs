using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATMSimulator.Migrations
{
    /// <inheritdoc />
    public partial class RemovedAccountAndATM : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "ATMs");

            migrationBuilder.RenameColumn(
                name: "AccountToId",
                table: "Transactions",
                newName: "SenderCardId");

            migrationBuilder.RenameColumn(
                name: "AccountFromId",
                table: "Transactions",
                newName: "ReceiverCardId");

            migrationBuilder.RenameColumn(
                name: "AccountId",
                table: "Cards",
                newName: "CustomerId");

            migrationBuilder.AddColumn<decimal>(
                name: "Balance",
                table: "Cards",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Balance",
                table: "Cards");

            migrationBuilder.RenameColumn(
                name: "SenderCardId",
                table: "Transactions",
                newName: "AccountToId");

            migrationBuilder.RenameColumn(
                name: "ReceiverCardId",
                table: "Transactions",
                newName: "AccountFromId");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Cards",
                newName: "AccountId");

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountType = table.Column<int>(type: "int", nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ATMs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CashBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsOnline = table.Column<bool>(type: "bit", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxWithdrawalLimit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ATMs", x => x.Id);
                });
        }
    }
}
