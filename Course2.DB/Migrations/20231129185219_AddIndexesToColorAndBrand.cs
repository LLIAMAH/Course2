using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Course2.DB.Migrations
{
    /// <inheritdoc />
    public partial class AddIndexesToColorAndBrand : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Colors_Name",
                table: "Colors",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Brands_Name",
                table: "Brands",
                column: "Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Colors_Name",
                table: "Colors");

            migrationBuilder.DropIndex(
                name: "IX_Brands_Name",
                table: "Brands");
        }
    }
}
