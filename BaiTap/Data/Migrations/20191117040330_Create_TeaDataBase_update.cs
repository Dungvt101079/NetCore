using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BaiTap.Data.Migrations
{
    public partial class Create_TeaDataBase_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer",
                table: "Customer");

            migrationBuilder.RenameTable(
                name: "Customer",
                newName: "Customers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "TeaOrders",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    TotalPrice = table.Column<double>(nullable: false),
                    CustomerId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeaOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeaOrders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teas",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeaOrderTeas",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    TeaOrderId = table.Column<Guid>(nullable: false),
                    TeaId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeaOrderTeas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeaOrderTeas_Teas_TeaId",
                        column: x => x.TeaId,
                        principalTable: "Teas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeaOrderTeas_TeaOrders_TeaOrderId",
                        column: x => x.TeaOrderId,
                        principalTable: "TeaOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TeaOrders_CustomerId",
                table: "TeaOrders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_TeaOrderTeas_TeaId",
                table: "TeaOrderTeas",
                column: "TeaId");

            migrationBuilder.CreateIndex(
                name: "IX_TeaOrderTeas_TeaOrderId",
                table: "TeaOrderTeas",
                column: "TeaOrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeaOrderTeas");

            migrationBuilder.DropTable(
                name: "Teas");

            migrationBuilder.DropTable(
                name: "TeaOrders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "Customer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer",
                table: "Customer",
                column: "Id");
        }
    }
}
