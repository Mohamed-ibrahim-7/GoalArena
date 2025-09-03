using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddNewPlayers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "FullName", "ImageUrl", "MatchesPlayed", "MinutesPlayed", "Name", "NationalTeam", "Nationality", "Position", "ShirtNumber" },
                values: new object[] { null, "", "/images/players/default.png", 0, 0, "Mohamed El Shenawy", "Egypt", "", "Goalkeeper", null });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 2,
                columns: new[] { "Age", "Assists", "DateOfBirth", "FullName", "Goals", "ImageUrl", "MatchesPlayed", "MinutesPlayed", "Name", "NationalTeam", "Nationality", "Position", "ShirtNumber", "YellowCards" },
                values: new object[] { 24, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mostafa Shobier", "Egypt", "", "Goalkeeper", null, 0 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 3,
                columns: new[] { "Age", "Assists", "DateOfBirth", "FullName", "Goals", "ImageUrl", "MatchesPlayed", "MinutesPlayed", "Name", "NationalTeam", "Nationality", "Position", "ShirtNumber" },
                values: new object[] { 23, 0, null, "", 0, "/images/players/default.png", 0, 0, "Hamza Alaa", "Egypt", "", "Goalkeeper", null });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 4,
                columns: new[] { "Age", "Assists", "DateOfBirth", "FullName", "Goals", "ImageUrl", "MatchesPlayed", "MinutesPlayed", "Name", "NationalTeam", "Nationality", "Position", "ShirtNumber" },
                values: new object[] { 28, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Hany", "Egypt", "", "Defender", null });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 5,
                columns: new[] { "Age", "DateOfBirth", "FullName", "ImageUrl", "MatchesPlayed", "MinutesPlayed", "Name", "NationalTeam", "Nationality", "Position", "ShirtNumber", "YellowCards" },
                values: new object[] { 32, null, "", "/images/players/default.png", 0, 0, "Yasser Ibrahim", "Egypt", "", "Defender", null, 0 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 6,
                columns: new[] { "Age", "DateOfBirth", "FullName", "ImageUrl", "MatchesPlayed", "MinutesPlayed", "Name", "NationalTeam", "Nationality", "Position", "ShirtNumber", "TeamId" },
                values: new object[] { 25, null, "", "/images/players/default.png", 0, 0, "Karim Fouad", "Egypt", "", "Defender", null, 1 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 7,
                columns: new[] { "Age", "DateOfBirth", "FullName", "Goals", "ImageUrl", "MatchesPlayed", "MinutesPlayed", "Name", "NationalTeam", "Nationality", "Position", "ShirtNumber", "TeamId", "YellowCards" },
                values: new object[] { 31, null, "", 0, "/images/players/default.png", 0, 0, "Omar Kamal", "Egypt", "", "Defender", null, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 8,
                columns: new[] { "Age", "DateOfBirth", "FullName", "Goals", "ImageUrl", "MatchesPlayed", "MinutesPlayed", "Name", "NationalTeam", "Nationality", "Position", "ShirtNumber", "TeamId" },
                values: new object[] { 25, null, "", 0, "/images/players/default.png", 0, 0, "Achraf Dari", "Morocco", "", "Defender", null, 1 });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "PlayerId", "Age", "Assists", "DateOfBirth", "FullName", "Goals", "ImageUrl", "MatchesPlayed", "MinutesPlayed", "Name", "NationalTeam", "Nationality", "Position", "RedCards", "SecondaryPosition", "ShirtNumber", "TeamId", "YellowCards" },
                values: new object[,]
                {
                    { 9, 31, 0, null, "", 0, "/images/players/default.png", 0, 0, "Rami Rabia", "Egypt", "", "Defender", 0, null, null, 1, 0 },
                    { 10, 29, 0, null, "", 0, "/images/players/default.png", 0, 0, "Yahya Attiyat Allah", "Morocco", "", "Defender", 0, null, null, 1, 0 },
                    { 11, 32, 0, null, "", 0, "/images/players/default.png", 0, 0, "Hussein El Shahat", "Egypt", "", "Midfielder", 0, null, null, 1, 0 },
                    { 12, 28, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Magdy Afsha", "Egypt", "", "Midfielder", 0, null, null, 1, 0 },
                    { 13, 23, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Nabil Kouka", "Egypt", "", "Midfielder", 0, null, null, 1, 0 },
                    { 14, 26, 0, null, "", 0, "/images/players/default.png", 0, 0, "Marwan Attia", "Egypt", "", "Midfielder", 0, null, null, 1, 0 },
                    { 15, 27, 0, null, "", 0, "/images/players/default.png", 0, 0, "Imam Ashour", "Egypt", "", "Midfielder", 0, null, null, 1, 0 },
                    { 16, 25, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Kendoussi", "Algeria", "", "Midfielder", 0, null, null, 1, 0 },
                    { 17, 27, 0, null, "", 0, "/images/players/default.png", 0, 0, "Akram Tawfik", "Egypt", "", "Midfielder", 0, null, null, 1, 0 },
                    { 18, 27, 0, null, "", 0, "/images/players/default.png", 0, 0, "Taher Mohamed", "Egypt", "", "Forward", 0, null, null, 1, 0 },
                    { 19, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Nejc Gradisar", "Slovenia", "", "Forward", 0, null, null, 1, 0 },
                    { 20, 30, 0, null, "", 0, "/images/players/default.png", 0, 0, "Achraf Bencharki", "Morocco", "", "Forward", 0, null, null, 1, 0 },
                    { 21, 19, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Ali", "Egypt", "", "Forward", 0, null, null, 1, 0 },
                    { 22, 31, 0, null, "", 0, "/images/players/default.png", 0, 0, "Percy Tau", "South Africa", "", "Forward", 0, null, null, 1, 0 },
                    { 23, 31, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mahmoud Kahraba", "Egypt", "", "Forward", 0, null, null, 1, 0 },
                    { 24, 25, 0, null, "", 0, "/images/players/default.png", 0, 0, "Reda Slim", "Morocco", "", "Forward", 0, null, null, 1, 0 },
                    { 25, 26, 0, null, "", 0, "/images/players/default.png", 0, 0, "Wissam Abu Ali", "Palestine", "", "Forward", 0, null, null, 1, 0 },
                    { 26, 17, 0, null, "", 0, "/images/players/default.png", 0, 0, "Hamza Abdelkarim", "Egypt", "", "Forward", 0, null, null, 1, 0 },
                    { 101, 26, 0, null, "", 0, "/images/players/sobhi.png", 0, 0, "Mohamed Sobhi", "Egypt", "", "Goalkeeper", 0, null, null, 3, 0 },
                    { 102, 38, 0, null, "", 0, "/images/players/soliman.png", 0, 0, "El Mahdy Soliman", "Egypt", "", "Goalkeeper", 0, null, null, 3, 0 },
                    { 103, 21, 0, null, "", 0, "/images/players/shenawy.png", 0, 0, "Mahmoud El Shenawy", "Egypt", "", "Goalkeeper", 0, null, null, 3, 0 },
                    { 104, 33, 0, null, "", 0, "/images/players/awad.png", 0, 0, "Mohamed Awad", "Egypt", "", "Goalkeeper", 0, null, null, 3, 0 },
                    { 105, 30, 0, null, "", 0, "/images/players/wensh.png", 0, 0, "Mahmoud Hamdy El Wensh", "Egypt", "", "Defender", 0, null, null, 3, 0 },
                    { 106, 24, 0, null, "", 0, "/images/players/hossam.png", 0, 0, "Hossam Abdelmaguid", "Egypt", "", "Defender", 0, null, null, 3, 0 },
                    { 107, 27, 0, null, "", 0, "/images/players/fattouh.png", 0, 0, "Ahmed Fattouh", "Egypt", "", "Defender", 0, null, null, 3, 0 },
                    { 108, 33, 0, null, "", 0, "/images/players/gaber.png", 0, 0, "Omar Gaber", "Egypt", "", "Defender", 0, null, null, 3, 0 },
                    { 109, 26, 0, null, "", 0, "/images/players/ismail.png", 0, 0, "Mohamed Ismail", "Egypt", "", "Defender", 0, null, null, 3, 0 },
                    { 110, 27, 0, null, "", 0, "/images/players/kerboub.png", 0, 0, "S. Kerboub", "Morocco", "", "Defender", 0, null, null, 3, 0 },
                    { 111, 25, 0, null, "", 0, "/images/players/bentayg.png", 0, 0, "Mohamed Bentayg", "Morocco", "", "Defender", 0, null, null, 3, 0 },
                    { 112, 40, 0, null, "", 0, "/images/players/elsaid.png", 0, 0, "Abdallah El Said", "Egypt", "", "Midfielder", 0, null, null, 3, 0 },
                    { 113, 29, 0, null, "", 0, "/images/players/donga.png", 0, 0, "Nabil Emad Donga", "Egypt", "", "Midfielder", 0, null, null, 3, 0 },
                    { 114, 24, 0, null, "", 0, "/images/players/shehata.png", 0, 0, "Mohamed Shehata", "Egypt", "", "Midfielder", 0, null, null, 3, 0 },
                    { 115, 28, 0, null, "", 0, "/images/players/maher.png", 0, 0, "Nasser Maher", "Egypt", "", "Midfielder", 0, null, null, 3, 0 },
                    { 116, 29, 0, null, "", 0, "/images/players/zizo.png", 0, 0, "Ahmed Sayed Zizo", "Egypt", "", "Forward", 0, null, null, 3, 0 },
                    { 117, 38, 0, null, "", 0, "/images/players/shikabala.png", 0, 0, "Shikabala", "Egypt", "", "Forward", 0, null, null, 3, 0 },
                    { 118, 30, 0, null, "", 0, "/images/players/shalaby.png", 0, 0, "Mostafa Shalaby", "Egypt", "", "Forward", 0, null, null, 3, 0 },
                    { 119, 25, 0, null, "", 0, "/images/players/samson.png", 0, 0, "Samson Akinyoola", "Nigeria", "", "Forward", 0, null, null, 3, 0 },
                    { 200, 26, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Sobhy", "Egypt", "", "Goalkeeper", 0, null, null, 2, 0 },
                    { 201, 38, 0, null, "", 0, "/images/players/default.png", 0, 0, "El Mahdy Soliman", "Egypt", "", "Goalkeeper", 0, null, null, 2, 0 },
                    { 202, 21, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mahmoud El Shenawy", "Egypt", "", "Goalkeeper", 0, null, null, 2, 0 },
                    { 203, 33, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Awad", "Egypt", "", "Goalkeeper", 0, null, null, 2, 0 },
                    { 204, 30, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mahmoud Hamdy El Wensh", "Egypt", "", "Defender", 0, null, null, 2, 0 },
                    { 205, 24, 0, null, "", 0, "/images/players/default.png", 0, 0, "Hossam Abdelmaguid", "Egypt", "", "Defender", 0, null, null, 2, 0 },
                    { 206, 27, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Fattouh", "Egypt", "", "Defender", 0, null, null, 2, 0 },
                    { 207, 23, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Hossam", "Egypt", "", "Defender", 0, null, null, 2, 0 },
                    { 208, 33, 0, null, "", 0, "/images/players/default.png", 0, 0, "Omar Gaber", "Egypt", "", "Defender", 0, null, null, 2, 0 },
                    { 209, 27, 0, null, "", 0, "/images/players/default.png", 0, 0, "Moussaddaq Kerboub", "Morocco", "", "Defender", 0, null, null, 2, 0 },
                    { 210, 26, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Ismail", "Egypt", "", "Defender", 0, null, null, 2, 0 },
                    { 211, 25, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Bentayg", "Morocco", "", "Defender", 0, null, null, 2, 0 },
                    { 212, 27, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Hamdy", "Egypt", "", "Midfielder", 0, null, null, 2, 0 },
                    { 213, 40, 0, null, "", 0, "/images/players/default.png", 0, 0, "Abdallah El Said", "Egypt", "", "Midfielder", 0, null, null, 2, 0 },
                    { 214, 29, 0, null, "", 0, "/images/players/default.png", 0, 0, "Nabil Dunga", "Egypt", "", "Midfielder", 0, null, null, 2, 0 },
                    { 215, 24, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Shehata", "Egypt", "", "Midfielder", 0, null, null, 2, 0 },
                    { 216, 28, 0, null, "", 0, "/images/players/default.png", 0, 0, "Naser Maher", "Egypt", "", "Midfielder", 0, null, null, 2, 0 },
                    { 217, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Abdelrahim", "Egypt", "", "Midfielder", 0, null, null, 2, 0 },
                    { 218, 25, 0, null, "", 0, "/images/players/default.png", 0, 0, "Seif Farouk Gaafar", "Egypt", "", "Midfielder", 0, null, null, 2, 0 },
                    { 219, 24, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Rabie", "Egypt", "", "Midfielder", 0, null, null, 2, 0 },
                    { 220, 19, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed El Sayed", "Egypt", "", "Midfielder", 0, null, null, 2, 0 },
                    { 221, 24, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mahmoud Jihad", "Egypt", "", "Midfielder", 0, null, null, 2, 0 },
                    { 222, 19, 0, null, "", 0, "/images/players/default.png", 0, 0, "A. Maâli", "Morocco", "", "Midfielder", 0, null, null, 2, 0 },
                    { 223, 32, 0, null, "", 0, "/images/players/default.png", 0, 0, "Seifeddine Jaziri", "Tunisia", "", "Forward", 0, null, null, 2, 0 },
                    { 224, 27, 0, null, "", 0, "/images/players/default.png", 0, 0, "Naser Mansi", "Egypt", "", "Forward", 0, null, null, 2, 0 },
                    { 225, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Sherif", "Egypt", "", "Forward", 0, null, null, 2, 0 },
                    { 226, 26, 0, null, "", 0, "/images/players/default.png", 0, 0, "Amr Nasser", "Egypt", "", "Forward", 0, null, null, 2, 0 },
                    { 227, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Juan Alvina", "Brazil", "", "Forward", 0, null, null, 2, 0 },
                    { 228, 26, 0, null, "", 0, "/images/players/default.png", 0, 0, "Oday Dabbagh", "Palestine", "", "Forward", 0, null, null, 2, 0 },
                    { 229, 21, 0, null, "", 0, "/images/players/default.png", 0, 0, "Hazem Ali", "Egypt", "", "Forward", 0, null, null, 2, 0 },
                    { 230, 23, 0, null, "", 0, "/images/players/default.png", 0, 0, "O. Faraj", "Palestine", "", "Forward", 0, null, null, 2, 0 },
                    { 231, 23, 0, null, "", 0, "/images/players/default.png", 0, 0, "A. Kaied", "Palestine", "", "Forward", 0, null, null, 2, 0 },
                    { 232, 26, 0, null, "", 0, "/images/players/default.png", 0, 0, "Chico", "Angola", "", "Forward", 0, null, null, 2, 0 },
                    { 400, 36, 0, null, "", 0, "/images/players/default.png", 0, 0, "Essam Tharwat", "Egypt", "", "Goalkeeper", 0, null, null, 4, 0 },
                    { 401, 26, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Shehata", "Egypt", "", "Goalkeeper", 0, null, null, 4, 0 },
                    { 402, 32, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mahmoud Hamdy", "Egypt", "", "Goalkeeper", 0, null, null, 4, 0 },
                    { 403, 28, 0, null, "", 0, "/images/players/default.png", 0, 0, "Karim Al Iraqi", "Egypt", "", "Defender", 0, null, null, 4, 0 },
                    { 404, 29, 0, null, "", 0, "/images/players/default.png", 0, 0, "Bahr El Mohamady", "Egypt", "", "Defender", 0, null, null, 4, 0 },
                    { 405, 28, 0, null, "", 0, "/images/players/default.png", 0, 0, "Amr El Saadawy", "Egypt", "", "Defender", 0, null, null, 4, 0 },
                    { 406, 31, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Ayman Mansour", "Egypt", "", "Defender", 0, null, null, 4, 0 },
                    { 407, 24, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Eid", "Egypt", "", "Defender", 0, null, null, 4, 0 },
                    { 408, 30, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Hashem", "Egypt", "", "Defender", 0, null, null, 4, 0 },
                    { 409, 30, 0, null, "", 0, "/images/players/default.png", 0, 0, "Khaled Sobhy", "Egypt", "", "Defender", 0, null, null, 4, 0 },
                    { 410, 28, 0, null, "", 0, "/images/players/default.png", 0, 0, "Youssef El Gohary", "Egypt", "", "Midfielder", 0, null, null, 4, 0 },
                    { 411, 28, 0, null, "", 0, "/images/players/default.png", 0, 0, "Hassan Ali", "Egypt", "", "Midfielder", 0, null, null, 4, 0 },
                    { 412, 24, 0, null, "", 0, "/images/players/default.png", 0, 0, "M. Temine", "Algeria", "", "Midfielder", 0, null, null, 4, 0 },
                    { 413, 26, 0, null, "", 0, "/images/players/default.png", 0, 0, "Hussein Faisal", "Egypt", "", "Midfielder", 0, null, null, 4, 0 },
                    { 414, 31, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mahmoud Hamada", "Egypt", "", "Midfielder", 0, null, null, 4, 0 },
                    { 415, 33, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mido Gaber", "Egypt", "", "Midfielder", 0, null, null, 4, 0 },
                    { 416, 25, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Ali", "Egypt", "", "Midfielder", 0, null, null, 4, 0 },
                    { 417, 23, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ziad Farag", "Egypt", "", "Midfielder", 0, null, null, 4, 0 },
                    { 418, 27, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Makhlouf", "Egypt", "", "Midfielder", 0, null, null, 4, 0 },
                    { 419, 32, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed El Karmouty", "Egypt", "", "Midfielder", 0, null, null, 4, 0 },
                    { 420, 21, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mostafa Abu Elkhir", "Egypt", "", "Midfielder", 0, null, null, 4, 0 },
                    { 421, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Omar El Saai", "Egypt", "", "Midfielder", 0, null, null, 4, 0 },
                    { 422, 25, 0, null, "", 0, "/images/players/default.png", 0, 0, "B. Mugisha", "Rwanda", "", "Midfielder", 0, null, null, 4, 0 },
                    { 423, 26, 0, null, "", 0, "/images/players/default.png", 0, 0, "Abdelrahman Dghomoum", "Algeria", "", "Forward", 0, null, null, 4, 0 },
                    { 424, 29, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed El Shamy", "Egypt", "", "Forward", 0, null, null, 4, 0 },
                    { 425, 27, 0, null, "", 0, "/images/players/default.png", 0, 0, "Salah Mohsen", "Egypt", "", "Forward", 0, null, null, 4, 0 },
                    { 426, 20, 0, null, "", 0, "/images/players/default.png", 0, 0, "Lestowell Amankona", "Ghana", "", "Forward", 0, null, null, 4, 0 },
                    { 427, 32, 0, null, "", 0, "/images/players/default.png", 0, 0, "Karim Bambo", "Egypt", "", "Forward", 0, null, null, 4, 0 },
                    { 428, 20, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Sharaf", "Egypt", "", "Forward", 0, null, null, 4, 0 },
                    { 429, 21, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Fouad", "Egypt", "", "Forward", 0, null, null, 4, 0 },
                    { 430, 31, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Sobhi", "Egypt", "", "Goalkeeper", 0, null, null, 5, 0 },
                    { 431, 31, 0, null, "", 0, "/images/players/default.png", 0, 0, "Abdelaziz Belawty", "Egypt", "", "Goalkeeper", 0, null, null, 5, 0 },
                    { 432, 25, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Suleiman", "Egypt", "", "Goalkeeper", 0, null, null, 5, 0 },
                    { 433, 27, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mahmoud Elgazar", "Egypt", "", "Defender", 0, null, null, 5, 0 },
                    { 434, 31, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ishaku Yaqubu", "Ghana", "", "Defender", 0, null, null, 5, 0 },
                    { 435, 27, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mousa Alfarawi", "Palestine", "", "Defender", 0, null, null, 5, 0 },
                    { 436, 34, 0, null, "", 0, "/images/players/default.png", 0, 0, "Amir Medhat", "Egypt", "", "Defender", 0, null, null, 5, 0 },
                    { 437, 29, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Meteb", "Egypt", "", "Defender", 0, null, null, 5, 0 },
                    { 438, 26, 0, null, "", 0, "/images/players/default.png", 0, 0, "Amr El Gazar", "Egypt", "", "Defender", 0, null, null, 5, 0 },
                    { 439, 28, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ramy Hesham", "Egypt", "", "Defender", 0, null, null, 5, 0 },
                    { 440, 31, 0, null, "", 0, "/images/players/default.png", 0, 0, "Khaled Shefo", "Egypt", "", "Defender", 0, null, null, 5, 0 },
                    { 441, 20, 0, null, "", 0, "/images/players/default.png", 0, 0, "Cyrille Dao", "Burkina Faso", "", "Defender", 0, null, null, 5, 0 },
                    { 442, 26, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mostafa Awad", "Egypt", "", "Defender", 0, null, null, 5, 0 },
                    { 443, 27, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mahmoud Emad", "Egypt", "", "Midfielder", 0, null, null, 5, 0 },
                    { 444, 31, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Madbouly", "Egypt", "", "Midfielder", 0, null, null, 5, 0 },
                    { 445, 26, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mostafa Adel", "Egypt", "", "Midfielder", 0, null, null, 5, 0 },
                    { 446, 31, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Mahmoud", "Egypt", "", "Midfielder", 0, null, null, 5, 0 },
                    { 447, 33, 0, null, "", 0, "/images/players/default.png", 0, 0, "Said Simbory", "Burkina Faso", "", "Midfielder", 0, null, null, 5, 0 },
                    { 448, 24, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Ashraf", "Egypt", "", "Midfielder", 0, null, null, 5, 0 },
                    { 449, 33, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Ibrahim", "Egypt", "", "Midfielder", 0, null, null, 5, 0 },
                    { 450, 31, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mostafa Shalaby", "Egypt", "", "Midfielder", 0, null, null, 5, 0 },
                    { 451, 26, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Al Nadry", "Egypt", "", "Forward", 0, null, null, 5, 0 },
                    { 452, 28, 0, null, "", 0, "/images/players/default.png", 0, 0, "Yao Anwar", "Togo", "", "Forward", 0, null, null, 5, 0 },
                    { 453, 24, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mostafa Rahim", "Egypt", "", "Forward", 0, null, null, 5, 0 },
                    { 454, 29, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Amin Qaffa", "Egypt", "", "Forward", 0, null, null, 5, 0 },
                    { 455, 24, 0, null, "", 0, "/images/players/default.png", 0, 0, "Osama Faisal", "Egypt", "", "Forward", 0, null, null, 5, 0 },
                    { 456, 27, 0, null, "", 0, "/images/players/default.png", 0, 0, "Yousri Wahid", "Egypt", "", "Forward", 0, null, null, 5, 0 },
                    { 457, 27, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Yasser Rayan", "Egypt", "", "Forward", 0, null, null, 5, 0 },
                    { 458, 25, 0, null, "", 0, "/images/players/default.png", 0, 0, "Sayed Neymar", "Egypt", "", "Forward", 0, null, null, 5, 0 },
                    { 459, 23, 0, null, "", 0, "/images/players/default.png", 0, 0, "Omar Yassin Dombia", "Guinea", "", "Forward", 0, null, null, 5, 0 },
                    { 460, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Hassan Ahmed", "Egypt", "", "Forward", 0, null, null, 5, 0 },
                    { 461, 35, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Bassam", "Egypt", "", "Goalkeeper", 0, null, null, 6, 0 },
                    { 462, 28, 0, null, "", 0, "/images/players/default.png", 0, 0, "Islam Resha", "Egypt", "", "Goalkeeper", 0, null, null, 6, 0 },
                    { 463, 34, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Koko", "Egypt", "", "Goalkeeper", 0, null, null, 6, 0 },
                    { 464, 26, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Tarek", "Egypt", "", "Goalkeeper", 0, null, null, 6, 0 },
                    { 465, 28, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Hany", "Egypt", "", "Defender", 0, null, null, 6, 0 },
                    { 466, 32, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ragab Nabil", "Egypt", "", "Defender", 0, null, null, 6, 0 },
                    { 467, 24, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed El Maghraby", "Egypt", "", "Defender", 0, null, null, 6, 0 },
                    { 468, 36, 0, null, "", 0, "/images/players/default.png", 0, 0, "Saad Samir", "Egypt", "", "Defender", 0, null, null, 6, 0 },
                    { 469, 34, 0, null, "", 0, "/images/players/default.png", 0, 0, "Hussein El Sayed", "Egypt", "", "Defender", 0, null, null, 6, 0 },
                    { 470, 26, 0, null, "", 0, "/images/players/default.png", 0, 0, "Khaled Abdel Fattah", "Egypt", "", "Defender", 0, null, null, 6, 0 },
                    { 471, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Karim El Debis", "Egypt", "", "Defender", 0, null, null, 6, 0 },
                    { 472, 0, 0, null, "", 0, "/images/players/default.png", 0, 0, "Youssef Gamal", "Egypt", "", "Defender", 0, null, null, 6, 0 },
                    { 473, 30, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Adel", "Egypt", "", "Midfielder", 0, null, null, 6, 0 },
                    { 474, 28, 0, null, "", 0, "/images/players/default.png", 0, 0, "Amr Qalawa", "Egypt", "", "Midfielder", 0, null, null, 6, 0 },
                    { 475, 27, 0, null, "", 0, "/images/players/default.png", 0, 0, "Justice Arthur", "Ghana", "", "Midfielder", 0, null, null, 6, 0 },
                    { 476, 28, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Belhaj", "Morocco", "", "Midfielder", 0, null, null, 6, 0 },
                    { 477, 25, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ibrahim Mohamed", "Egypt", "", "Midfielder", 0, null, null, 6, 0 },
                    { 478, 31, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Samir Mohamed", "Egypt", "", "Midfielder", 0, null, null, 6, 0 },
                    { 479, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Faiz", "Egypt", "", "Midfielder", 0, null, null, 6, 0 },
                    { 480, 28, 0, null, "", 0, "/images/players/default.png", 0, 0, "Abdullah Magdy", "Egypt", "", "Midfielder", 0, null, null, 6, 0 },
                    { 481, 28, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Sadeq", "Egypt", "", "Midfielder", 0, null, null, 6, 0 },
                    { 482, 23, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Reda", "Egypt", "", "Midfielder", 0, null, null, 6, 0 },
                    { 483, 27, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Abou El Amayem", "Egypt", "", "Midfielder", 0, null, null, 6, 0 },
                    { 484, 35, 0, null, "", 0, "/images/players/default.png", 0, 0, "Amr El Solia", "Egypt", "", "Midfielder", 0, null, null, 6, 0 },
                    { 485, 28, 0, null, "", 0, "/images/players/default.png", 0, 0, "Karim Nedved", "Egypt", "", "Midfielder", 0, null, null, 6, 0 },
                    { 486, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Youssef Baour", "Egypt", "", "Midfielder", 0, null, null, 6, 0 },
                    { 487, 28, 0, null, "", 0, "/images/players/default.png", 0, 0, "Fajri Lakay", "South Africa", "", "Forward", 0, null, null, 6, 0 },
                    { 488, 29, 0, null, "", 0, "/images/players/default.png", 0, 0, "Islam Eissa", "Egypt", "", "Forward", 0, null, null, 6, 0 },
                    { 489, 23, 0, null, "", 0, "/images/players/default.png", 0, 0, "Marwan Osman", "Egypt", "", "Forward", 0, null, null, 6, 0 },
                    { 490, 28, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ayman Moka", "Egypt", "", "Forward", 0, null, null, 6, 0 },
                    { 491, 21, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Ashraf", "Egypt", "", "Forward", 0, null, null, 6, 0 },
                    { 492, 25, 0, null, "", 0, "/images/players/default.png", 0, 0, "Sadiq Oguola", "Nigeria", "", "Forward", 0, null, null, 6, 0 }
                });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "Coach", "Colors", "Country", "Founded", "GoalsFor", "LogoUrl", "Name", "Played", "Position", "ShortName", "Stadium", "StadiumCapacity", "Website", "Wins" },
                values: new object[] { null, "TBD", null, null, null, 0, "/images/teams/default.png", "Al Ahly", 0, 0, null, null, null, null, 0 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "Coach", "Colors", "Country", "Draws", "Founded", "GoalsAgainst", "GoalsFor", "LogoUrl", "Name", "Played", "Position", "ShortName", "Stadium", "StadiumCapacity", "Website", "Wins" },
                values: new object[] { null, "TBD", null, null, 0, null, 0, 0, "/images/teams/default.png", "Zamalek SC", 0, 0, null, null, null, null, 0 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "Coach", "Colors", "Country", "Draws", "Founded", "GoalsAgainst", "GoalsFor", "LogoUrl", "Name", "Played", "Position", "ShortName", "Stadium", "StadiumCapacity", "Website", "Wins" },
                values: new object[] { null, "TBD", null, null, 0, null, 0, 0, "/images/teams/default.png", "Pyramids FC", 0, 0, null, null, null, null, 0 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "City", "Coach", "Colors", "Country", "Draws", "Founded", "GoalsAgainst", "GoalsFor", "LogoUrl", "Losses", "Name", "Played", "Position", "ShortName", "Stadium", "StadiumCapacity", "Website", "Wins" },
                values: new object[] { null, "TBD", null, null, 0, null, 0, 0, "/images/teams/default.png", 0, "Al Masry", 0, 0, null, null, null, null, 0 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "City", "Coach", "Colors", "Country", "Founded", "GoalsAgainst", "GoalsFor", "LogoUrl", "Losses", "Name", "Played", "Position", "ShortName", "Stadium", "StadiumCapacity", "Website", "Wins" },
                values: new object[] { null, "TBD", null, null, null, 0, 0, "/images/teams/default.png", 0, "National Bank of Egypt", 0, 0, null, null, null, null, 0 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "City", "Coach", "Colors", "Country", "Founded", "GoalsAgainst", "LogoUrl", "Losses", "Name", "Played", "Position", "ShortName", "Stadium", "StadiumCapacity", "Website" },
                values: new object[] { null, "TBD", null, null, null, 0, "/images/teams/default.png", 0, "Ceramica Cleopatra FC", 0, 0, null, null, null, null });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "City", "Coach", "Colors", "Country", "Draws", "Founded", "GoalsAgainst", "GoalsFor", "LogoUrl", "Losses", "Name", "Played", "Position", "SeasonId", "ShortName", "Stadium", "StadiumCapacity", "Website", "Wins" },
                values: new object[,]
                {
                    { 7, null, "TBD", null, null, 0, null, 0, 0, "/images/teams/default.png", 0, "Pharco FC", 0, 0, 1, null, null, null, null, 0 },
                    { 8, null, "TBD", null, null, 0, null, 0, 0, "/images/teams/default.png", 0, "Petrojet FC", 0, 0, 1, null, null, null, null, 0 },
                    { 9, null, "TBD", null, null, 0, null, 0, 0, "/images/teams/default.png", 0, "Haras El Hodoud", 0, 0, 1, null, null, null, null, 0 },
                    { 10, null, "TBD", null, null, 0, null, 0, 0, "/images/teams/default.png", 0, "ZED FC", 0, 0, 1, null, null, null, null, 0 },
                    { 11, null, "TBD", null, null, 0, null, 0, 0, "/images/teams/default.png", 0, "El Gouna FC", 0, 0, 1, null, null, null, null, 0 },
                    { 12, null, "TBD", null, null, 0, null, 0, 0, "/images/teams/default.png", 0, "Tala'ea El Gaish", 0, 0, 1, null, null, null, null, 0 },
                    { 13, null, "TBD", null, null, 0, null, 0, 0, "/images/teams/default.png", 0, "ENPPI", 0, 0, 1, null, null, null, null, 0 },
                    { 14, null, "TBD", null, null, 0, null, 0, 0, "/images/teams/default.png", 0, "Al Ittihad Alexandria", 0, 0, 1, null, null, null, null, 0 },
                    { 15, null, "TBD", null, null, 0, null, 0, 0, "/images/teams/default.png", 0, "Modern Sport", 0, 0, 1, null, null, null, null, 0 },
                    { 16, null, "TBD", null, null, 0, null, 0, 0, "/images/teams/default.png", 0, "Smouha SC", 0, 0, 1, null, null, null, null, 0 },
                    { 17, null, "TBD", null, null, 0, null, 0, 0, "/images/teams/default.png", 0, "Ismaily SC", 0, 0, 1, null, null, null, null, 0 },
                    { 18, null, "TBD", null, null, 0, null, 0, 0, "/images/teams/default.png", 0, "Ghazl El Mahalla", 0, 0, 1, null, null, null, null, 0 },
                    { 19, null, "TBD", null, null, 0, null, 0, 0, "/images/teams/default.png", 0, "Al Mokawloon Al Arab", 0, 0, 1, null, null, null, null, 0 },
                    { 20, null, "TBD", null, null, 0, null, 0, 0, "/images/teams/default.png", 0, "Wadi Degla", 0, 0, 1, null, null, null, null, 0 },
                    { 21, null, "TBD", null, null, 0, null, 0, 0, "/images/teams/default.png", 0, "Kahrabaa Ismailia", 0, 0, 1, null, null, null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "PlayerId", "Age", "Assists", "DateOfBirth", "FullName", "Goals", "ImageUrl", "MatchesPlayed", "MinutesPlayed", "Name", "NationalTeam", "Nationality", "Position", "RedCards", "SecondaryPosition", "ShirtNumber", "TeamId", "YellowCards" },
                values: new object[,]
                {
                    { 493, 32, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Saeed Shika", "Egypt", "", "Goalkeeper", 0, null, null, 7, 0 },
                    { 494, 23, 0, null, "", 0, "/images/players/default.png", 0, 0, "Sabry Gad", "Egypt", "", "Goalkeeper", 0, null, null, 7, 0 },
                    { 495, 24, 0, null, "", 0, "/images/players/default.png", 0, 0, "Fares El Sayed", "Egypt", "", "Goalkeeper", 0, null, null, 7, 0 },
                    { 496, 24, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Nadim", "Egypt", "", "Goalkeeper", 0, null, null, 7, 0 },
                    { 497, 27, 0, null, "", 0, "/images/players/default.png", 0, 0, "Azmi Ghouma", "Tunisia", "", "Defender", 0, null, null, 7, 0 },
                    { 498, 38, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ramy Sabry", "Egypt", "", "Defender", 0, null, null, 7, 0 },
                    { 499, 30, 0, null, "", 0, "/images/players/default.png", 0, 0, "Gaber Kamel", "Egypt", "", "Defender", 0, null, null, 7, 0 },
                    { 500, 30, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed El Bahrawy", "Egypt", "", "Defender", 0, null, null, 7, 0 },
                    { 501, 24, 0, null, "", 0, "/images/players/default.png", 0, 0, "Yassin Marei", "Egypt", "", "Defender", 0, null, null, 7, 0 },
                    { 502, 34, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mahmoud El Badry", "Egypt", "", "Defender", 0, null, null, 7, 0 },
                    { 503, 21, 0, null, "", 0, "/images/players/default.png", 0, 0, "Babacar Ndiaye", "Senegal", "", "Defender", 0, null, null, 7, 0 },
                    { 504, 31, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Gamal", "Egypt", "", "Defender", 0, null, null, 7, 0 },
                    { 505, 0, 0, null, "", 0, "/images/players/default.png", 0, 0, "Yassin El Mallah", "Egypt", "", "Defender", 0, null, null, 7, 0 },
                    { 506, 21, 0, null, "", 0, "/images/players/default.png", 0, 0, "Seif Emam", "Egypt", "", "Defender", 0, null, null, 7, 0 },
                    { 507, 26, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Fouad", "Egypt", "", "Midfielder", 0, null, null, 7, 0 },
                    { 508, 26, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Fakhry", "Egypt", "", "Midfielder", 0, null, null, 7, 0 },
                    { 509, 23, 0, null, "", 0, "/images/players/default.png", 0, 0, "Enock Benjamin Tola", "Angola", "", "Midfielder", 0, null, null, 7, 0 },
                    { 510, 24, 0, null, "", 0, "/images/players/default.png", 0, 0, "Abdellrhman Al Ashry", "Egypt", "", "Midfielder", 0, null, null, 7, 0 },
                    { 511, 27, 0, null, "", 0, "/images/players/default.png", 0, 0, "Khalil Neymar Haggi", "Egypt", "", "Midfielder", 0, null, null, 7, 0 },
                    { 512, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mahmoud Farahat", "Egypt", "", "Midfielder", 0, null, null, 7, 0 },
                    { 513, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mazen Adel", "Egypt", "", "Midfielder", 0, null, null, 7, 0 },
                    { 514, 25, 0, null, "", 0, "/images/players/default.png", 0, 0, "Walid Mostafa", "Egypt", "", "Forward", 0, null, null, 7, 0 },
                    { 515, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Salah Basha", "Egypt", "", "Forward", 0, null, null, 7, 0 },
                    { 516, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Ezz", "Egypt", "", "Forward", 0, null, null, 7, 0 },
                    { 517, 24, 0, null, "", 0, "/images/players/default.png", 0, 0, "Seif El Deen Rafik", "Egypt", "", "Forward", 0, null, null, 7, 0 },
                    { 518, 29, 0, null, "", 0, "/images/players/default.png", 0, 0, "Zed El Matraji", "Morocco", "", "Forward", 0, null, null, 7, 0 },
                    { 519, 24, 0, null, "", 0, "/images/players/default.png", 0, 0, "Zeyad Tolba", "Egypt", "", "Forward", 0, null, null, 7, 0 },
                    { 520, 31, 0, null, "", 0, "/images/players/default.png", 0, 0, "Seif El Din Malik Bakhit", "Sudan", "", "Forward", 0, null, null, 7, 0 },
                    { 521, 30, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ragab Abdelkafi", "Egypt", "", "Goalkeeper", 0, null, null, 8, 0 },
                    { 522, 27, 0, null, "", 0, "/images/players/default.png", 0, 0, "Omar Mohamed", "Egypt", "", "Goalkeeper", 0, null, null, 8, 0 },
                    { 523, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Khalifa", "Egypt", "", "Goalkeeper", 0, null, null, 8, 0 },
                    { 524, 34, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mahmoud Shedid", "Egypt", "", "Defender", 0, null, null, 8, 0 },
                    { 525, 27, 0, null, "", 0, "/images/players/default.png", 0, 0, "Hadi Riyad", "Egypt", "", "Defender", 0, null, null, 8, 0 },
                    { 526, 32, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Bahbah", "Egypt", "", "Defender", 0, null, null, 8, 0 },
                    { 527, 28, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Yassin", "Egypt", "", "Defender", 0, null, null, 8, 0 },
                    { 528, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Islam Abdallah", "Egypt", "", "Defender", 0, null, null, 8, 0 },
                    { 529, 26, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Ghoneim", "Egypt", "", "Defender", 0, null, null, 8, 0 },
                    { 530, 31, 0, null, "", 0, "/images/players/default.png", 0, 0, "Momen Atef", "Egypt", "", "Defender", 0, null, null, 8, 0 },
                    { 531, 28, 0, null, "", 0, "/images/players/default.png", 0, 0, "Barakat Haggag", "Egypt", "", "Defender", 0, null, null, 8, 0 },
                    { 532, 0, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mahmoud Morsi", "Egypt", "", "Defender", 0, null, null, 8, 0 },
                    { 533, 28, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mostafa El Gamal", "Egypt", "", "Midfielder", 0, null, null, 8, 0 },
                    { 534, 27, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Osman", "Egypt", "", "Midfielder", 0, null, null, 8, 0 },
                    { 535, 25, 0, null, "", 0, "/images/players/default.png", 0, 0, "Adham Hamed", "Egypt", "", "Midfielder", 0, null, null, 8, 0 },
                    { 536, 25, 0, null, "", 0, "/images/players/default.png", 0, 0, "Hamed Hamdan", "Palestine", "", "Midfielder", 0, null, null, 8, 0 },
                    { 537, 21, 0, null, "", 0, "/images/players/default.png", 0, 0, "Amadou Bah", "Guinea", "", "Midfielder", 0, null, null, 8, 0 },
                    { 538, 27, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mostafa El Badry", "Egypt", "", "Midfielder", 0, null, null, 8, 0 },
                    { 539, 26, 0, null, "", 0, "/images/players/default.png", 0, 0, "Badr Youssef", "Palestine", "", "Forward", 0, null, null, 8, 0 },
                    { 540, 25, 0, null, "", 0, "/images/players/default.png", 0, 0, "Rashid Ahmed", "Nigeria", "", "Forward", 0, null, null, 8, 0 },
                    { 541, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Jibril Shikodi", "Nigeria", "", "Forward", 0, null, null, 8, 0 },
                    { 542, 26, 0, null, "", 0, "/images/players/default.png", 0, 0, "Tawfik Mohamed", "Egypt", "", "Forward", 0, null, null, 8, 0 },
                    { 543, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Ibrahim Dodo", "Egypt", "", "Forward", 0, null, null, 8, 0 },
                    { 544, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Omar Reda", "Egypt", "", "Forward", 0, null, null, 8, 0 },
                    { 545, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Samir Mohamed", "Egypt", "", "Forward", 0, null, null, 8, 0 },
                    { 546, 28, 0, null, "", 0, "/images/players/default.png", 0, 0, "Aiman Orabi", "Egypt", "", "Goalkeeper", 0, null, null, 9, 0 },
                    { 547, 33, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mahmoud El Zenfaly", "Egypt", "", "Goalkeeper", 0, null, null, 9, 0 },
                    { 548, 32, 0, null, "", 0, "/images/players/default.png", 0, 0, "Amr Shaaban", "Egypt", "", "Goalkeeper", 0, null, null, 9, 0 },
                    { 549, 0, 0, null, "", 0, "/images/players/default.png", 0, 0, "Adham Seha", "Egypt", "", "Goalkeeper", 0, null, null, 9, 0 },
                    { 550, 32, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ehab Samir", "Egypt", "", "Defender", 0, null, null, 9, 0 },
                    { 551, 24, 0, null, "", 0, "/images/players/default.png", 0, 0, "Momen Awad", "Egypt", "", "Defender", 0, null, null, 9, 0 },
                    { 552, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ibrahim Abdel Hakeem", "Egypt", "", "Defender", 0, null, null, 9, 0 },
                    { 553, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Youssef Atef", "Egypt", "", "Defender", 0, null, null, 9, 0 },
                    { 554, 30, 0, null, "", 0, "/images/players/default.png", 0, 0, "Kwasi Kwadja", "Côte dIvoire", "", "Defender", 0, null, null, 9, 0 },
                    { 555, 28, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Abd El Salam", "Egypt", "", "Defender", 0, null, null, 9, 0 },
                    { 556, 20, 0, null, "", 0, "/images/players/default.png", 0, 0, "Moataz El Sayed", "Egypt", "", "Defender", 0, null, null, 9, 0 },
                    { 557, 26, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mahmoud El Badry", "Egypt", "", "Defender", 0, null, null, 9, 0 },
                    { 558, 31, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Magly", "Egypt", "", "Midfielder", 0, null, null, 9, 0 },
                    { 559, 33, 0, null, "", 0, "/images/players/default.png", 0, 0, "Easy Emika", "Nigeria", "", "Midfielder", 0, null, null, 9, 0 },
                    { 560, 35, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Gaber", "Egypt", "", "Midfielder", 0, null, null, 9, 0 },
                    { 561, 25, 0, null, "", 0, "/images/players/default.png", 0, 0, "A Oubeid", "Mauritania", "", "Midfielder", 0, null, null, 9, 0 },
                    { 562, 25, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Bayoumi", "Egypt", "", "Midfielder", 0, null, null, 9, 0 },
                    { 563, 31, 0, null, "", 0, "/images/players/default.png", 0, 0, "Omar Fathy Saviola", "Egypt", "", "Midfielder", 0, null, null, 9, 0 },
                    { 564, 26, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ismail Ashraf", "Egypt", "", "Midfielder", 0, null, null, 9, 0 },
                    { 565, 32, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed El Daghimi", "Egypt", "", "Midfielder", 0, null, null, 9, 0 },
                    { 566, 32, 0, null, "", 0, "/images/players/default.png", 0, 0, "Islam Abu Salema", "Egypt", "", "Midfielder", 0, null, null, 9, 0 },
                    { 567, 27, 0, null, "", 0, "/images/players/default.png", 0, 0, "Fawzi El Hanawy", "Egypt", "", "Midfielder", 0, null, null, 9, 0 },
                    { 568, 32, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Ashraf Rouka", "Egypt", "", "Midfielder", 0, null, null, 9, 0 },
                    { 569, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mahmoud Said Oka", "Egypt", "", "Midfielder", 0, null, null, 9, 0 },
                    { 570, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Badr El Sayed", "Egypt", "", "Midfielder", 0, null, null, 9, 0 },
                    { 571, 35, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed El Sheikh", "Egypt", "", "Midfielder", 0, null, null, 9, 0 },
                    { 572, 27, 0, null, "", 0, "/images/players/default.png", 0, 0, "N Ikechukwu", "Nigeria", "", "Forward", 0, null, null, 9, 0 },
                    { 573, 34, 0, null, "", 0, "/images/players/default.png", 0, 0, "Amr Gamal", "Egypt", "", "Forward", 0, null, null, 9, 0 },
                    { 574, 23, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Mostafa", "Egypt", "", "Forward", 0, null, null, 9, 0 },
                    { 575, 36, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Farouk", "Egypt", "", "Forward", 0, null, null, 9, 0 },
                    { 576, 20, 0, null, "", 0, "/images/players/default.png", 0, 0, "Damilola Emmanuel", "Nigeria", "", "Forward", 0, null, null, 9, 0 },
                    { 578, 35, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ali Lotfi", "Egypt", "", "Goalkeeper", 0, null, null, 10, 0 },
                    { 579, 30, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Mezika", "Egypt", "", "Goalkeeper", 0, null, null, 10, 0 },
                    { 580, 19, 0, null, "", 0, "/images/players/default.png", 0, 0, "Abdelmonem Tamer", "Egypt", "", "Goalkeeper", 0, null, null, 10, 0 },
                    { 581, 25, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ali Gamal", "Egypt", "", "Defender", 0, null, null, 10, 0 },
                    { 582, 34, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Tarek", "Egypt", "", "Defender", 0, null, null, 10, 0 },
                    { 583, 27, 0, null, "", 0, "/images/players/default.png", 0, 0, "Sameh Ibrahim", "Egypt", "", "Defender", 0, null, null, 10, 0 },
                    { 584, 36, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Samir", "Egypt", "", "Defender", 0, null, null, 10, 0 },
                    { 585, 21, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed El Sayed Abdel Nabi", "Egypt", "", "Defender", 0, null, null, 10, 0 },
                    { 586, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Ashraf", "Egypt", "", "Defender", 0, null, null, 10, 0 },
                    { 587, 23, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mostafa El Esh", "Egypt", "", "Defender", 0, null, null, 10, 0 },
                    { 588, 25, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Zaki", "Egypt", "", "Defender", 0, null, null, 10, 0 },
                    { 589, 25, 0, null, "", 0, "/images/players/default.png", 0, 0, "Abdelrahman Emad", "Egypt", "", "Midfielder", 0, null, null, 10, 0 },
                    { 590, 26, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Soghairi", "Egypt", "", "Midfielder", 0, null, null, 10, 0 },
                    { 591, 26, 0, null, "", 0, "/images/players/default.png", 0, 0, "Peter Zelo Motomusi", "DR Congo", "", "Midfielder", 0, null, null, 10, 0 },
                    { 592, 23, 0, null, "", 0, "/images/players/default.png", 0, 0, "Hamdy Abdel Maati", "Egypt", "", "Midfielder", 0, null, null, 10, 0 },
                    { 593, 20, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Suanieh", "Gambia", "", "Midfielder", 0, null, null, 10, 0 },
                    { 594, 20, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mata Majasa", "Mauritania", "", "Midfielder", 0, null, null, 10, 0 },
                    { 595, 25, 0, null, "", 0, "/images/players/default.png", 0, 0, "Amar Hamdy", "Egypt", "", "Midfielder", 0, null, null, 10, 0 },
                    { 596, 26, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mahmoud Nabil", "Egypt", "", "Midfielder", 0, null, null, 10, 0 },
                    { 597, 33, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Hamdy", "Egypt", "", "Midfielder", 0, null, null, 10, 0 },
                    { 598, 32, 0, null, "", 0, "/images/players/default.png", 0, 0, "Abdel Hameed Ahmed", "Egypt", "", "Midfielder", 0, null, null, 10, 0 },
                    { 599, 31, 0, null, "", 0, "/images/players/default.png", 0, 0, "Marwan Mahmoud", "Egypt", "", "Midfielder", 0, null, null, 10, 0 },
                    { 600, 25, 0, null, "", 0, "/images/players/default.png", 0, 0, "Y Rafael", "Rwanda", "", "Forward", 0, null, null, 10, 0 },
                    { 601, 27, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Adel", "Egypt", "", "Forward", 0, null, null, 10, 0 },
                    { 602, 28, 0, null, "", 0, "/images/players/default.png", 0, 0, "Abel Yalo", "Ethiopia", "", "Forward", 0, null, null, 10, 0 },
                    { 603, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mostafa Saad Messi", "Egypt", "", "Forward", 0, null, null, 10, 0 },
                    { 604, 30, 0, null, "", 0, "/images/players/default.png", 0, 0, "Shady Hussein", "Egypt", "", "Forward", 0, null, null, 10, 0 },
                    { 605, 23, 0, null, "", 0, "/images/players/default.png", 0, 0, "Abdelrahman El Banoubi", "Egypt", "", "Forward", 0, null, null, 10, 0 },
                    { 606, 23, 0, null, "", 0, "/images/players/default.png", 0, 0, "Omar Amin", "Egypt", "", "Forward", 0, null, null, 10, 0 },
                    { 607, 23, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohsni Malima", "Tanzania", "", "Forward", 0, null, null, 10, 0 },
                    { 608, 32, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Masoud", "Egypt", "", "Goalkeeper", 0, null, null, 11, 0 },
                    { 609, 24, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Alaa", "Egypt", "", "Goalkeeper", 0, null, null, 11, 0 },
                    { 610, 30, 0, null, "", 0, "/images/players/default.png", 0, 0, "Hassan Mahmoud", "Egypt", "", "Goalkeeper", 0, null, null, 11, 0 },
                    { 611, 25, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed El Esh", "Egypt", "", "Defender", 0, null, null, 11, 0 },
                    { 612, 28, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Abd El Rasoul", "Egypt", "", "Defender", 0, null, null, 11, 0 },
                    { 613, 28, 0, null, "", 0, "/images/players/default.png", 0, 0, "Aliou Gatta", "Gambia", "", "Defender", 0, null, null, 11, 0 },
                    { 614, 30, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Shosha", "Egypt", "", "Defender", 0, null, null, 11, 0 },
                    { 615, 21, 0, null, "", 0, "/images/players/default.png", 0, 0, "Abdelgawad Taleb", "Egypt", "", "Defender", 0, null, null, 11, 0 },
                    { 616, 39, 0, null, "", 0, "/images/players/default.png", 0, 0, "Noor El Sayed", "Egypt", "", "Midfielder", 0, null, null, 11, 0 },
                    { 617, 25, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Mahmoud", "Egypt", "", "Midfielder", 0, null, null, 11, 0 },
                    { 618, 26, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mahmoud Hassouna", "Egypt", "", "Midfielder", 0, null, null, 11, 0 },
                    { 619, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Emad", "Egypt", "", "Midfielder", 0, null, null, 11, 0 },
                    { 620, 23, 0, null, "", 0, "/images/players/default.png", 0, 0, "Bilal El Sayed", "Egypt", "", "Midfielder", 0, null, null, 11, 0 },
                    { 621, 25, 0, null, "", 0, "/images/players/default.png", 0, 0, "Reda Salah", "Egypt", "", "Midfielder", 0, null, null, 11, 0 },
                    { 622, 27, 0, null, "", 0, "/images/players/default.png", 0, 0, "Hassan Yassin", "Egypt", "", "Midfielder", 0, null, null, 11, 0 },
                    { 623, 28, 0, null, "", 0, "/images/players/default.png", 0, 0, "S Kabir", "Nigeria", "", "Midfielder", 0, null, null, 11, 0 },
                    { 624, 20, 0, null, "", 0, "/images/players/default.png", 0, 0, "O Okoronkwo", "Nigeria", "", "Midfielder", 0, null, null, 11, 0 },
                    { 625, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Dominic Nsobila", "Ghana", "", "Midfielder", 0, null, null, 11, 0 },
                    { 626, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Arnaud Randrianantena", "Madagascar", "", "Forward", 0, null, null, 11, 0 },
                    { 627, 21, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed El Nahas", "Egypt", "", "Forward", 0, null, null, 11, 0 },
                    { 628, 24, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mahmoud Ouksha", "Egypt", "", "Forward", 0, null, null, 11, 0 },
                    { 629, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Seif Shika", "Egypt", "", "Forward", 0, null, null, 11, 0 },
                    { 630, 20, 0, null, "", 0, "/images/players/default.png", 0, 0, "Samuel Ojo", "Nigeria", "", "Forward", 0, null, null, 11, 0 },
                    { 631, 27, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ali El Zahabi", "Egypt", "", "Forward", 0, null, null, 11, 0 },
                    { 632, 20, 0, null, "", 0, "/images/players/default.png", 0, 0, "T Oripelaye", "Nigeria", "", "Forward", 0, null, null, 11, 0 },
                    { 633, 34, 0, null, "", 0, "/images/players/default.png", 0, 0, "Marwan Mohsen", "Egypt", "", "Forward", 0, null, null, 11, 0 },
                    { 634, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mahmoud El Aaalamy", "Egypt", "", "Forward", 0, null, null, 11, 0 },
                    { 635, 29, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Yassin", "France", "", "Forward", 0, null, null, 11, 0 },
                    { 636, 20, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mazen Yasser", "Egypt", "", "Forward", 0, null, null, 11, 0 },
                    { 637, 26, 0, null, "", 0, "/images/players/default.png", 0, 0, "Omar Radwan", "Egypt", "", "Goalkeeper", 0, null, null, 12, 0 },
                    { 638, 29, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Shaaban", "Egypt", "", "Goalkeeper", 0, null, null, 12, 0 },
                    { 639, 28, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Magdy Abd El Fattah", "Egypt", "", "Goalkeeper", 0, null, null, 12, 0 },
                    { 640, 37, 0, null, "", 0, "/images/players/default.png", 0, 0, "Emad El Sayed", "Egypt", "", "Goalkeeper", 0, null, null, 12, 0 },
                    { 641, 21, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Abass", "Egypt", "", "Goalkeeper", 0, null, null, 12, 0 },
                    { 642, 34, 0, null, "", 0, "/images/players/default.png", 0, 0, "Khaled Satouhi", "Egypt", "", "Defender", 0, null, null, 12, 0 },
                    { 643, 31, 0, null, "", 0, "/images/players/default.png", 0, 0, "Amr Tarek", "Egypt", "", "Defender", 0, null, null, 12, 0 },
                    { 644, 21, 0, null, "", 0, "/images/players/default.png", 0, 0, "Moamen Mahmoud", "Egypt", "", "Defender", 0, null, null, 12, 0 },
                    { 645, 30, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Fathallah", "Egypt", "", "Defender", 0, null, null, 12, 0 },
                    { 646, 29, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Ala El Din", "Egypt", "", "Defender", 0, null, null, 12, 0 },
                    { 647, 21, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mahmoud Abdel Aziz", "Egypt", "", "Defender", 0, null, null, 12, 0 },
                    { 648, 21, 0, null, "", 0, "/images/players/default.png", 0, 0, "A Keita", "Guinea", "", "Defender", 0, null, null, 12, 0 },
                    { 649, 32, 0, null, "", 0, "/images/players/default.png", 0, 0, "Hassan Magdy", "Egypt", "", "Midfielder", 0, null, null, 12, 0 },
                    { 650, 30, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Abd El Rahman Zola", "Egypt", "", "Midfielder", 0, null, null, 12, 0 },
                    { 651, 24, 0, null, "", 0, "/images/players/default.png", 0, 0, "Hamed Khaled", "Egypt", "", "Midfielder", 0, null, null, 12, 0 },
                    { 652, 30, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mostafa El Khawaga", "Egypt", "", "Midfielder", 0, null, null, 12, 0 },
                    { 653, 21, 0, null, "", 0, "/images/players/default.png", 0, 0, "Khaled Mohamed Awad", "Egypt", "", "Midfielder", 0, null, null, 12, 0 },
                    { 654, 32, 0, null, "", 0, "/images/players/default.png", 0, 0, "Islam Mohareb", "Egypt", "", "Midfielder", 0, null, null, 12, 0 },
                    { 655, 24, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ali Hamdy", "Egypt", "", "Midfielder", 0, null, null, 12, 0 },
                    { 656, 30, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ragab Omran", "Egypt", "", "Midfielder", 0, null, null, 12, 0 },
                    { 657, 24, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Tarek", "Egypt", "", "Midfielder", 0, null, null, 12, 0 },
                    { 658, 24, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ghaith Al Madadha", "Egypt", "", "Midfielder", 0, null, null, 12, 0 },
                    { 659, 25, 0, null, "", 0, "/images/players/default.png", 0, 0, "H Souissi", "Tunisia", "", "Midfielder", 0, null, null, 12, 0 },
                    { 660, 31, 0, null, "", 0, "/images/players/default.png", 0, 0, "Karim Tarek", "Egypt", "", "Forward", 0, null, null, 12, 0 },
                    { 661, 26, 0, null, "", 0, "/images/players/default.png", 0, 0, "Delson Kamoni", "Angola", "", "Forward", 0, null, null, 12, 0 },
                    { 662, 21, 0, null, "", 0, "/images/players/default.png", 0, 0, "Fares Hatem", "Egypt", "", "Forward", 0, null, null, 12, 0 },
                    { 663, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Hany", "Egypt", "", "Forward", 0, null, null, 12, 0 },
                    { 664, 31, 0, null, "", 0, "/images/players/default.png", 0, 0, "Khaled Abo Ziada", "Egypt", "", "Forward", 0, null, null, 12, 0 },
                    { 665, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Basiouny", "Egypt", "", "Forward", 0, null, null, 12, 0 },
                    { 666, 28, 0, null, "", 0, "/images/players/default.png", 0, 0, "I Ouro Agoro", "Togo", "", "Forward", 0, null, null, 12, 0 },
                    { 667, 21, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Atef", "Egypt", "", "Forward", 0, null, null, 12, 0 },
                    { 668, 25, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ramadan Mostafa", "Egypt", "", "Goalkeeper", 0, null, null, 13, 0 },
                    { 669, 24, 0, null, "", 0, "/images/players/default.png", 0, 0, "Abdel Rahman Samir", "Egypt", "", "Goalkeeper", 0, null, null, 13, 0 },
                    { 670, 36, 0, null, "", 0, "/images/players/default.png", 0, 0, "Reda Sayed", "Egypt", "", "Goalkeeper", 0, null, null, 13, 0 },
                    { 671, 26, 0, null, "", 0, "/images/players/default.png", 0, 0, "Hesham Adel", "Egypt", "", "Defender", 0, null, null, 13, 0 },
                    { 672, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Samir", "Egypt", "", "Defender", 0, null, null, 13, 0 },
                    { 673, 24, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Sobeha", "Egypt", "", "Defender", 0, null, null, 13, 0 },
                    { 674, 25, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Khalil Ibrahim", "Egypt", "", "Defender", 0, null, null, 13, 0 },
                    { 675, 26, 0, null, "", 0, "/images/players/default.png", 0, 0, "Hazem Ibrahim", "Egypt", "", "Defender", 0, null, null, 13, 0 },
                    { 676, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Abdullah Adel", "Egypt", "", "Defender", 0, null, null, 13, 0 },
                    { 677, 17, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Samir", "Egypt", "", "Defender", 0, null, null, 13, 0 },
                    { 678, 21, 0, null, "", 0, "/images/players/default.png", 0, 0, "Fathi El Sayed", "Egypt", "", "Defender", 0, null, null, 13, 0 },
                    { 679, 20, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Hamdy", "Egypt", "", "Defender", 0, null, null, 13, 0 },
                    { 680, 26, 0, null, "", 0, "/images/players/default.png", 0, 0, "Marwan Dawood", "Egypt", "", "Defender", 0, null, null, 13, 0 },
                    { 681, 30, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed El Agoz", "Egypt", "", "Midfielder", 0, null, null, 13, 0 },
                    { 682, 23, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mostafa Shakshak", "Egypt", "", "Midfielder", 0, null, null, 13, 0 },
                    { 683, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Nasser", "Egypt", "", "Midfielder", 0, null, null, 13, 0 },
                    { 684, 18, 0, null, "", 0, "/images/players/default.png", 0, 0, "Youssef Adel", "Egypt", "", "Midfielder", 0, null, null, 13, 0 },
                    { 685, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Emad", "Egypt", "", "Midfielder", 0, null, null, 13, 0 },
                    { 686, 18, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ali Mahmoud", "Egypt", "", "Midfielder", 0, null, null, 13, 0 },
                    { 687, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ziad Kamal", "Egypt", "", "Midfielder", 0, null, null, 13, 0 },
                    { 688, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Sayed Said", "Egypt", "", "Midfielder", 0, null, null, 13, 0 },
                    { 689, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Ismail Kofta", "Egypt", "", "Midfielder", 0, null, null, 13, 0 },
                    { 690, 31, 0, null, "", 0, "/images/players/default.png", 0, 0, "Rafiq Kabo", "Tunisia", "", "Forward", 0, null, null, 13, 0 },
                    { 691, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Youssef Labib", "Egypt", "", "Forward", 0, null, null, 13, 0 },
                    { 692, 23, 0, null, "", 0, "/images/players/default.png", 0, 0, "Salah Zayed", "Egypt", "", "Forward", 0, null, null, 13, 0 },
                    { 693, 20, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Nader Hawash", "Egypt", "", "Forward", 0, null, null, 13, 0 },
                    { 694, 25, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Sherif", "Egypt", "", "Forward", 0, null, null, 13, 0 },
                    { 695, 28, 0, null, "", 0, "/images/players/default.png", 0, 0, "Y Oubaba", "Morocco", "", "Forward", 0, null, null, 13, 0 },
                    { 696, 20, 0, null, "", 0, "/images/players/default.png", 0, 0, "Youssef Ahmed Hassan", "Egypt", "", "Forward", 0, null, null, 13, 0 },
                    { 697, 27, 0, null, "", 0, "/images/players/default.png", 0, 0, "Abdul Mudasiru", "Ghana", "", "Forward", 0, null, null, 13, 0 },
                    { 698, 19, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ali Ehab", "Egypt", "", "Forward", 0, null, null, 13, 0 },
                    { 699, 25, 0, null, "", 0, "/images/players/default.png", 0, 0, "T Randrianarijaona", "Madagascar", "", "Forward", 0, null, null, 13, 0 },
                    { 700, 25, 0, null, "", 0, "/images/players/default.png", 0, 0, "Hossam Ghanem", "Egypt", "", "Forward", 0, null, null, 13, 0 },
                    { 701, 21, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Zaki", "Egypt", "", "Forward", 0, null, null, 13, 0 },
                    { 702, 20, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Walid Gedo", "Egypt", "", "Forward", 0, null, null, 13, 0 },
                    { 703, 21, 0, null, "", 0, "/images/players/default.png", 0, 0, "Hamed Abdallah", "Egypt", "", "Forward", 0, null, null, 13, 0 },
                    { 704, 20, 0, null, "", 0, "/images/players/default.png", 0, 0, "Adel Fadaly", "Egypt", "", "Forward", 0, null, null, 13, 0 },
                    { 705, 36, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mahmoud Gennesh", "Egypt", "", "Goalkeeper", 0, null, null, 14, 0 },
                    { 706, 25, 0, null, "", 0, "/images/players/default.png", 0, 0, "Sobhy Suleiman", "Egypt", "", "Goalkeeper", 0, null, null, 14, 0 },
                    { 707, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Youssef Nader El Shazly", "Egypt", "", "Goalkeeper", 0, null, null, 14, 0 },
                    { 708, 23, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mostafa Ibrahim", "Egypt", "", "Defender", 0, null, null, 14, 0 },
                    { 709, 28, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mahmoud Shabana", "Egypt", "", "Defender", 0, null, null, 14, 0 },
                    { 710, 28, 0, null, "", 0, "/images/players/default.png", 0, 0, "Karim El Deeb", "Egypt", "", "Defender", 0, null, null, 14, 0 },
                    { 711, 32, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mahmoud Alaa El Din", "Egypt", "", "Defender", 0, null, null, 14, 0 },
                    { 712, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Sami", "Egypt", "", "Defender", 0, null, null, 14, 0 },
                    { 713, 17, 0, null, "", 0, "/images/players/default.png", 0, 0, "Momen Sherif", "Egypt", "", "Defender", 0, null, null, 14, 0 },
                    { 714, 30, 0, null, "", 0, "/images/players/default.png", 0, 0, "Abdel Rahman Ramadan", "Egypt", "", "Defender", 0, null, null, 14, 0 },
                    { 715, 20, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Mahmoud", "Egypt", "", "Defender", 0, null, null, 14, 0 },
                    { 716, 28, 0, null, "", 0, "/images/players/default.png", 0, 0, "Nasser Nasser", "Egypt", "", "Midfielder", 0, null, null, 14, 0 },
                    { 717, 25, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Metwally Kanaria", "Egypt", "", "Midfielder", 0, null, null, 14, 0 },
                    { 718, 28, 0, null, "", 0, "/images/players/default.png", 0, 0, "Amr Saleh", "Egypt", "", "Midfielder", 0, null, null, 14, 0 },
                    { 719, 27, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Tony", "Egypt", "", "Midfielder", 0, null, null, 14, 0 },
                    { 720, 21, 0, null, "", 0, "/images/players/default.png", 0, 0, "Noor Alaa", "Egypt", "", "Midfielder", 0, null, null, 14, 0 },
                    { 721, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Isaac Saviour", "Nigeria", "", "Midfielder", 0, null, null, 14, 0 },
                    { 722, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Abdel Ghani Mohamed", "Egypt", "", "Forward", 0, null, null, 14, 0 },
                    { 723, 27, 0, null, "", 0, "/images/players/default.png", 0, 0, "Fadi Farid", "Egypt", "", "Forward", 0, null, null, 14, 0 },
                    { 724, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Abu Bakr Lyadi", "Nigeria", "", "Forward", 0, null, null, 14, 0 },
                    { 725, 27, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Eid Abdel Nabi", "Egypt", "", "Forward", 0, null, null, 14, 0 },
                    { 726, 28, 0, null, "", 0, "/images/players/default.png", 0, 0, "John Ibuka", "Nigeria", "", "Forward", 0, null, null, 14, 0 },
                    { 727, 20, 0, null, "", 0, "/images/players/default.png", 0, 0, "Bikali Obami", "Gabon", "", "Forward", 0, null, null, 14, 0 },
                    { 728, 19, 0, null, "", 0, "/images/players/default.png", 0, 0, "Favor Akim", "Nigeria", "", "Forward", 0, null, null, 14, 0 },
                    { 729, 27, 0, null, "", 0, "/images/players/default.png", 0, 0, "Hisham Nabawy", "Egypt", "", "Forward", 0, null, null, 14, 0 },
                    { 730, 25, 0, null, "", 0, "/images/players/default.png", 0, 0, "Islam Samir", "Egypt", "", "Forward", 0, null, null, 14, 0 },
                    { 731, 24, 0, null, "", 0, "/images/players/default.png", 0, 0, "Amr Gomaa", "Egypt", "", "Forward", 0, null, null, 14, 0 },
                    { 732, 35, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Yehia", "Egypt", "", "Goalkeeper", 0, null, null, 15, 0 },
                    { 733, 26, 0, null, "", 0, "/images/players/default.png", 0, 0, "Karim Emad", "Egypt", "", "Goalkeeper", 0, null, null, 15, 0 },
                    { 734, 24, 0, null, "", 0, "/images/players/default.png", 0, 0, "Kamal El Sayed", "Egypt", "", "Goalkeeper", 0, null, null, 15, 0 },
                    { 735, 20, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mostafa Makhlouf", "Egypt", "", "Goalkeeper", 0, null, null, 15, 0 },
                    { 736, 35, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Abu Gabal", "Egypt", "", "Goalkeeper", 0, null, null, 15, 0 },
                    { 737, 33, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ali El Feel", "Egypt", "", "Defender", 0, null, null, 15, 0 },
                    { 738, 34, 0, null, "", 0, "/images/players/default.png", 0, 0, "Khaled Reda", "Egypt", "", "Defender", 0, null, null, 15, 0 },
                    { 739, 31, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ali Fawzy", "Egypt", "", "Defender", 0, null, null, 15, 0 },
                    { 740, 30, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mahmoud Rizk", "Egypt", "", "Defender", 0, null, null, 15, 0 },
                    { 741, 28, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mahmoud Shaaban", "Egypt", "", "Defender", 0, null, null, 15, 0 },
                    { 742, 26, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Desouky", "Egypt", "", "Defender", 0, null, null, 15, 0 },
                    { 743, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mostafa Ashraf", "Egypt", "", "Defender", 0, null, null, 15, 0 },
                    { 744, 20, 0, null, "", 0, "/images/players/default.png", 0, 0, "Abdel Rahman Rashdan", "Egypt", "", "Defender", 0, null, null, 15, 0 },
                    { 745, 23, 0, null, "", 0, "/images/players/default.png", 0, 0, "Tarek Mohamed", "Egypt", "", "Defender", 0, null, null, 15, 0 },
                    { 746, 28, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Helal", "Egypt", "", "Midfielder", 0, null, null, 15, 0 },
                    { 747, 26, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ghanam Mohamed", "Egypt", "", "Midfielder", 0, null, null, 15, 0 },
                    { 748, 30, 0, null, "", 0, "/images/players/default.png", 0, 0, "Emad Hamdy", "Egypt", "", "Midfielder", 0, null, null, 15, 0 },
                    { 749, 24, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Youssef", "Egypt", "", "Midfielder", 0, null, null, 15, 0 },
                    { 750, 24, 0, null, "", 0, "/images/players/default.png", 0, 0, "Abdel Rahman Osama", "Egypt", "", "Midfielder", 0, null, null, 15, 0 },
                    { 751, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ali Zaazaa", "Egypt", "", "Midfielder", 0, null, null, 15, 0 },
                    { 752, 26, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Mostafa", "Egypt", "", "Midfielder", 0, null, null, 15, 0 },
                    { 753, 25, 0, null, "", 0, "/images/players/default.png", 0, 0, "Abdallah Hafez", "Egypt", "", "Midfielder", 0, null, null, 15, 0 },
                    { 754, 23, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Sabry", "Egypt", "", "Midfielder", 0, null, null, 15, 0 },
                    { 755, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Rashad Metwally", "Egypt", "", "Midfielder", 0, null, null, 15, 0 },
                    { 756, 26, 0, null, "", 0, "/images/players/default.png", 0, 0, "A Redjem", "Algeria", "", "Forward", 0, null, null, 15, 0 },
                    { 757, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Walid Farag", "Egypt", "", "Forward", 0, null, null, 15, 0 },
                    { 758, 21, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mahmoud Mamdouh", "Egypt", "", "Forward", 0, null, null, 15, 0 },
                    { 759, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Mossad", "Egypt", "", "Forward", 0, null, null, 15, 0 },
                    { 760, 20, 0, null, "", 0, "/images/players/default.png", 0, 0, "Arnold Iba", "Cameroon", "", "Forward", 0, null, null, 15, 0 },
                    { 761, 28, 0, null, "", 0, "/images/players/default.png", 0, 0, "F Okenabirhie", "England", "", "Forward", 0, null, null, 15, 0 },
                    { 762, 30, 0, null, "", 0, "/images/players/default.png", 0, 0, "Hossam Hassan", "Egypt", "", "Forward", 0, null, null, 15, 0 },
                    { 763, 26, 0, null, "", 0, "/images/players/default.png", 0, 0, "Godwin Shika Okwara", "Nigeria", "", "Forward", 0, null, null, 15, 0 },
                    { 764, 39, 0, null, "", 0, "/images/players/default.png", 0, 0, "El Hany Soliman", "Egypt", "", "Goalkeeper", 0, null, null, 16, 0 },
                    { 765, 24, 0, null, "", 0, "/images/players/default.png", 0, 0, "Hussein Timour", "Egypt", "", "Goalkeeper", 0, null, null, 16, 0 },
                    { 766, 28, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Mihoub", "Egypt", "", "Goalkeeper", 0, null, null, 16, 0 },
                    { 767, 28, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Awad", "Egypt", "", "Defender", 0, null, null, 16, 0 },
                    { 768, 24, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Ragab", "Egypt", "", "Defender", 0, null, null, 16, 0 },
                    { 769, 31, 0, null, "", 0, "/images/players/default.png", 0, 0, "Haitham Mostafa", "Egypt", "", "Defender", 0, null, null, 16, 0 },
                    { 770, 27, 0, null, "", 0, "/images/players/default.png", 0, 0, "Sherif Reda", "Egypt", "", "Defender", 0, null, null, 16, 0 },
                    { 771, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ibrahim Samy", "Egypt", "", "Defender", 0, null, null, 16, 0 },
                    { 772, 25, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Hakam", "Egypt", "", "Defender", 0, null, null, 16, 0 },
                    { 773, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Youssef Afifi", "Egypt", "", "Defender", 0, null, null, 16, 0 },
                    { 774, 33, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Debesh", "Egypt", "", "Defender", 0, null, null, 16, 0 },
                    { 775, 25, 0, null, "", 0, "/images/players/default.png", 0, 0, "Islam Atiya", "Egypt", "", "Midfielder", 0, null, null, 16, 0 },
                    { 776, 25, 0, null, "", 0, "/images/players/default.png", 0, 0, "Khaled Bassiouny", "Egypt", "", "Midfielder", 0, null, null, 16, 0 },
                    { 777, 20, 0, null, "", 0, "/images/players/default.png", 0, 0, "Doku Dodo", "Benin", "", "Midfielder", 0, null, null, 16, 0 },
                    { 778, 31, 0, null, "", 0, "/images/players/default.png", 0, 0, "Abdel Rahman Amer", "Egypt", "", "Midfielder", 0, null, null, 16, 0 },
                    { 779, 28, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mahmoud Abdel Halim", "Egypt", "", "Midfielder", 0, null, null, 16, 0 },
                    { 780, 24, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Ali Amin", "Egypt", "", "Midfielder", 0, null, null, 16, 0 },
                    { 781, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Hisham Hafez", "Egypt", "", "Midfielder", 0, null, null, 16, 0 },
                    { 782, 24, 0, null, "", 0, "/images/players/default.png", 0, 0, "K Mohamed", "Côte dIvoire", "", "Midfielder", 0, null, null, 16, 0 },
                    { 783, 30, 0, null, "", 0, "/images/players/default.png", 0, 0, "Amr El Sisi", "Egypt", "", "Midfielder", 0, null, null, 16, 0 },
                    { 784, 28, 0, null, "", 0, "/images/players/default.png", 0, 0, "El Habib Ahmed Hassan", "Egypt", "", "Midfielder", 0, null, null, 16, 0 },
                    { 785, 21, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Fawzy", "Egypt", "", "Midfielder", 0, null, null, 16, 0 },
                    { 786, 20, 0, null, "", 0, "/images/players/default.png", 0, 0, "Samadou Attidjikou", "Benin", "", "Midfielder", 0, null, null, 16, 0 },
                    { 787, 30, 0, null, "", 0, "/images/players/default.png", 0, 0, "Khaled El Ghandour", "Egypt", "", "Midfielder", 0, null, null, 16, 0 },
                    { 788, 28, 0, null, "", 0, "/images/players/default.png", 0, 0, "Samir Fikry", "Egypt", "", "Midfielder", 0, null, null, 16, 0 },
                    { 789, 32, 0, null, "", 0, "/images/players/default.png", 0, 0, "Emad Fathy", "Egypt", "", "Midfielder", 0, null, null, 16, 0 },
                    { 790, 21, 0, null, "", 0, "/images/players/default.png", 0, 0, "Samuel Amadi", "Nigeria", "", "Forward", 0, null, null, 16, 0 },
                    { 791, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Saeed", "Egypt", "", "Forward", 0, null, null, 16, 0 },
                    { 792, 25, 0, null, "", 0, "/images/players/default.png", 0, 0, "Abdel Kader Yehia", "Egypt", "", "Forward", 0, null, null, 16, 0 },
                    { 793, 23, 0, null, "", 0, "/images/players/default.png", 0, 0, "Hossam Ashraf", "Egypt", "", "Forward", 0, null, null, 16, 0 },
                    { 794, 24, 0, null, "", 0, "/images/players/default.png", 0, 0, "Pape Badji", "Senegal", "", "Forward", 0, null, null, 16, 0 },
                    { 795, 36, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Adel Abdel Monem", "Egypt", "", "Goalkeeper", 0, null, null, 17, 0 },
                    { 796, 21, 0, null, "", 0, "/images/players/default.png", 0, 0, "Abdullah Gamal", "Egypt", "", "Goalkeeper", 0, null, null, 17, 0 },
                    { 797, 0, 0, null, "", 0, "/images/players/default.png", 0, 0, "Abdul Rahman Mahrous", "Egypt", "", "Goalkeeper", 0, null, null, 17, 0 },
                    { 798, 24, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Amar", "Egypt", "", "Defender", 0, null, null, 17, 0 },
                    { 799, 23, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Nasr", "Egypt", "", "Defender", 0, null, null, 17, 0 },
                    { 800, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Abdullah Said", "Egypt", "", "Defender", 0, null, null, 17, 0 },
                    { 801, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Hatem Mohamed", "Egypt", "", "Defender", 0, null, null, 17, 0 },
                    { 802, 21, 0, null, "", 0, "/images/players/default.png", 0, 0, "Adel Karim Shehata", "Egypt", "", "Defender", 0, null, null, 17, 0 },
                    { 803, 21, 0, null, "", 0, "/images/players/default.png", 0, 0, "Abdallah Mohamed", "Egypt", "", "Defender", 0, null, null, 17, 0 },
                    { 804, 21, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Ihab", "Egypt", "", "Defender", 0, null, null, 17, 0 },
                    { 805, 18, 0, null, "", 0, "/images/players/default.png", 0, 0, "Abdallah Hassan", "Egypt", "", "Defender", 0, null, null, 17, 0 },
                    { 806, 23, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Abd El Samee", "Egypt", "", "Midfielder", 0, null, null, 17, 0 },
                    { 807, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Marwan Hamdy", "Egypt", "", "Midfielder", 0, null, null, 17, 0 },
                    { 808, 30, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Hassan", "Egypt", "", "Midfielder", 0, null, null, 17, 0 },
                    { 809, 31, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed El Sheikh", "Egypt", "", "Midfielder", 0, null, null, 17, 0 },
                    { 810, 24, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ali Omar", "Egypt", "", "Midfielder", 0, null, null, 17, 0 },
                    { 811, 27, 0, null, "", 0, "/images/players/default.png", 0, 0, "Eric Traore", "Burkina Faso", "", "Midfielder", 0, null, null, 17, 0 },
                    { 812, 20, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mahmoud Otaka", "Egypt", "", "Midfielder", 0, null, null, 17, 0 },
                    { 813, 18, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ibrahim Abdel Aal", "Egypt", "", "Midfielder", 0, null, null, 17, 0 },
                    { 814, 18, 0, null, "", 0, "/images/players/default.png", 0, 0, "Abdel Katkout", "Egypt", "", "Midfielder", 0, null, null, 17, 0 },
                    { 815, 24, 0, null, "", 0, "/images/players/default.png", 0, 0, "Abdel Rahman El Deh", "Egypt", "", "Forward", 0, null, null, 17, 0 },
                    { 816, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Nader Farag", "Egypt", "", "Forward", 0, null, null, 17, 0 },
                    { 817, 18, 0, null, "", 0, "/images/players/default.png", 0, 0, "Hassan Saber", "Egypt", "", "Forward", 0, null, null, 17, 0 },
                    { 818, 21, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Wagdy", "Egypt", "", "Forward", 0, null, null, 17, 0 },
                    { 819, 0, 0, null, "", 0, "/images/players/default.png", 0, 0, "Amr Said", "Egypt", "", "Forward", 0, null, null, 17, 0 },
                    { 820, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Zidan", "Egypt", "", "Forward", 0, null, null, 17, 0 },
                    { 821, 20, 0, null, "", 0, "/images/players/default.png", 0, 0, "Khaled Al Nabries", "Palestine", "", "Forward", 0, null, null, 17, 0 },
                    { 822, 19, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Khatary", "Egypt", "", "Forward", 0, null, null, 17, 0 },
                    { 823, 18, 0, null, "", 0, "/images/players/default.png", 0, 0, "Omar El Kot", "Egypt", "", "Forward", 0, null, null, 17, 0 },
                    { 824, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed El Behairy", "Egypt", "", "Forward", 0, null, null, 17, 0 },
                    { 825, 15, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ibrahim El Nagaawy", "Egypt", "", "Forward", 0, null, null, 17, 0 },
                    { 826, 26, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Ibrahim", "Egypt", "", "Goalkeeper", 0, null, null, 18, 0 },
                    { 827, 36, 0, null, "", 0, "/images/players/default.png", 0, 0, "Amer Amer", "Egypt", "", "Goalkeeper", 0, null, null, 18, 0 },
                    { 828, 31, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed El Arabi", "Egypt", "", "Goalkeeper", 0, null, null, 18, 0 },
                    { 829, 26, 0, null, "", 0, "/images/players/default.png", 0, 0, "Bassem Walid", "Egypt", "", "Defender", 0, null, null, 18, 0 },
                    { 830, 25, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Castelo", "Egypt", "", "Defender", 0, null, null, 18, 0 },
                    { 831, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Yehia Zakaria", "Egypt", "", "Defender", 0, null, null, 18, 0 },
                    { 832, 18, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Nabih", "Egypt", "", "Defender", 0, null, null, 18, 0 },
                    { 833, 25, 0, null, "", 0, "/images/players/default.png", 0, 0, "Hamidu Fatawu", "Ghana", "", "Defender", 0, null, null, 18, 0 },
                    { 834, 24, 0, null, "", 0, "/images/players/default.png", 0, 0, "Osama Fathy", "Egypt", "", "Defender", 0, null, null, 18, 0 },
                    { 835, 25, 0, null, "", 0, "/images/players/default.png", 0, 0, "Abdelrahim Amoory", "Egypt", "", "Defender", 0, null, null, 18, 0 },
                    { 836, 26, 0, null, "", 0, "/images/players/default.png", 0, 0, "Abdelrahman Youssef", "Egypt", "", "Defender", 0, null, null, 18, 0 },
                    { 837, 28, 0, null, "", 0, "/images/players/default.png", 0, 0, "Khaled El Akhmimi", "Egypt", "", "Midfielder", 0, null, null, 18, 0 },
                    { 838, 32, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ibrahim Hassan", "Egypt", "", "Midfielder", 0, null, null, 18, 0 },
                    { 839, 25, 0, null, "", 0, "/images/players/default.png", 0, 0, "Youssef Hassan", "Egypt", "", "Midfielder", 0, null, null, 18, 0 },
                    { 840, 24, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Osama", "Egypt", "", "Midfielder", 0, null, null, 18, 0 },
                    { 841, 34, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Magdy", "Egypt", "", "Midfielder", 0, null, null, 18, 0 },
                    { 842, 21, 0, null, "", 0, "/images/players/default.png", 0, 0, "M Touré", "Côte d'Ivoire", "", "Midfielder", 0, null, null, 18, 0 },
                    { 843, 28, 0, null, "", 0, "/images/players/default.png", 0, 0, "Abdelrahman Khaled", "Egypt", "", "Midfielder", 0, null, null, 18, 0 },
                    { 844, 0, 0, null, "", 0, "/images/players/default.png", 0, 0, "Momoh Kamara", "0", "", "Midfielder", 0, null, null, 18, 0 },
                    { 845, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Emad Mihoub", "Egypt", "", "Midfielder", 0, null, null, 18, 0 },
                    { 846, 25, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Ashraf", "Egypt", "", "Forward", 0, null, null, 18, 0 },
                    { 847, 27, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Essam Amara", "Egypt", "", "Forward", 0, null, null, 18, 0 },
                    { 848, 27, 0, null, "", 0, "/images/players/default.png", 0, 0, "R Arfaoui", "Tunisia", "", "Forward", 0, null, null, 18, 0 },
                    { 849, 0, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mahmoud Satouhi", "Egypt", "", "Forward", 0, null, null, 18, 0 },
                    { 850, 29, 0, null, "", 0, "/images/players/default.png", 0, 0, "Hossam Abu El Azm", "Egypt", "", "Forward", 0, null, null, 18, 0 },
                    { 851, 25, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Ben Hamouda", "Tunisia", "", "Forward", 0, null, null, 18, 0 },
                    { 852, 18, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mahmoud Magdy", "Egypt", "", "Forward", 0, null, null, 18, 0 },
                    { 853, 29, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mahmoud Wadi", "Palestine", "", "Forward", 0, null, null, 18, 0 },
                    { 854, 19, 0, null, "", 0, "/images/players/default.png", 0, 0, "Atef Al Hakim", "Egypt", "", "Forward", 0, null, null, 18, 0 },
                    { 855, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Hazem Abou Sena", "Egypt", "", "Forward", 0, null, null, 18, 0 },
                    { 856, 27, 0, null, "", 0, "/images/players/default.png", 0, 0, "Abdel Nasser Mohamed Di Maria", "Egypt", "", "Forward", 0, null, null, 18, 0 },
                    { 857, 35, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mahmoud Abu El-Saud", "Egypt", "", "Goalkeeper", 0, null, null, 19, 0 },
                    { 858, 27, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Fawzi", "Egypt", "", "Goalkeeper", 0, null, null, 19, 0 },
                    { 859, 30, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mahmoud El Hadary", "Egypt", "", "Goalkeeper", 0, null, null, 19, 0 },
                    { 860, 30, 0, null, "", 0, "/images/players/default.png", 0, 0, "J. Oshaya", "Uganda", "", "Defender", 0, null, null, 19, 0 },
                    { 861, 31, 0, null, "", 0, "/images/players/default.png", 0, 0, "Loay Wael", "Egypt", "", "Defender", 0, null, null, 19, 0 },
                    { 862, 34, 0, null, "", 0, "/images/players/default.png", 0, 0, "Amir Abed", "Egypt", "", "Defender", 0, null, null, 19, 0 },
                    { 863, 30, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Hamed", "Egypt", "", "Defender", 0, null, null, 19, 0 },
                    { 864, 24, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Hazin", "Egypt", "", "Defender", 0, null, null, 19, 0 },
                    { 865, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Islam Abdallah", "Egypt", "", "Defender", 0, null, null, 19, 0 },
                    { 866, 25, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Magdy Kahraba", "Egypt", "", "Defender", 0, null, null, 19, 0 },
                    { 867, 33, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ibrahim El Qadi", "Egypt", "", "Defender", 0, null, null, 19, 0 },
                    { 868, 24, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Hesham", "Egypt", "", "Defender", 0, null, null, 19, 0 },
                    { 869, 33, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Gamal El Karta", "Egypt", "", "Defender", 0, null, null, 19, 0 },
                    { 870, 28, 0, null, "", 0, "/images/players/default.png", 0, 0, "Elsayed Abu Amna", "Egypt", "", "Midfielder", 0, null, null, 19, 0 },
                    { 871, 27, 0, null, "", 0, "/images/players/default.png", 0, 0, "Islam Gaber", "Egypt", "", "Midfielder", 0, null, null, 19, 0 },
                    { 872, 28, 0, null, "", 0, "/images/players/default.png", 0, 0, "Omar El-Wahsh", "Egypt", "", "Midfielder", 0, null, null, 19, 0 },
                    { 873, 17, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Abdelnaser", "Egypt", "", "Midfielder", 0, null, null, 19, 0 },
                    { 874, 27, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohand Mohamed", "Egypt", "", "Midfielder", 0, null, null, 19, 0 },
                    { 875, 20, 0, null, "", 0, "/images/players/default.png", 0, 0, "Abdelrahman Akmal", "Egypt", "", "Midfielder", 0, null, null, 19, 0 },
                    { 876, 32, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mostafa Gamal", "Egypt", "", "Midfielder", 0, null, null, 19, 0 },
                    { 877, 29, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Salem", "Egypt", "", "Forward", 0, null, null, 19, 0 },
                    { 878, 26, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Hesham", "Egypt", "", "Forward", 0, null, null, 19, 0 },
                    { 879, 26, 0, null, "", 0, "/images/players/default.png", 0, 0, "Joaquim Ojiera", "Uganda", "", "Forward", 0, null, null, 19, 0 },
                    { 880, 0, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mahmoud Abou-Gouda", "Egypt", "", "Forward", 0, null, null, 19, 0 },
                    { 881, 25, 0, null, "", 0, "/images/players/default.png", 0, 0, "Abdelrahman Samana", "Egypt", "", "Forward", 0, null, null, 19, 0 },
                    { 882, 25, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mostafa Sobhi", "Egypt", "", "Forward", 0, null, null, 19, 0 },
                    { 883, 29, 0, null, "", 0, "/images/players/default.png", 0, 0, "Shokry Naguib", "Egypt", "", "Forward", 0, null, null, 19, 0 },
                    { 884, 18, 0, null, "", 0, "/images/players/default.png", 0, 0, "C. Ekpenyong", "Nigeria", "", "Forward", 0, null, null, 19, 0 },
                    { 885, 0, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mahmoud El Sayed Daabasa", "Egypt", "", "Forward", 0, null, null, 19, 0 },
                    { 886, 31, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Antar", "Egypt", "", "Forward", 0, null, null, 19, 0 },
                    { 887, 32, 0, null, "", 0, "/images/players/default.png", 0, 0, "Amr Hossam", "Egypt", "", "Goalkeeper", 0, null, null, 20, 0 },
                    { 888, 28, 0, null, "", 0, "/images/players/default.png", 0, 0, "Hassan El-Hattab", "Egypt", "", "Goalkeeper", 0, null, null, 20, 0 },
                    { 889, 0, 0, null, "", 0, "/images/players/default.png", 0, 0, "Amr Shaaban", "Egypt", "", "Goalkeeper", 0, null, null, 20, 0 },
                    { 890, 28, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Dahroug", "Egypt", "", "Defender", 0, null, null, 20, 0 },
                    { 891, 30, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Ayman", "Egypt", "", "Defender", 0, null, null, 20, 0 },
                    { 892, 27, 0, null, "", 0, "/images/players/default.png", 0, 0, "Shady Maher", "Egypt", "", "Defender", 0, null, null, 20, 0 },
                    { 893, 21, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Reda", "Egypt", "", "Defender", 0, null, null, 20, 0 },
                    { 894, 24, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ragab El-Safi", "Egypt", "", "Defender", 0, null, null, 20, 0 },
                    { 895, 25, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Dahesh", "Egypt", "", "Defender", 0, null, null, 20, 0 },
                    { 896, 27, 0, null, "", 0, "/images/players/default.png", 0, 0, "Kamal Abu El-Fotouh", "Egypt", "", "Defender", 0, null, null, 20, 0 },
                    { 897, 32, 0, null, "", 0, "/images/players/default.png", 0, 0, "Saif Teka", "Tunisia", "", "Defender", 0, null, null, 20, 0 },
                    { 898, 28, 0, null, "", 0, "/images/players/default.png", 0, 0, "Omar Adly", "Egypt", "", "Defender", 0, null, null, 20, 0 },
                    { 899, 26, 0, null, "", 0, "/images/players/default.png", 0, 0, "M. Kaandorp", "Netherlands", "", "Midfielder", 0, null, null, 20, 0 },
                    { 900, 33, 0, null, "", 0, "/images/players/default.png", 0, 0, "Hesham Mohamed", "Egypt", "", "Midfielder", 0, null, null, 20, 0 },
                    { 901, 28, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed El-Shimy", "Egypt", "", "Midfielder", 0, null, null, 20, 0 },
                    { 902, 33, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mahmoud Talaat", "Egypt", "", "Midfielder", 0, null, null, 20, 0 },
                    { 903, 29, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Abdel-Aty", "Egypt", "", "Midfielder", 0, null, null, 20, 0 },
                    { 904, 31, 0, null, "", 0, "/images/players/default.png", 0, 0, "Islam Adel Kanu", "Egypt", "", "Midfielder", 0, null, null, 20, 0 },
                    { 905, 32, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ibrahim El Bahnasi", "Egypt", "", "Midfielder", 0, null, null, 20, 0 },
                    { 906, 33, 0, null, "", 0, "/images/players/default.png", 0, 0, "Wincool Kobinah", "Ghana", "", "Midfielder", 0, null, null, 20, 0 },
                    { 907, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Farouk", "Egypt", "", "Forward", 0, null, null, 20, 0 },
                    { 908, 28, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mahmoud Diasty", "Egypt", "", "Forward", 0, null, null, 20, 0 },
                    { 909, 23, 0, null, "", 0, "/images/players/default.png", 0, 0, "Youssef Oya", "Egypt", "", "Forward", 0, null, null, 20, 0 },
                    { 910, 32, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Abdelrahim", "Egypt", "", "Forward", 0, null, null, 20, 0 },
                    { 911, 31, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ali Hussein", "Egypt", "", "Forward", 0, null, null, 20, 0 },
                    { 912, 30, 0, null, "", 0, "/images/players/default.png", 0, 0, "F. Boli", "Côte d'Ivoire", "", "Forward", 0, null, null, 20, 0 },
                    { 913, 23, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ali El-Gabri", "Egypt", "", "Goalkeeper", 0, null, null, 21, 0 },
                    { 914, 0, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Hagras", "Egypt", "", "Goalkeeper", 0, null, null, 21, 0 },
                    { 915, 32, 0, null, "", 0, "/images/players/default.png", 0, 0, "Joseph Nguim", "Cameroon", "", "Defender", 0, null, null, 21, 0 },
                    { 916, 27, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ibrahim Awad", "Egypt", "", "Defender", 0, null, null, 21, 0 },
                    { 917, 21, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Awsam", "Egypt", "", "Defender", 0, null, null, 21, 0 },
                    { 918, 28, 0, null, "", 0, "/images/players/default.png", 0, 0, "M. Abuzraa", "Morocco", "", "Defender", 0, null, null, 21, 0 },
                    { 919, 25, 0, null, "", 0, "/images/players/default.png", 0, 0, "Karim Yehia", "Egypt", "", "Defender", 0, null, null, 21, 0 },
                    { 920, 30, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mahmoud Metwally", "Egypt", "", "Defender", 0, null, null, 21, 0 },
                    { 921, 30, 0, null, "", 0, "/images/players/default.png", 0, 0, "Karim Mamdouh Khaled", "Egypt", "", "Defender", 0, null, null, 21, 0 },
                    { 922, 25, 0, null, "", 0, "/images/players/default.png", 0, 0, "Seif El-Khashab", "Egypt", "", "Defender", 0, null, null, 21, 0 },
                    { 923, 0, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Medhat", "Egypt", "", "Defender", 0, null, null, 21, 0 },
                    { 924, 0, 0, null, "", 0, "/images/players/default.png", 0, 0, "Essam El Fayoumi", "Egypt", "", "Defender", 0, null, null, 21, 0 },
                    { 925, 0, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Saied", "Egypt", "", "Defender", 0, null, null, 21, 0 },
                    { 926, 30, 0, null, "", 0, "/images/players/default.png", 0, 0, "Ahmed Hamza", "Egypt", "", "Midfielder", 0, null, null, 21, 0 },
                    { 927, 21, 0, null, "", 0, "/images/players/default.png", 0, 0, "Magid Abdel Rahman", "Egypt", "", "Midfielder", 0, null, null, 21, 0 },
                    { 928, 32, 0, null, "", 0, "/images/players/default.png", 0, 0, "Islam Abdel Naeem", "Egypt", "", "Midfielder", 0, null, null, 21, 0 },
                    { 929, 22, 0, null, "", 0, "/images/players/default.png", 0, 0, "Seif El-Agooz", "Egypt", "", "Midfielder", 0, null, null, 21, 0 },
                    { 930, 21, 0, null, "", 0, "/images/players/default.png", 0, 0, "Abdel Fattah Sheta", "Egypt", "", "Midfielder", 0, null, null, 21, 0 },
                    { 931, 21, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Hamdy", "Egypt", "", "Midfielder", 0, null, null, 21, 0 },
                    { 932, 0, 0, null, "", 0, "/images/players/default.png", 0, 0, "M. Sillah", "Egypt", "", "Midfielder", 0, null, null, 21, 0 },
                    { 933, 0, 0, null, "", 0, "/images/players/default.png", 0, 0, "J. Nkengafack", "Egypt", "", "Midfielder", 0, null, null, 21, 0 },
                    { 934, 30, 0, null, "", 0, "/images/players/default.png", 0, 0, "Karim Ashraf", "Egypt", "", "Forward", 0, null, null, 21, 0 },
                    { 935, 24, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Juhayna", "Egypt", "", "Forward", 0, null, null, 21, 0 },
                    { 936, 33, 0, null, "", 0, "/images/players/default.png", 0, 0, "Omar El-Saeed", "Egypt", "", "Forward", 0, null, null, 21, 0 },
                    { 937, 0, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Farouk", "Egypt", "", "Forward", 0, null, null, 21, 0 },
                    { 938, 32, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed Onajem", "Morocco", "", "Forward", 0, null, null, 21, 0 },
                    { 939, 0, 0, null, "", 0, "/images/players/default.png", 0, 0, "Abdallah Maradona", "Egypt", "", "Forward", 0, null, null, 21, 0 },
                    { 940, 32, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mostafa Abdel Rahim Koshary", "Egypt", "", "Forward", 0, null, null, 21, 0 },
                    { 941, 0, 0, null, "", 0, "/images/players/default.png", 0, 0, "A. Sulieman", "Egypt", "", "Forward", 0, null, null, 21, 0 },
                    { 942, 27, 0, null, "", 0, "/images/players/default.png", 0, 0, "Mohamed El-Sayed Shika", "Egypt", "", "Forward", 0, null, null, 21, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 636);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 641);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 645);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 648);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 651);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 652);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 653);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 654);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 655);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 656);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 657);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 658);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 659);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 660);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 661);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 662);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 663);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 664);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 665);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 667);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 668);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 669);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 670);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 671);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 672);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 673);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 674);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 675);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 676);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 677);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 678);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 679);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 680);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 681);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 682);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 683);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 684);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 685);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 686);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 687);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 688);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 689);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 690);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 691);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 692);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 693);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 694);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 695);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 696);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 697);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 698);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 699);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 700);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 701);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 702);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 703);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 704);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 705);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 706);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 707);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 708);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 709);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 710);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 711);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 712);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 713);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 714);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 715);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 716);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 717);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 718);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 719);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 720);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 721);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 722);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 723);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 724);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 725);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 726);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 727);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 728);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 729);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 730);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 731);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 732);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 733);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 734);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 735);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 736);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 737);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 738);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 739);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 740);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 741);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 742);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 743);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 744);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 745);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 746);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 747);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 748);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 749);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 750);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 751);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 752);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 753);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 754);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 755);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 756);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 757);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 758);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 759);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 760);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 761);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 762);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 763);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 764);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 765);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 766);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 767);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 768);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 769);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 770);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 771);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 772);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 773);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 774);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 775);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 776);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 777);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 778);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 779);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 780);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 781);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 782);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 783);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 784);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 785);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 786);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 787);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 788);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 789);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 790);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 791);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 792);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 793);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 794);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 795);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 796);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 797);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 798);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 799);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 800);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 801);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 802);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 803);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 804);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 805);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 806);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 807);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 808);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 809);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 810);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 811);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 812);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 813);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 814);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 815);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 816);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 817);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 818);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 819);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 820);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 821);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 822);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 823);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 824);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 825);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 826);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 827);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 828);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 829);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 830);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 831);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 832);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 833);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 834);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 835);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 836);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 837);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 838);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 839);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 840);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 841);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 842);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 843);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 844);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 845);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 846);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 847);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 848);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 849);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 850);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 851);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 852);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 853);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 854);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 855);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 856);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 857);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 858);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 859);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 860);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 861);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 862);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 863);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 864);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 865);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 866);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 867);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 868);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 869);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 870);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 871);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 872);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 873);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 874);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 875);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 876);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 877);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 878);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 879);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 880);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 881);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 882);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 883);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 884);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 885);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 886);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 887);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 888);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 889);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 890);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 891);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 892);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 893);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 894);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 895);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 896);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 897);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 898);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 899);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 900);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 901);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 902);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 903);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 904);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 905);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 906);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 907);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 908);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 909);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 910);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 911);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 912);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 913);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 914);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 915);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 916);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 917);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 918);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 919);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 920);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 921);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 922);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 923);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 924);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 925);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 926);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 927);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 928);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 929);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 930);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 931);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 932);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 933);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 934);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 935);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 936);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 937);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 938);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 939);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 940);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 941);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 942);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "FullName", "ImageUrl", "MatchesPlayed", "MinutesPlayed", "Name", "NationalTeam", "Nationality", "Position", "ShirtNumber" },
                values: new object[] { new DateTime(1988, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "محمد الشناوي", "/images/players/mohamed-el-shenawy.png", 3, 270, "محمد الشناوي", "مصر", "مصر", "حارس مرمى", 1 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 2,
                columns: new[] { "Age", "Assists", "DateOfBirth", "FullName", "Goals", "ImageUrl", "MatchesPlayed", "MinutesPlayed", "Name", "NationalTeam", "Nationality", "Position", "ShirtNumber", "YellowCards" },
                values: new object[] { 29, 1, new DateTime(1996, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "محمد مجدي أفشة", 2, "/images/players/mohamed-magdy-afsha.png", 3, 255, "محمد مجدي أفشة", "مصر", "مصر", "وسط", 19, 1 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 3,
                columns: new[] { "Age", "Assists", "DateOfBirth", "FullName", "Goals", "ImageUrl", "MatchesPlayed", "MinutesPlayed", "Name", "NationalTeam", "Nationality", "Position", "ShirtNumber" },
                values: new object[] { 31, 1, new DateTime(1994, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "برسي تاو", 3, "/images/players/percy-tau.png", 3, 235, "برسي تاو", "جنوب أفريقيا", "جنوب أفريقيا", "مهاجم", 22 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 4,
                columns: new[] { "Age", "Assists", "DateOfBirth", "FullName", "Goals", "ImageUrl", "MatchesPlayed", "MinutesPlayed", "Name", "NationalTeam", "Nationality", "Position", "ShirtNumber" },
                values: new object[] { 32, 2, new DateTime(1992, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "حسين الشحات", 2, "/images/players/hussein-el-shahat.png", 3, 270, "حسين الشحات", "مصر", "مصر", "جناح", 14 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 5,
                columns: new[] { "Age", "DateOfBirth", "FullName", "ImageUrl", "MatchesPlayed", "MinutesPlayed", "Name", "NationalTeam", "Nationality", "Position", "ShirtNumber", "YellowCards" },
                values: new object[] { 27, new DateTime(1997, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "أليو ديانج", "/images/players/aliou-dieng.png", 3, 270, "أليو ديانج", "مالي", "مالي", "وسط دفاعي", 15, 1 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 6,
                columns: new[] { "Age", "DateOfBirth", "FullName", "ImageUrl", "MatchesPlayed", "MinutesPlayed", "Name", "NationalTeam", "Nationality", "Position", "ShirtNumber", "TeamId" },
                values: new object[] { 33, new DateTime(1992, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "محمد عواد", "/images/players/mohamed-awad.png", 3, 270, "محمد عواد", "مصر", "مصر", "حارس مرمى", 1, 2 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 7,
                columns: new[] { "Age", "DateOfBirth", "FullName", "Goals", "ImageUrl", "MatchesPlayed", "MinutesPlayed", "Name", "NationalTeam", "Nationality", "Position", "ShirtNumber", "TeamId", "YellowCards" },
                values: new object[] { 29, new DateTime(1996, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "أحمد سيد زيزو", 3, "/images/players/ahmed-sayed-zizo.png", 3, 270, "أحمد سيد زيزو", "مصر", "مصر", "جناح", 17, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 8,
                columns: new[] { "Age", "DateOfBirth", "FullName", "Goals", "ImageUrl", "MatchesPlayed", "MinutesPlayed", "Name", "NationalTeam", "Nationality", "Position", "ShirtNumber", "TeamId" },
                values: new object[] { 24, new DateTime(2001, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "إبراهيم عادل", 2, "/images/players/ibrahim-adel.png", 3, 270, "إبراهيم عادل", "مصر", "مصر", "مهاجم", 11, 3 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "Coach", "Colors", "Country", "Founded", "GoalsFor", "LogoUrl", "Name", "Played", "Position", "ShortName", "Stadium", "StadiumCapacity", "Website", "Wins" },
                values: new object[] { "القاهرة", "مارسيل كولر", "أحمر وأبيض", "مصر", new DateTime(1907, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "/images/teams/al-ahly.png", "الأهلي", 3, 1, "AHL", "استاد الأهلي WE", 30000, "https://www.alahlyegypt.com/", 3 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "Coach", "Colors", "Country", "Draws", "Founded", "GoalsAgainst", "GoalsFor", "LogoUrl", "Name", "Played", "Position", "ShortName", "Stadium", "StadiumCapacity", "Website", "Wins" },
                values: new object[] { "القاهرة", "فرانسيسكو ميكالي", "أبيض وأحمر", "مصر", 1, new DateTime(1911, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 5, "/images/teams/zamalek.png", "الزمالك", 3, 2, "ZAM", "استاد القاهرة الدولي", 75000, "https://www.zamalekclub.com/", 2 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "Coach", "Colors", "Country", "Draws", "Founded", "GoalsAgainst", "GoalsFor", "LogoUrl", "Name", "Played", "Position", "ShortName", "Stadium", "StadiumCapacity", "Website", "Wins" },
                values: new object[] { "القاهرة", "خالد جلال", "أزرق وأصفر", "مصر", 2, new DateTime(2008, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3, "/images/teams/pyramids.png", "بيراميدز", 3, 3, "PYR", "استاد 30 يونيو", 30000, "https://www.pyramidsfc.com/", 1 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "City", "Coach", "Colors", "Country", "Draws", "Founded", "GoalsAgainst", "GoalsFor", "LogoUrl", "Losses", "Name", "Played", "Position", "ShortName", "Stadium", "StadiumCapacity", "Website", "Wins" },
                values: new object[] { "بورسعيد", "محمد عودة", "أخضر وأبيض", "مصر", 1, new DateTime(1920, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3, "/images/teams/el-masry.png", 1, "المصري", 3, 4, "MAS", "استاد بورسعيد", 18000, "https://www.almasryclub.com/", 1 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "City", "Coach", "Colors", "Country", "Founded", "GoalsAgainst", "GoalsFor", "LogoUrl", "Losses", "Name", "Played", "Position", "ShortName", "Stadium", "StadiumCapacity", "Website", "Wins" },
                values: new object[] { "القاهرة", "علي ماهر", "أبيض وأزرق", "مصر", new DateTime(2011, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 2, "/images/teams/future-fc.png", 2, "فيوتشر", 3, 5, "FUT", "استاد WE الأهلي", 20000, "https://www.futurefcegypt.com/", 1 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "City", "Coach", "Colors", "Country", "Founded", "GoalsAgainst", "LogoUrl", "Losses", "Name", "Played", "Position", "ShortName", "Stadium", "StadiumCapacity", "Website" },
                values: new object[] { "القاهرة", "هاني رمزي", "أزرق وأبيض", "مصر", new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "/images/teams/ceramica-cleopatra.png", 3, "سيراميكا كليوباترا", 3, 6, "CER", "استاد الأكاديمية العسكرية", 28500, "https://www.ceramicacleopatrafc.com/" });
        }
    }
}
