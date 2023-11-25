using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PharmacyUpdated.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "drugs",
                columns: table => new
                {
                    drugId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    drugName = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    price = table.Column<double>(type: "float", nullable: true),
                    expiryDate = table.Column<DateTime>(type: "date", nullable: true),
                    supplierId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_drugs", x => x.drugId);
                });

            migrationBuilder.CreateTable(
                name: "FinalDb",
                columns: table => new
                {
                    orderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userId = table.Column<int>(type: "int", nullable: true),
                    userName = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    drugId = table.Column<int>(type: "int", nullable: true),
                    drugName = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    quantity = table.Column<int>(type: "int", nullable: true),
                    totalPrice = table.Column<double>(type: "float", nullable: true),
                    drugExp = table.Column<DateTime>(type: "date", nullable: true),
                    OrderDate = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true),
                    userEmail = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    price = table.Column<double>(type: "float", nullable: true),
                    IsPicked = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__FinalDb__0809335DEDC62391", x => x.orderId);
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    supplierId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    supplierName = table.Column<string>(type: "varchar(120)", unicode: false, maxLength: 120, nullable: true),
                    supplierEmail = table.Column<string>(type: "varchar(120)", unicode: false, maxLength: 120, nullable: true),
                    supplierContact = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.supplierId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    userId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userName = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    UserContact = table.Column<long>(type: "bigint", nullable: true),
                    userAddress = table.Column<string>(type: "varchar(120)", unicode: false, maxLength: 120, nullable: true),
                    userEmail = table.Column<string>(type: "varchar(120)", unicode: false, maxLength: 120, nullable: true),
                    userPassword = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.userId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "drugs");

            migrationBuilder.DropTable(
                name: "FinalDb");

            migrationBuilder.DropTable(
                name: "Supplier");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
