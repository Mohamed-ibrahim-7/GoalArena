using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedMatches : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 203);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "Content", "ImageNews", "MatchId", "PublishedDate", "TeamId", "TeamId1", "Title", "playerId" },
                values: new object[,]
                {
                    { 201, "حقق الأهلي فوزًا مثيرًا على الزمالك بنتيجة 2-1 في مباراة قوية ضمن الجولة الماضية من الدوري المصري.", "", 101, new DateTime(2025, 10, 3, 0, 0, 0, 0, DateTimeKind.Local), 1, null, "الأهلي يفوز على الزمالك في قمة مثيرة", 0 },
                    { 202, "يستعد فريق بيراميدز لمواجهة المصري في مباراة متكافئة ضمن منافسات الدوري المصري الممتاز.", "", 102, new DateTime(2025, 10, 4, 0, 0, 0, 0, DateTimeKind.Local), 3, null, "بيراميدز يستعد لمواجهة المصري الليلة", 0 },
                    { 203, "يستضيف الإسماعيلي نظيره الاتحاد السكندري غدًا في مباراة ينتظرها عشاق كرة القدم المصرية.", "", 103, new DateTime(2025, 10, 5, 0, 0, 0, 0, DateTimeKind.Local), 5, null, "الإسماعيلي والاتحاد يتواجهان غدًا في لقاء ناري", 0 }
                });
        }
    }
}
