using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedTeamSeason : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TeamSeasons",
                columns: new[] { "Id", "Draws", "Form", "GoalsAgainst", "GoalsFor", "IsQualified", "IsRelegated", "Losses", "Played", "Points", "Rank", "SeasonId", "TeamId", "Wins" },
                values: new object[,]
                {
                    { 1, 0, "W W W", 2, 7, true, false, 0, 3, 9, 1, 1, 1, 3 },
                    { 2, 0, "W W L", 3, 5, true, false, 1, 3, 6, 2, 1, 2, 2 },
                    { 3, 1, "L W D", 4, 4, false, false, 1, 3, 4, 3, 1, 3, 1 },
                    { 4, 1, "L D L", 6, 2, false, true, 2, 3, 1, 4, 1, 4, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TeamSeasons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TeamSeasons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TeamSeasons",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TeamSeasons",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
