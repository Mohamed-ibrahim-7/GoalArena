using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class sampleSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tournaments",
                columns: new[] { "TournamentId", "Country", "LogoUrl", "Name" },
                values: new object[] { 1, "مصر", "/images/tournaments/egyptian-premier-league.png", "الدوري المصري الممتاز" });

            migrationBuilder.InsertData(
                table: "Seasons",
                columns: new[] { "SeasonId", "EndDate", "Name", "StartDate", "Status", "TournamentId" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2025-2026", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "City", "Coach", "Colors", "Country", "Draws", "Founded", "GoalsAgainst", "GoalsFor", "LogoUrl", "Losses", "Name", "Played", "Position", "SeasonId", "ShortName", "Stadium", "StadiumCapacity", "Website", "Wins" },
                values: new object[,]
                {
                    { 1, "القاهرة", "مارسيل كولر", "أحمر وأبيض", "مصر", 0, new DateTime(1907, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 9, "/images/teams/al-ahly.png", 0, "الأهلي", 3, 1, 1, "AHL", "استاد الأهلي WE", 30000, "https://www.alahlyegypt.com/", 3 },
                    { 2, "القاهرة", "فرانسيسكو ميكالي", "أبيض وأحمر", "مصر", 1, new DateTime(1911, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 5, "/images/teams/zamalek.png", 0, "الزمالك", 3, 2, 1, "ZAM", "استاد القاهرة الدولي", 75000, "https://www.zamalekclub.com/", 2 },
                    { 3, "القاهرة", "خالد جلال", "أزرق وأصفر", "مصر", 2, new DateTime(2008, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3, "/images/teams/pyramids.png", 0, "بيراميدز", 3, 3, 1, "PYR", "استاد 30 يونيو", 30000, "https://www.pyramidsfc.com/", 1 },
                    { 4, "بورسعيد", "محمد عودة", "أخضر وأبيض", "مصر", 1, new DateTime(1920, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3, "/images/teams/el-masry.png", 1, "المصري", 3, 4, 1, "MAS", "استاد بورسعيد", 18000, "https://www.almasryclub.com/", 1 },
                    { 5, "القاهرة", "علي ماهر", "أبيض وأزرق", "مصر", 0, new DateTime(2011, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 2, "/images/teams/future-fc.png", 2, "فيوتشر", 3, 5, 1, "FUT", "استاد WE الأهلي", 20000, "https://www.futurefcegypt.com/", 1 },
                    { 6, "القاهرة", "هاني رمزي", "أزرق وأبيض", "مصر", 0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 0, "/images/teams/ceramica-cleopatra.png", 3, "سيراميكا كليوباترا", 3, 6, 1, "CER", "استاد الأكاديمية العسكرية", 28500, "https://www.ceramicacleopatrafc.com/", 0 }
                });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "MatchId", "AwayPenaltyScore", "AwayScore", "AwayTeamId", "EndTime", "HomePenaltyScore", "HomeScore", "HomeTeamId", "KickOffTime", "MatchDate", "Result", "Round", "SeasonId", "Stadium", "Status", "TeamId", "TeamId1", "TournamentId" },
                values: new object[,]
                {
                    { 1, null, 0, 4, new DateTime(2025, 8, 20, 20, 45, 0, 0, DateTimeKind.Unspecified), null, 2, 1, new TimeSpan(0, 19, 0, 0, 0), new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "الجولة 1", 1, "استاد الأهلي WE", 5, null, null, 1 },
                    { 2, null, 1, 5, new DateTime(2025, 8, 21, 20, 45, 0, 0, DateTimeKind.Unspecified), null, 2, 2, new TimeSpan(0, 19, 0, 0, 0), new DateTime(2025, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "الجولة 1", 1, "استاد القاهرة الدولي", 5, null, null, 1 },
                    { 3, null, 0, 6, new DateTime(2025, 8, 22, 18, 45, 0, 0, DateTimeKind.Unspecified), null, 1, 3, new TimeSpan(0, 17, 0, 0, 0), new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "الجولة 1", 1, "استاد 30 يونيو", 5, null, null, 1 },
                    { 4, null, 3, 1, new DateTime(2025, 8, 25, 20, 45, 0, 0, DateTimeKind.Unspecified), null, 0, 5, new TimeSpan(0, 19, 0, 0, 0), new DateTime(2025, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "الجولة 2", 1, "استاد WE الأهلي", 5, null, null, 1 },
                    { 5, null, 2, 2, new DateTime(2025, 8, 26, 20, 45, 0, 0, DateTimeKind.Unspecified), null, 0, 6, new TimeSpan(0, 19, 0, 0, 0), new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "الجولة 2", 1, "استاد الأكاديمية العسكرية", 5, null, null, 1 },
                    { 6, null, 1, 3, new DateTime(2025, 8, 27, 18, 45, 0, 0, DateTimeKind.Unspecified), null, 1, 4, new TimeSpan(0, 17, 0, 0, 0), new DateTime(2025, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "الجولة 2", 1, "استاد بورسعيد", 5, null, null, 1 },
                    { 7, null, 0, 6, new DateTime(2025, 9, 1, 20, 45, 0, 0, DateTimeKind.Unspecified), null, 4, 1, new TimeSpan(0, 19, 0, 0, 0), new DateTime(2025, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "الجولة 3", 1, "استاد الأهلي WE", 5, null, null, 1 },
                    { 8, null, 1, 2, new DateTime(2025, 9, 2, 20, 45, 0, 0, DateTimeKind.Unspecified), null, 1, 3, new TimeSpan(0, 19, 0, 0, 0), new DateTime(2025, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "الجولة 3", 1, "استاد 30 يونيو", 5, null, null, 1 },
                    { 9, null, 1, 5, new DateTime(2025, 9, 3, 18, 45, 0, 0, DateTimeKind.Unspecified), null, 2, 4, new TimeSpan(0, 17, 0, 0, 0), new DateTime(2025, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "الجولة 3", 1, "استاد بورسعيد", 5, null, null, 1 },
                    { 10, null, null, 1, null, null, null, 2, new TimeSpan(0, 19, 0, 0, 0), new DateTime(2025, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "الجولة 4", 1, "استاد القاهرة الدولي", 0, null, null, 1 },
                    { 11, null, null, 3, null, null, null, 5, new TimeSpan(0, 17, 0, 0, 0), new DateTime(2025, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "الجولة 4", 1, "استاد WE الأهلي", 0, null, null, 1 },
                    { 12, null, null, 4, null, null, null, 6, new TimeSpan(0, 19, 0, 0, 0), new DateTime(2025, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "الجولة 4", 1, "استاد الأكاديمية العسكرية", 0, null, null, 1 }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "PlayerId", "Age", "Assists", "DateOfBirth", "FullName", "Goals", "ImageUrl", "MatchesPlayed", "MinutesPlayed", "Name", "NationalTeam", "Nationality", "Position", "RedCards", "SecondaryPosition", "ShirtNumber", "TeamId", "YellowCards" },
                values: new object[,]
                {
                    { 1, 36, 0, new DateTime(1988, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "محمد الشناوي", 0, "/images/players/mohamed-el-shenawy.png", 3, 270, "محمد الشناوي", "مصر", "مصر", "حارس مرمى", 0, null, 1, 1, 0 },
                    { 2, 29, 1, new DateTime(1996, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "محمد مجدي أفشة", 2, "/images/players/mohamed-magdy-afsha.png", 3, 255, "محمد مجدي أفشة", "مصر", "مصر", "وسط", 0, null, 19, 1, 1 },
                    { 3, 31, 1, new DateTime(1994, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "برسي تاو", 3, "/images/players/percy-tau.png", 3, 235, "برسي تاو", "جنوب أفريقيا", "جنوب أفريقيا", "مهاجم", 0, null, 22, 1, 0 },
                    { 4, 32, 2, new DateTime(1992, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "حسين الشحات", 2, "/images/players/hussein-el-shahat.png", 3, 270, "حسين الشحات", "مصر", "مصر", "جناح", 0, null, 14, 1, 0 },
                    { 5, 27, 0, new DateTime(1997, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "أليو ديانج", 0, "/images/players/aliou-dieng.png", 3, 270, "أليو ديانج", "مالي", "مالي", "وسط دفاعي", 0, null, 15, 1, 1 },
                    { 6, 33, 0, new DateTime(1992, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "محمد عواد", 0, "/images/players/mohamed-awad.png", 3, 270, "محمد عواد", "مصر", "مصر", "حارس مرمى", 0, null, 1, 2, 0 },
                    { 7, 29, 0, new DateTime(1996, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "أحمد سيد زيزو", 3, "/images/players/ahmed-sayed-zizo.png", 3, 270, "أحمد سيد زيزو", "مصر", "مصر", "جناح", 0, null, 17, 2, 1 },
                    { 8, 24, 0, new DateTime(2001, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "إبراهيم عادل", 2, "/images/players/ibrahim-adel.png", 3, 270, "إبراهيم عادل", "مصر", "مصر", "مهاجم", 0, null, 11, 3, 0 }
                });

            migrationBuilder.InsertData(
                table: "MatchEvents",
                columns: new[] { "Id", "Corners", "Description", "EventType", "ExtraMinute", "Fouls", "GoalType", "MatchId", "Minute", "Offsides", "PassAccuracy", "PlayerId", "Possession", "RedCards", "RelatedPlayerId", "Saves", "Shots", "ShotsOnTarget", "TeamId", "YellowCards" },
                values: new object[,]
                {
                    { 1, null, "برسي تاو يسجل من عرضية حسين الشحات", 0, null, null, 0, 1, 23, null, null, 3, null, null, 4, null, null, null, 1, null },
                    { 2, null, "أفشة يسجل من ركلة جزاء بعد لمسة يد داخل منطقة الجزاء", 0, null, null, 1, 1, 67, null, null, 2, null, null, null, null, null, null, 1, null },
                    { 3, null, "تدخل عنيف", 2, null, null, null, 1, 55, null, null, 5, null, null, null, null, null, null, 1, null },
                    { 4, null, "تاو يفتتح التسجيل بتسديدة دقيقة", 0, null, null, 0, 7, 15, null, null, 3, null, null, null, null, null, null, 1, null },
                    { 5, null, "الشحات يضاعف النتيجة بعد عمل رائع من تاو", 0, null, null, 0, 7, 29, null, null, 4, null, null, 3, null, null, null, 1, null },
                    { 6, null, "أفشة يسجل من ركلة حرة رائعة", 0, null, null, 2, 7, 58, null, null, 2, null, null, null, null, null, null, 1, null },
                    { 7, null, "تاو يسجل هدفه الثاني في المباراة برأسية قوية", 0, null, null, 0, 7, 77, null, null, 3, null, null, null, null, null, null, 1, null },
                    { 8, null, "زيزو يسجل مباشرة من ركلة حرة", 0, null, null, 2, 2, 15, null, null, 7, null, null, null, null, null, null, 2, null },
                    { 9, null, "هدف التعادل لفيوتشر برأسية من ركلة ركنية", 0, null, null, 0, 2, 38, null, null, null, null, null, null, null, null, null, 5, null },
                    { 10, null, "زيزو يسجل هدف الفوز بعد تمريرة رائعة", 0, null, null, 0, 2, 79, null, null, 7, null, null, null, null, null, null, 2, null },
                    { 11, null, "إبراهيم عادل يتقدم ببيراميدز بهدف فردي رائع", 0, null, null, 0, 8, 35, null, null, 8, null, null, null, null, null, null, 3, null },
                    { 12, null, "زيزو يعادل للزمالك بتسديدة رائعة", 0, null, null, 0, 8, 68, null, null, 7, null, null, null, null, null, null, 2, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MatchEvents",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MatchEvents",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MatchEvents",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MatchEvents",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MatchEvents",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MatchEvents",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MatchEvents",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MatchEvents",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MatchEvents",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MatchEvents",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "MatchEvents",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "MatchEvents",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "MatchId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "MatchId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "MatchId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "MatchId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "MatchId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "MatchId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "MatchId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "MatchId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "MatchId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "MatchId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "MatchId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "MatchId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "SeasonId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "TournamentId",
                keyValue: 1);
        }
    }
}
