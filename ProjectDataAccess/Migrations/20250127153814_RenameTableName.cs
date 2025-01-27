using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class RenameTableName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Genres",
                table: "Genres");

            migrationBuilder.RenameTable(
                name: "Genres",
                newName: "GenreTable");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GenreTable",
                table: "GenreTable",
                column: "GenreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_GenreTable",
                table: "GenreTable");

            migrationBuilder.RenameTable(
                name: "GenreTable",
                newName: "Genres");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genres",
                table: "Genres",
                column: "GenreId");
        }
    }
}
