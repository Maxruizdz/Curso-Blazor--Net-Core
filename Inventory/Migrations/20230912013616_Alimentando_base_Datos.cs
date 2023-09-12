using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Inventory.Migrations
{
    /// <inheritdoc />
    public partial class Alimentando_base_Datos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "categoriaEntities",
                columns: new[] { "CategoriaId", "CategoriaName" },
                values: new object[,]
                {
                    { "ASH", "Aseo Hogar" },
                    { "ASP", "Aseo Personal" },
                    { "HGR", "Hogar" },
                    { "PRF", "Perfumeria" },
                    { "SLD", "Salud" }
                });

            migrationBuilder.InsertData(
                table: "wherehouseEntities",
                columns: new[] { "WherehouseId", "WherehouseAddress", "WherehouseName" },
                values: new object[,]
                {
                    { "60b3cb83-47d3-40ee-aed0-ffc58e427ba1", "Calle 6 con 47", "Bodega Norte" },
                    { "a3ea7dd7-b947-4ff0-ae67-028346775ffa", "Calle 8 con 2", "Bodega Central" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "categoriaEntities",
                keyColumn: "CategoriaId",
                keyValue: "ASH");

            migrationBuilder.DeleteData(
                table: "categoriaEntities",
                keyColumn: "CategoriaId",
                keyValue: "ASP");

            migrationBuilder.DeleteData(
                table: "categoriaEntities",
                keyColumn: "CategoriaId",
                keyValue: "HGR");

            migrationBuilder.DeleteData(
                table: "categoriaEntities",
                keyColumn: "CategoriaId",
                keyValue: "PRF");

            migrationBuilder.DeleteData(
                table: "categoriaEntities",
                keyColumn: "CategoriaId",
                keyValue: "SLD");

            migrationBuilder.DeleteData(
                table: "wherehouseEntities",
                keyColumn: "WherehouseId",
                keyValue: "60b3cb83-47d3-40ee-aed0-ffc58e427ba1");

            migrationBuilder.DeleteData(
                table: "wherehouseEntities",
                keyColumn: "WherehouseId",
                keyValue: "a3ea7dd7-b947-4ff0-ae67-028346775ffa");
        }
    }
}
