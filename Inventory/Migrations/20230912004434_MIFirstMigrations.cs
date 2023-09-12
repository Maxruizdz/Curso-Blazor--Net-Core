using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inventory.Migrations
{
    /// <inheritdoc />
    public partial class MIFirstMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categoriaEntities",
                columns: table => new
                {
                    CategoriaId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CategoriaName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categoriaEntities", x => x.CategoriaId);
                });

            migrationBuilder.CreateTable(
                name: "wherehouseEntities",
                columns: table => new
                {
                    WherehouseId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    WherehouseName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    WherehouseAddress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wherehouseEntities", x => x.WherehouseId);
                });

            migrationBuilder.CreateTable(
                name: "productEntities",
                columns: table => new
                {
                    ProductId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProductDescription = table.Column<string>(type: "nvarchar(600)", maxLength: 600, nullable: false),
                    TotalQuality = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoriaId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productEntities", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_productEntities_categoriaEntities_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "categoriaEntities",
                        principalColumn: "CategoriaId");
                });

            migrationBuilder.CreateTable(
                name: "storageEntities",
                columns: table => new
                {
                    StorageId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PartialQuantity = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    WherehouseId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_storageEntities", x => x.StorageId);
                    table.ForeignKey(
                        name: "FK_storageEntities_productEntities_ProductId",
                        column: x => x.ProductId,
                        principalTable: "productEntities",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_storageEntities_wherehouseEntities_WherehouseId",
                        column: x => x.WherehouseId,
                        principalTable: "wherehouseEntities",
                        principalColumn: "WherehouseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "inventaryEntities",
                columns: table => new
                {
                    InOutId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    InOutDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    IsInput = table.Column<bool>(type: "bit", nullable: false),
                    StorageId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inventaryEntities", x => x.InOutId);
                    table.ForeignKey(
                        name: "FK_inventaryEntities_storageEntities_StorageId",
                        column: x => x.StorageId,
                        principalTable: "storageEntities",
                        principalColumn: "StorageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_inventaryEntities_StorageId",
                table: "inventaryEntities",
                column: "StorageId");

            migrationBuilder.CreateIndex(
                name: "IX_productEntities_CategoriaId",
                table: "productEntities",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_storageEntities_ProductId",
                table: "storageEntities",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_storageEntities_WherehouseId",
                table: "storageEntities",
                column: "WherehouseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "inventaryEntities");

            migrationBuilder.DropTable(
                name: "storageEntities");

            migrationBuilder.DropTable(
                name: "productEntities");

            migrationBuilder.DropTable(
                name: "wherehouseEntities");

            migrationBuilder.DropTable(
                name: "categoriaEntities");
        }
    }
}
