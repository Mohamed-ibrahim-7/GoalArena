using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tournaments",
                columns: new[] { "TournamentId", "Country", "LogoUrl", "Name" },
                values: new object[] { 3, "أوروبا", "/images/tournaments/ucl.png", "دوري أبطال أوروبا" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "TournamentId",
                keyValue: 3);
        }
    }
}
