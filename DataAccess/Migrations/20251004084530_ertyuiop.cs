using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ertyuiop : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "MatchId",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "MatchId",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "MatchId",
                keyValue: 402);

            migrationBuilder.AlterColumn<string>(
                name: "SeatNumber",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SeatNumber",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "MatchId", "AwayPenaltyScore", "AwayScore", "AwayTeamId", "EndTime", "HomePenaltyScore", "HomeScore", "HomeTeamId", "KickOffTime", "MatchDate", "Result", "Round", "SeasonId", "Stadium", "Status", "TeamId", "TeamId1", "TicketPrice", "TournamentId" },
                values: new object[,]
                {
                    { 400, null, 1, 2, null, null, 2, 1, null, new DateTime(2025, 10, 3, 20, 0, 0, 0, DateTimeKind.Local), 0, null, 1, "استاد القاهرة الدولي", 5, null, null, 100m, 1 },
                    { 401, null, null, 6, null, null, null, 5, null, new DateTime(2025, 10, 5, 21, 0, 0, 0, DateTimeKind.Local), null, null, 1, "استاد الإسماعيلية", 1, null, null, 80m, 1 },
                    { 402, null, null, 4, null, null, null, 3, null, new DateTime(2025, 10, 4, 19, 0, 0, 0, DateTimeKind.Local), null, null, 1, "استاد برج العرب", 0, null, null, 120m, 1 }
                });
        }
    }
}
