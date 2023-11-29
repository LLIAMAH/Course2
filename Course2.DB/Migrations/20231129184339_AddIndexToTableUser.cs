using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Course2.DB.Migrations
{
    /// <inheritdoc />
    public partial class AddIndexToTableUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Users_Name_Surname",
                table: "Users",
                columns: new[] { "Name", "Surname" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_Name_Surname",
                table: "Users");
        }
    }
}
