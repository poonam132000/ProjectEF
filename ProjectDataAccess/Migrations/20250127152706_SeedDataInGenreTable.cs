using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataInGenreTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "Display", "GenreName" },
                values: new object[] { 1, 1, "First" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 1);
        }
    }
}
