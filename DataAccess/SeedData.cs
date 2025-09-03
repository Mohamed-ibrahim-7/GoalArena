using GoalArena.Models;
using Microsoft.EntityFrameworkCore;

namespace GoalArena.Data.Seed
{
    public static class SeedData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            // Tournament - Egyptian Premier League
            modelBuilder.Entity<Tournament>().HasData(
                new Tournament
                {
                    TournamentId = 1,
                    Name = "الدوري المصري الممتاز",
                    Country = "مصر",
                    LogoUrl = "/images/tournaments/egyptian-premier-league.png"
                },
                new Tournament
                {
                    TournamentId = 3,
                    Name = "دوري أبطال أوروبا",
                    Country = "أوروبا",
                    LogoUrl = "/images/tournaments/ucl.png"
                }
            );

            // Season - Current 2025-2026
            modelBuilder.Entity<Season>().HasData(
                new Season
                {
                    SeasonId = 1,
                    Name = "2025-2026",
                    Status = SeasonStatus.Ongoing,
                    TournamentId = 1
                }
            );

            modelBuilder.Entity<Team>().HasData(
new Team { Id = 1, Name = "Al Ahly", Coach = "TBD", LogoUrl = "/images/teams/default.png", SeasonId = 1 },
new Team { Id = 2, Name = "Zamalek SC", Coach = "TBD", LogoUrl = "/images/teams/default.png", SeasonId = 1 },
new Team { Id = 3, Name = "Pyramids FC", Coach = "TBD", LogoUrl = "/images/teams/default.png", SeasonId = 1 },
new Team { Id = 4, Name = "Al Masry", Coach = "TBD", LogoUrl = "/images/teams/default.png", SeasonId = 1 },
new Team { Id = 5, Name = "National Bank of Egypt", Coach = "TBD", LogoUrl = "/images/teams/default.png", SeasonId = 1 },
new Team { Id = 6, Name = "Ceramica Cleopatra FC", Coach = "TBD", LogoUrl = "/images/teams/default.png", SeasonId = 1 },
new Team { Id = 7, Name = "Pharco FC", Coach = "TBD", LogoUrl = "/images/teams/default.png", SeasonId = 1 },
new Team { Id = 8, Name = "Petrojet FC", Coach = "TBD", LogoUrl = "/images/teams/default.png", SeasonId = 1 },
new Team { Id = 9, Name = "Haras El Hodoud", Coach = "TBD", LogoUrl = "/images/teams/default.png", SeasonId = 1 },
new Team { Id = 10, Name = "ZED FC", Coach = "TBD", LogoUrl = "/images/teams/default.png", SeasonId = 1 },
new Team { Id = 11, Name = "El Gouna FC", Coach = "TBD", LogoUrl = "/images/teams/default.png", SeasonId = 1 },
new Team { Id = 12, Name = "Tala'ea El Gaish", Coach = "TBD", LogoUrl = "/images/teams/default.png", SeasonId = 1 },
new Team { Id = 13, Name = "ENPPI", Coach = "TBD", LogoUrl = "/images/teams/default.png", SeasonId = 1 },
new Team { Id = 14, Name = "Al Ittihad Alexandria", Coach = "TBD", LogoUrl = "/images/teams/default.png", SeasonId = 1 },
new Team { Id = 15, Name = "Modern Sport", Coach = "TBD", LogoUrl = "/images/teams/default.png", SeasonId = 1 },
new Team { Id = 16, Name = "Smouha SC", Coach = "TBD", LogoUrl = "/images/teams/default.png", SeasonId = 1 },
new Team { Id = 17, Name = "Ismaily SC", Coach = "TBD", LogoUrl = "/images/teams/default.png", SeasonId = 1 },
new Team { Id = 18, Name = "Ghazl El Mahalla", Coach = "TBD", LogoUrl = "/images/teams/default.png", SeasonId = 1 },
new Team { Id = 19, Name = "Al Mokawloon Al Arab", Coach = "TBD", LogoUrl = "/images/teams/default.png", SeasonId = 1 },
new Team { Id = 20, Name = "Wadi Degla", Coach = "TBD", LogoUrl = "/images/teams/default.png", SeasonId = 1 },
new Team { Id = 21, Name = "Kahrabaa Ismailia", Coach = "TBD", LogoUrl = "/images/teams/default.png", SeasonId = 1 }
);

            modelBuilder.Entity<Player>().HasData(
    new Player { PlayerId = 1, Name = "Mohamed El Shenawy", Position = "Goalkeeper", Age = 36, NationalTeam = "Egypt", TeamId = 1, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 2, Name = "Mostafa Shobier", Position = "Goalkeeper", Age = 24, NationalTeam = "Egypt", TeamId = 1, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 3, Name = "Hamza Alaa", Position = "Goalkeeper", Age = 23, NationalTeam = "Egypt", TeamId = 1, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },

    new Player { PlayerId = 4, Name = "Mohamed Hany", Position = "Defender", Age = 28, NationalTeam = "Egypt", TeamId = 1, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 5, Name = "Yasser Ibrahim", Position = "Defender", Age = 32, NationalTeam = "Egypt", TeamId = 1, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 6, Name = "Karim Fouad", Position = "Defender", Age = 25, NationalTeam = "Egypt", TeamId = 1, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 7, Name = "Omar Kamal", Position = "Defender", Age = 31, NationalTeam = "Egypt", TeamId = 1, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 8, Name = "Achraf Dari", Position = "Defender", Age = 25, NationalTeam = "Morocco", TeamId = 1, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 9, Name = "Rami Rabia", Position = "Defender", Age = 31, NationalTeam = "Egypt", TeamId = 1, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 10, Name = "Yahya Attiyat Allah", Position = "Defender", Age = 29, NationalTeam = "Morocco", TeamId = 1, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },

    new Player { PlayerId = 11, Name = "Hussein El Shahat", Position = "Midfielder", Age = 32, NationalTeam = "Egypt", TeamId = 1, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 12, Name = "Mohamed Magdy Afsha", Position = "Midfielder", Age = 28, NationalTeam = "Egypt", TeamId = 1, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 13, Name = "Ahmed Nabil Kouka", Position = "Midfielder", Age = 23, NationalTeam = "Egypt", TeamId = 1, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 14, Name = "Marwan Attia", Position = "Midfielder", Age = 26, NationalTeam = "Egypt", TeamId = 1, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 15, Name = "Imam Ashour", Position = "Midfielder", Age = 27, NationalTeam = "Egypt", TeamId = 1, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 16, Name = "Ahmed Kendoussi", Position = "Midfielder", Age = 25, NationalTeam = "Algeria", TeamId = 1, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 17, Name = "Akram Tawfik", Position = "Midfielder", Age = 27, NationalTeam = "Egypt", TeamId = 1, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },

    new Player { PlayerId = 18, Name = "Taher Mohamed", Position = "Forward", Age = 27, NationalTeam = "Egypt", TeamId = 1, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 19, Name = "Nejc Gradisar", Position = "Forward", Age = 22, NationalTeam = "Slovenia", TeamId = 1, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 20, Name = "Achraf Bencharki", Position = "Forward", Age = 30, NationalTeam = "Morocco", TeamId = 1, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 21, Name = "Mohamed Ali", Position = "Forward", Age = 19, NationalTeam = "Egypt", TeamId = 1, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 22, Name = "Percy Tau", Position = "Forward", Age = 31, NationalTeam = "South Africa", TeamId = 1, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 23, Name = "Mahmoud Kahraba", Position = "Forward", Age = 31, NationalTeam = "Egypt", TeamId = 1, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 24, Name = "Reda Slim", Position = "Forward", Age = 25, NationalTeam = "Morocco", TeamId = 1, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 25, Name = "Wissam Abu Ali", Position = "Forward", Age = 26, NationalTeam = "Palestine", TeamId = 1, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 26, Name = "Hamza Abdelkarim", Position = "Forward", Age = 17, NationalTeam = "Egypt", TeamId = 1, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" }
);
            modelBuilder.Entity<Player>().HasData(
                new Player { PlayerId = 101, Name = "Mohamed Sobhi", Position = "Goalkeeper", Age = 26, NationalTeam = "Egypt", TeamId = 3, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/sobhi.png" },
                new Player { PlayerId = 102, Name = "El Mahdy Soliman", Position = "Goalkeeper", Age = 38, NationalTeam = "Egypt", TeamId = 3, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/soliman.png" },
                new Player { PlayerId = 103, Name = "Mahmoud El Shenawy", Position = "Goalkeeper", Age = 21, NationalTeam = "Egypt", TeamId = 3, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/shenawy.png" },
                new Player { PlayerId = 104, Name = "Mohamed Awad", Position = "Goalkeeper", Age = 33, NationalTeam = "Egypt", TeamId = 3, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/awad.png" },

                new Player { PlayerId = 105, Name = "Mahmoud Hamdy El Wensh", Position = "Defender", Age = 30, NationalTeam = "Egypt", TeamId = 3, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/wensh.png" },
                new Player { PlayerId = 106, Name = "Hossam Abdelmaguid", Position = "Defender", Age = 24, NationalTeam = "Egypt", TeamId = 3, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/hossam.png" },
                new Player { PlayerId = 107, Name = "Ahmed Fattouh", Position = "Defender", Age = 27, NationalTeam = "Egypt", TeamId = 3, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/fattouh.png" },
                new Player { PlayerId = 108, Name = "Omar Gaber", Position = "Defender", Age = 33, NationalTeam = "Egypt", TeamId = 3, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/gaber.png" },
                new Player { PlayerId = 109, Name = "Mohamed Ismail", Position = "Defender", Age = 26, NationalTeam = "Egypt", TeamId = 3, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/ismail.png" },
                new Player { PlayerId = 110, Name = "S. Kerboub", Position = "Defender", Age = 27, NationalTeam = "Morocco", TeamId = 3, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/kerboub.png" },
                new Player { PlayerId = 111, Name = "Mohamed Bentayg", Position = "Defender", Age = 25, NationalTeam = "Morocco", TeamId = 3, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/bentayg.png" },

                new Player { PlayerId = 112, Name = "Abdallah El Said", Position = "Midfielder", Age = 40, NationalTeam = "Egypt", TeamId = 3, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/elsaid.png" },
                new Player { PlayerId = 113, Name = "Nabil Emad Donga", Position = "Midfielder", Age = 29, NationalTeam = "Egypt", TeamId = 3, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/donga.png" },
                new Player { PlayerId = 114, Name = "Mohamed Shehata", Position = "Midfielder", Age = 24, NationalTeam = "Egypt", TeamId = 3, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/shehata.png" },
                new Player { PlayerId = 115, Name = "Nasser Maher", Position = "Midfielder", Age = 28, NationalTeam = "Egypt", TeamId = 3, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/maher.png" },

                new Player { PlayerId = 116, Name = "Ahmed Sayed Zizo", Position = "Forward", Age = 29, NationalTeam = "Egypt", TeamId = 3, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/zizo.png" },
                new Player { PlayerId = 117, Name = "Shikabala", Position = "Forward", Age = 38, NationalTeam = "Egypt", TeamId = 3, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/shikabala.png" },
                new Player { PlayerId = 118, Name = "Mostafa Shalaby", Position = "Forward", Age = 30, NationalTeam = "Egypt", TeamId = 3, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/shalaby.png" },
                new Player { PlayerId = 119, Name = "Samson Akinyoola", Position = "Forward", Age = 25, NationalTeam = "Nigeria", TeamId = 3, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/samson.png" }
            );
            modelBuilder.Entity<Player>().HasData(
      // Team 2
      new Player { PlayerId = 200, Name = "Mohamed Sobhy", Position = "Goalkeeper", Age = 26, NationalTeam = "Egypt", TeamId = 2, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 201, Name = "El Mahdy Soliman", Position = "Goalkeeper", Age = 38, NationalTeam = "Egypt", TeamId = 2, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 202, Name = "Mahmoud El Shenawy", Position = "Goalkeeper", Age = 21, NationalTeam = "Egypt", TeamId = 2, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 203, Name = "Mohamed Awad", Position = "Goalkeeper", Age = 33, NationalTeam = "Egypt", TeamId = 2, ImageUrl = "/images/players/default.png" },

      new Player { PlayerId = 204, Name = "Mahmoud Hamdy El Wensh", Position = "Defender", Age = 30, NationalTeam = "Egypt", TeamId = 2, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 205, Name = "Hossam Abdelmaguid", Position = "Defender", Age = 24, NationalTeam = "Egypt", TeamId = 2, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 206, Name = "Ahmed Fattouh", Position = "Defender", Age = 27, NationalTeam = "Egypt", TeamId = 2, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 207, Name = "Ahmed Hossam", Position = "Defender", Age = 23, NationalTeam = "Egypt", TeamId = 2, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 208, Name = "Omar Gaber", Position = "Defender", Age = 33, NationalTeam = "Egypt", TeamId = 2, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 209, Name = "Moussaddaq Kerboub", Position = "Defender", Age = 27, NationalTeam = "Morocco", TeamId = 2, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 210, Name = "Mohamed Ismail", Position = "Defender", Age = 26, NationalTeam = "Egypt", TeamId = 2, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 211, Name = "Mohamed Bentayg", Position = "Defender", Age = 25, NationalTeam = "Morocco", TeamId = 2, ImageUrl = "/images/players/default.png" },

      new Player { PlayerId = 212, Name = "Ahmed Hamdy", Position = "Midfielder", Age = 27, NationalTeam = "Egypt", TeamId = 2, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 213, Name = "Abdallah El Said", Position = "Midfielder", Age = 40, NationalTeam = "Egypt", TeamId = 2, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 214, Name = "Nabil Dunga", Position = "Midfielder", Age = 29, NationalTeam = "Egypt", TeamId = 2, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 215, Name = "Mohamed Shehata", Position = "Midfielder", Age = 24, NationalTeam = "Egypt", TeamId = 2, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 216, Name = "Naser Maher", Position = "Midfielder", Age = 28, NationalTeam = "Egypt", TeamId = 2, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 217, Name = "Ahmed Abdelrahim", Position = "Midfielder", Age = 22, NationalTeam = "Egypt", TeamId = 2, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 218, Name = "Seif Farouk Gaafar", Position = "Midfielder", Age = 25, NationalTeam = "Egypt", TeamId = 2, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 219, Name = "Ahmed Rabie", Position = "Midfielder", Age = 24, NationalTeam = "Egypt", TeamId = 2, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 220, Name = "Mohamed El Sayed", Position = "Midfielder", Age = 19, NationalTeam = "Egypt", TeamId = 2, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 221, Name = "Mahmoud Jihad", Position = "Midfielder", Age = 24, NationalTeam = "Egypt", TeamId = 2, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 222, Name = "A. Maâli", Position = "Midfielder", Age = 19, NationalTeam = "Morocco", TeamId = 2, ImageUrl = "/images/players/default.png" },

      new Player { PlayerId = 223, Name = "Seifeddine Jaziri", Position = "Forward", Age = 32, NationalTeam = "Tunisia", TeamId = 2, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 224, Name = "Naser Mansi", Position = "Forward", Age = 27, NationalTeam = "Egypt", TeamId = 2, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 225, Name = "Ahmed Sherif", Position = "Forward", Age = 22, NationalTeam = "Egypt", TeamId = 2, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 226, Name = "Amr Nasser", Position = "Forward", Age = 26, NationalTeam = "Egypt", TeamId = 2, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 227, Name = "Juan Alvina", Position = "Forward", Age = 22, NationalTeam = "Brazil", TeamId = 2, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 228, Name = "Oday Dabbagh", Position = "Forward", Age = 26, NationalTeam = "Palestine", TeamId = 2, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 229, Name = "Hazem Ali", Position = "Forward", Age = 21, NationalTeam = "Egypt", TeamId = 2, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 230, Name = "O. Faraj", Position = "Forward", Age = 23, NationalTeam = "Palestine", TeamId = 2, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 231, Name = "A. Kaied", Position = "Forward", Age = 23, NationalTeam = "Palestine", TeamId = 2, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 232, Name = "Chico", Position = "Forward", Age = 26, NationalTeam = "Angola", TeamId = 2, ImageUrl = "/images/players/default.png" }
  );


            modelBuilder.Entity<Player>().HasData(
     new Player { PlayerId = 400, Name = "Essam Tharwat", Position = "Goalkeeper", Age = 36, NationalTeam = "Egypt", TeamId = 4, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 401, Name = "Mohamed Shehata", Position = "Goalkeeper", Age = 26, NationalTeam = "Egypt", TeamId = 4, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 402, Name = "Mahmoud Hamdy", Position = "Goalkeeper", Age = 32, NationalTeam = "Egypt", TeamId = 4, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },

     new Player { PlayerId = 403, Name = "Karim Al Iraqi", Position = "Defender", Age = 28, NationalTeam = "Egypt", TeamId = 4, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 404, Name = "Bahr El Mohamady", Position = "Defender", Age = 29, NationalTeam = "Egypt", TeamId = 4, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 405, Name = "Amr El Saadawy", Position = "Defender", Age = 28, NationalTeam = "Egypt", TeamId = 4, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 406, Name = "Ahmed Ayman Mansour", Position = "Defender", Age = 31, NationalTeam = "Egypt", TeamId = 4, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 407, Name = "Ahmed Eid", Position = "Defender", Age = 24, NationalTeam = "Egypt", TeamId = 4, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 408, Name = "Mohamed Hashem", Position = "Defender", Age = 30, NationalTeam = "Egypt", TeamId = 4, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 409, Name = "Khaled Sobhy", Position = "Defender", Age = 30, NationalTeam = "Egypt", TeamId = 4, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },

     new Player { PlayerId = 410, Name = "Youssef El Gohary", Position = "Midfielder", Age = 28, NationalTeam = "Egypt", TeamId = 4, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 411, Name = "Hassan Ali", Position = "Midfielder", Age = 28, NationalTeam = "Egypt", TeamId = 4, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 412, Name = "M. Temine", Position = "Midfielder", Age = 24, NationalTeam = "Algeria", TeamId = 4, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 413, Name = "Hussein Faisal", Position = "Midfielder", Age = 26, NationalTeam = "Egypt", TeamId = 4, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 414, Name = "Mahmoud Hamada", Position = "Midfielder", Age = 31, NationalTeam = "Egypt", TeamId = 4, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 415, Name = "Mido Gaber", Position = "Midfielder", Age = 33, NationalTeam = "Egypt", TeamId = 4, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 416, Name = "Ahmed Ali", Position = "Midfielder", Age = 25, NationalTeam = "Egypt", TeamId = 4, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 417, Name = "Ziad Farag", Position = "Midfielder", Age = 23, NationalTeam = "Egypt", TeamId = 4, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 418, Name = "Mohamed Makhlouf", Position = "Midfielder", Age = 27, NationalTeam = "Egypt", TeamId = 4, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 419, Name = "Ahmed El Karmouty", Position = "Midfielder", Age = 32, NationalTeam = "Egypt", TeamId = 4, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 420, Name = "Mostafa Abu Elkhir", Position = "Midfielder", Age = 21, NationalTeam = "Egypt", TeamId = 4, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 421, Name = "Omar El Saai", Position = "Midfielder", Age = 22, NationalTeam = "Egypt", TeamId = 4, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 422, Name = "B. Mugisha", Position = "Midfielder", Age = 25, NationalTeam = "Rwanda", TeamId = 4, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },

     new Player { PlayerId = 423, Name = "Abdelrahman Dghomoum", Position = "Forward", Age = 26, NationalTeam = "Algeria", TeamId = 4, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 424, Name = "Mohamed El Shamy", Position = "Forward", Age = 29, NationalTeam = "Egypt", TeamId = 4, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 425, Name = "Salah Mohsen", Position = "Forward", Age = 27, NationalTeam = "Egypt", TeamId = 4, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 426, Name = "Lestowell Amankona", Position = "Forward", Age = 20, NationalTeam = "Ghana", TeamId = 4, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 427, Name = "Karim Bambo", Position = "Forward", Age = 32, NationalTeam = "Egypt", TeamId = 4, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 428, Name = "Ahmed Sharaf", Position = "Forward", Age = 20, NationalTeam = "Egypt", TeamId = 4, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 429, Name = "Ahmed Fouad", Position = "Forward", Age = 21, NationalTeam = "Egypt", TeamId = 4, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" }
 );

            modelBuilder.Entity<Player>().HasData(
     new Player { PlayerId = 430, Name = "Ahmed Sobhi", Position = "Goalkeeper", Age = 31, NationalTeam = "Egypt", TeamId = 5, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 431, Name = "Abdelaziz Belawty", Position = "Goalkeeper", Age = 31, NationalTeam = "Egypt", TeamId = 5, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 432, Name = "Ahmed Suleiman", Position = "Goalkeeper", Age = 25, NationalTeam = "Egypt", TeamId = 5, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },

     new Player { PlayerId = 433, Name = "Mahmoud Elgazar", Position = "Defender", Age = 27, NationalTeam = "Egypt", TeamId = 5, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 434, Name = "Ishaku Yaqubu", Position = "Defender", Age = 31, NationalTeam = "Ghana", TeamId = 5, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 435, Name = "Mousa Alfarawi", Position = "Defender", Age = 27, NationalTeam = "Palestine", TeamId = 5, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 436, Name = "Amir Medhat", Position = "Defender", Age = 34, NationalTeam = "Egypt", TeamId = 5, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 437, Name = "Ahmed Meteb", Position = "Defender", Age = 29, NationalTeam = "Egypt", TeamId = 5, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 438, Name = "Amr El Gazar", Position = "Defender", Age = 26, NationalTeam = "Egypt", TeamId = 5, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 439, Name = "Ramy Hesham", Position = "Defender", Age = 28, NationalTeam = "Egypt", TeamId = 5, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 440, Name = "Khaled Shefo", Position = "Defender", Age = 31, NationalTeam = "Egypt", TeamId = 5, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 441, Name = "Cyrille Dao", Position = "Defender", Age = 20, NationalTeam = "Burkina Faso", TeamId = 5, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 442, Name = "Mostafa Awad", Position = "Defender", Age = 26, NationalTeam = "Egypt", TeamId = 5, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },

     new Player { PlayerId = 443, Name = "Mahmoud Emad", Position = "Midfielder", Age = 27, NationalTeam = "Egypt", TeamId = 5, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 444, Name = "Ahmed Madbouly", Position = "Midfielder", Age = 31, NationalTeam = "Egypt", TeamId = 5, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 445, Name = "Mostafa Adel", Position = "Midfielder", Age = 26, NationalTeam = "Egypt", TeamId = 5, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 446, Name = "Mohamed Mahmoud", Position = "Midfielder", Age = 31, NationalTeam = "Egypt", TeamId = 5, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 447, Name = "Said Simbory", Position = "Midfielder", Age = 33, NationalTeam = "Burkina Faso", TeamId = 5, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 448, Name = "Mohamed Ashraf", Position = "Midfielder", Age = 24, NationalTeam = "Egypt", TeamId = 5, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 449, Name = "Mohamed Ibrahim", Position = "Midfielder", Age = 33, NationalTeam = "Egypt", TeamId = 5, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 450, Name = "Mostafa Shalaby", Position = "Midfielder", Age = 31, NationalTeam = "Egypt", TeamId = 5, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },

     new Player { PlayerId = 451, Name = "Ahmed Al Nadry", Position = "Forward", Age = 26, NationalTeam = "Egypt", TeamId = 5, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 452, Name = "Yao Anwar", Position = "Forward", Age = 28, NationalTeam = "Togo", TeamId = 5, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 453, Name = "Mostafa Rahim", Position = "Forward", Age = 24, NationalTeam = "Egypt", TeamId = 5, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 454, Name = "Ahmed Amin Qaffa", Position = "Forward", Age = 29, NationalTeam = "Egypt", TeamId = 5, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 455, Name = "Osama Faisal", Position = "Forward", Age = 24, NationalTeam = "Egypt", TeamId = 5, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 456, Name = "Yousri Wahid", Position = "Forward", Age = 27, NationalTeam = "Egypt", TeamId = 5, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 457, Name = "Ahmed Yasser Rayan", Position = "Forward", Age = 27, NationalTeam = "Egypt", TeamId = 5, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 458, Name = "Sayed Neymar", Position = "Forward", Age = 25, NationalTeam = "Egypt", TeamId = 5, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 459, Name = "Omar Yassin Dombia", Position = "Forward", Age = 23, NationalTeam = "Guinea", TeamId = 5, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 460, Name = "Hassan Ahmed", Position = "Forward", Age = 22, NationalTeam = "Egypt", TeamId = 5, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" }
 );

            modelBuilder.Entity<Player>().HasData(
      // Goalkeepers
      new Player { PlayerId = 461, Name = "Mohamed Bassam", Position = "Goalkeeper", Age = 35, NationalTeam = "Egypt", TeamId = 6, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 462, Name = "Islam Resha", Position = "Goalkeeper", Age = 28, NationalTeam = "Egypt", TeamId = 6, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 463, Name = "Mohamed Koko", Position = "Goalkeeper", Age = 34, NationalTeam = "Egypt", TeamId = 6, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 464, Name = "Mohamed Tarek", Position = "Goalkeeper", Age = 26, NationalTeam = "Egypt", TeamId = 6, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },

      // Defenders
      new Player { PlayerId = 465, Name = "Ahmed Hany", Position = "Defender", Age = 28, NationalTeam = "Egypt", TeamId = 6, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 466, Name = "Ragab Nabil", Position = "Defender", Age = 32, NationalTeam = "Egypt", TeamId = 6, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 467, Name = "Mohamed El Maghraby", Position = "Defender", Age = 24, NationalTeam = "Egypt", TeamId = 6, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 468, Name = "Saad Samir", Position = "Defender", Age = 36, NationalTeam = "Egypt", TeamId = 6, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 469, Name = "Hussein El Sayed", Position = "Defender", Age = 34, NationalTeam = "Egypt", TeamId = 6, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 470, Name = "Khaled Abdel Fattah", Position = "Defender", Age = 26, NationalTeam = "Egypt", TeamId = 6, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 471, Name = "Karim El Debis", Position = "Defender", Age = 22, NationalTeam = "Egypt", TeamId = 6, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 472, Name = "Youssef Gamal", Position = "Defender", Age = 0, NationalTeam = "Egypt", TeamId = 6, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },

      // Midfielders
      new Player { PlayerId = 473, Name = "Mohamed Adel", Position = "Midfielder", Age = 30, NationalTeam = "Egypt", TeamId = 6, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 474, Name = "Amr Qalawa", Position = "Midfielder", Age = 28, NationalTeam = "Egypt", TeamId = 6, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 475, Name = "Justice Arthur", Position = "Midfielder", Age = 27, NationalTeam = "Ghana", TeamId = 6, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 476, Name = "Ahmed Belhaj", Position = "Midfielder", Age = 28, NationalTeam = "Morocco", TeamId = 6, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 477, Name = "Ibrahim Mohamed", Position = "Midfielder", Age = 25, NationalTeam = "Egypt", TeamId = 6, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 478, Name = "Ahmed Samir Mohamed", Position = "Midfielder", Age = 31, NationalTeam = "Egypt", TeamId = 6, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 479, Name = "Mohamed Faiz", Position = "Midfielder", Age = 22, NationalTeam = "Egypt", TeamId = 6, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 480, Name = "Abdullah Magdy", Position = "Midfielder", Age = 28, NationalTeam = "Egypt", TeamId = 6, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 481, Name = "Mohamed Sadeq", Position = "Midfielder", Age = 28, NationalTeam = "Egypt", TeamId = 6, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 482, Name = "Mohamed Reda", Position = "Midfielder", Age = 23, NationalTeam = "Egypt", TeamId = 6, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 483, Name = "Mohamed Abou El Amayem", Position = "Midfielder", Age = 27, NationalTeam = "Egypt", TeamId = 6, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 484, Name = "Amr El Solia", Position = "Midfielder", Age = 35, NationalTeam = "Egypt", TeamId = 6, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 485, Name = "Karim Nedved", Position = "Midfielder", Age = 28, NationalTeam = "Egypt", TeamId = 6, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 486, Name = "Youssef Baour", Position = "Midfielder", Age = 22, NationalTeam = "Egypt", TeamId = 6, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },

      // Forwards
      new Player { PlayerId = 487, Name = "Fajri Lakay", Position = "Forward", Age = 28, NationalTeam = "South Africa", TeamId = 6, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 488, Name = "Islam Eissa", Position = "Forward", Age = 29, NationalTeam = "Egypt", TeamId = 6, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 489, Name = "Marwan Osman", Position = "Forward", Age = 23, NationalTeam = "Egypt", TeamId = 6, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 490, Name = "Ayman Moka", Position = "Forward", Age = 28, NationalTeam = "Egypt", TeamId = 6, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 491, Name = "Ahmed Ashraf", Position = "Forward", Age = 21, NationalTeam = "Egypt", TeamId = 6, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 492, Name = "Sadiq Oguola", Position = "Forward", Age = 25, NationalTeam = "Nigeria", TeamId = 6, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" }
  );

            modelBuilder.Entity<Player>().HasData(
     // Goalkeepers
     new Player { PlayerId = 493, Name = "Mohamed Saeed Shika", Position = "Goalkeeper", Age = 32, NationalTeam = "Egypt", TeamId = 7, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 494, Name = "Sabry Gad", Position = "Goalkeeper", Age = 23, NationalTeam = "Egypt", TeamId = 7, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 495, Name = "Fares El Sayed", Position = "Goalkeeper", Age = 24, NationalTeam = "Egypt", TeamId = 7, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 496, Name = "Mohamed Nadim", Position = "Goalkeeper", Age = 24, NationalTeam = "Egypt", TeamId = 7, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },

     // Defenders
     new Player { PlayerId = 497, Name = "Azmi Ghouma", Position = "Defender", Age = 27, NationalTeam = "Tunisia", TeamId = 7, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 498, Name = "Ramy Sabry", Position = "Defender", Age = 38, NationalTeam = "Egypt", TeamId = 7, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 499, Name = "Gaber Kamel", Position = "Defender", Age = 30, NationalTeam = "Egypt", TeamId = 7, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 500, Name = "Ahmed El Bahrawy", Position = "Defender", Age = 30, NationalTeam = "Egypt", TeamId = 7, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 501, Name = "Yassin Marei", Position = "Defender", Age = 24, NationalTeam = "Egypt", TeamId = 7, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 502, Name = "Mahmoud El Badry", Position = "Defender", Age = 34, NationalTeam = "Egypt", TeamId = 7, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 503, Name = "Babacar Ndiaye", Position = "Defender", Age = 21, NationalTeam = "Senegal", TeamId = 7, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 504, Name = "Ahmed Gamal", Position = "Defender", Age = 31, NationalTeam = "Egypt", TeamId = 7, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 505, Name = "Yassin El Mallah", Position = "Defender", Age = 0, NationalTeam = "Egypt", TeamId = 7, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 506, Name = "Seif Emam", Position = "Defender", Age = 21, NationalTeam = "Egypt", TeamId = 7, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },

     // Midfielders
     new Player { PlayerId = 507, Name = "Ahmed Fouad", Position = "Midfielder", Age = 26, NationalTeam = "Egypt", TeamId = 7, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 508, Name = "Mohamed Fakhry", Position = "Midfielder", Age = 26, NationalTeam = "Egypt", TeamId = 7, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 509, Name = "Enock Benjamin Tola", Position = "Midfielder", Age = 23, NationalTeam = "Angola", TeamId = 7, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 510, Name = "Abdellrhman Al Ashry", Position = "Midfielder", Age = 24, NationalTeam = "Egypt", TeamId = 7, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 511, Name = "Khalil Neymar Haggi", Position = "Midfielder", Age = 27, NationalTeam = "Egypt", TeamId = 7, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 512, Name = "Mahmoud Farahat", Position = "Midfielder", Age = 22, NationalTeam = "Egypt", TeamId = 7, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 513, Name = "Mazen Adel", Position = "Midfielder", Age = 22, NationalTeam = "Egypt", TeamId = 7, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },

     // Forwards
     new Player { PlayerId = 514, Name = "Walid Mostafa", Position = "Forward", Age = 25, NationalTeam = "Egypt", TeamId = 7, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 515, Name = "Salah Basha", Position = "Forward", Age = 22, NationalTeam = "Egypt", TeamId = 7, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 516, Name = "Mohamed Ezz", Position = "Forward", Age = 22, NationalTeam = "Egypt", TeamId = 7, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 517, Name = "Seif El Deen Rafik", Position = "Forward", Age = 24, NationalTeam = "Egypt", TeamId = 7, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 518, Name = "Zed El Matraji", Position = "Forward", Age = 29, NationalTeam = "Morocco", TeamId = 7, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 519, Name = "Zeyad Tolba", Position = "Forward", Age = 24, NationalTeam = "Egypt", TeamId = 7, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 520, Name = "Seif El Din Malik Bakhit", Position = "Forward", Age = 31, NationalTeam = "Sudan", TeamId = 7, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" }
 );

            modelBuilder.Entity<Player>().HasData(
    // Goalkeepers
    new Player { PlayerId = 521, Name = "Ragab Abdelkafi", Position = "Goalkeeper", Age = 30, NationalTeam = "Egypt", TeamId = 8, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 522, Name = "Omar Mohamed", Position = "Goalkeeper", Age = 27, NationalTeam = "Egypt", TeamId = 8, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 523, Name = "Mohamed Khalifa", Position = "Goalkeeper", Age = 22, NationalTeam = "Egypt", TeamId = 8, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },

    // Defenders
    new Player { PlayerId = 524, Name = "Mahmoud Shedid", Position = "Defender", Age = 34, NationalTeam = "Egypt", TeamId = 8, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 525, Name = "Hadi Riyad", Position = "Defender", Age = 27, NationalTeam = "Egypt", TeamId = 8, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 526, Name = "Ahmed Bahbah", Position = "Defender", Age = 32, NationalTeam = "Egypt", TeamId = 8, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 527, Name = "Ahmed Yassin", Position = "Defender", Age = 28, NationalTeam = "Egypt", TeamId = 8, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 528, Name = "Islam Abdallah", Position = "Defender", Age = 22, NationalTeam = "Egypt", TeamId = 8, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 529, Name = "Ahmed Ghoneim", Position = "Defender", Age = 26, NationalTeam = "Egypt", TeamId = 8, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 530, Name = "Momen Atef", Position = "Defender", Age = 31, NationalTeam = "Egypt", TeamId = 8, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 531, Name = "Barakat Haggag", Position = "Defender", Age = 28, NationalTeam = "Egypt", TeamId = 8, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 532, Name = "Mahmoud Morsi", Position = "Defender", Age = 0, NationalTeam = "Egypt", TeamId = 8, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },

    // Midfielders
    new Player { PlayerId = 533, Name = "Mostafa El Gamal", Position = "Midfielder", Age = 28, NationalTeam = "Egypt", TeamId = 8, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 534, Name = "Mohamed Osman", Position = "Midfielder", Age = 27, NationalTeam = "Egypt", TeamId = 8, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 535, Name = "Adham Hamed", Position = "Midfielder", Age = 25, NationalTeam = "Egypt", TeamId = 8, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 536, Name = "Hamed Hamdan", Position = "Midfielder", Age = 25, NationalTeam = "Palestine", TeamId = 8, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 537, Name = "Amadou Bah", Position = "Midfielder", Age = 21, NationalTeam = "Guinea", TeamId = 8, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 538, Name = "Mostafa El Badry", Position = "Midfielder", Age = 27, NationalTeam = "Egypt", TeamId = 8, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },

    // Forwards
    new Player { PlayerId = 539, Name = "Badr Youssef", Position = "Forward", Age = 26, NationalTeam = "Palestine", TeamId = 8, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 540, Name = "Rashid Ahmed", Position = "Forward", Age = 25, NationalTeam = "Nigeria", TeamId = 8, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 541, Name = "Jibril Shikodi", Position = "Forward", Age = 22, NationalTeam = "Nigeria", TeamId = 8, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 542, Name = "Tawfik Mohamed", Position = "Forward", Age = 26, NationalTeam = "Egypt", TeamId = 8, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 543, Name = "Mohamed Ibrahim Dodo", Position = "Forward", Age = 22, NationalTeam = "Egypt", TeamId = 8, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 544, Name = "Omar Reda", Position = "Forward", Age = 22, NationalTeam = "Egypt", TeamId = 8, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 545, Name = "Samir Mohamed", Position = "Forward", Age = 22, NationalTeam = "Egypt", TeamId = 8, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" }
);

            modelBuilder.Entity<Player>().HasData(
      // Goalkeepers
      new Player { PlayerId = 546, Name = "Aiman Orabi", Position = "Goalkeeper", Age = 28, NationalTeam = "Egypt", TeamId = 9, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 547, Name = "Mahmoud El Zenfaly", Position = "Goalkeeper", Age = 33, NationalTeam = "Egypt", TeamId = 9, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 548, Name = "Amr Shaaban", Position = "Goalkeeper", Age = 32, NationalTeam = "Egypt", TeamId = 9, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 549, Name = "Adham Seha", Position = "Goalkeeper", Age = 0, NationalTeam = "Egypt", TeamId = 9, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },

      // Defenders
      new Player { PlayerId = 550, Name = "Ehab Samir", Position = "Defender", Age = 32, NationalTeam = "Egypt", TeamId = 9, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 551, Name = "Momen Awad", Position = "Defender", Age = 24, NationalTeam = "Egypt", TeamId = 9, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 552, Name = "Ibrahim Abdel Hakeem", Position = "Defender", Age = 22, NationalTeam = "Egypt", TeamId = 9, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 553, Name = "Youssef Atef", Position = "Defender", Age = 22, NationalTeam = "Egypt", TeamId = 9, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 554, Name = "Kwasi Kwadja", Position = "Defender", Age = 30, NationalTeam = "Côte dIvoire", TeamId = 9, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 555, Name = "Mohamed Abd El Salam", Position = "Defender", Age = 28, NationalTeam = "Egypt", TeamId = 9, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 556, Name = "Moataz El Sayed", Position = "Defender", Age = 20, NationalTeam = "Egypt", TeamId = 9, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 557, Name = "Mahmoud El Badry", Position = "Defender", Age = 26, NationalTeam = "Egypt", TeamId = 9, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },

      // Midfielders
      new Player { PlayerId = 558, Name = "Mohamed Magly", Position = "Midfielder", Age = 31, NationalTeam = "Egypt", TeamId = 9, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 559, Name = "Easy Emika", Position = "Midfielder", Age = 33, NationalTeam = "Nigeria", TeamId = 9, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 560, Name = "Mohamed Gaber", Position = "Midfielder", Age = 35, NationalTeam = "Egypt", TeamId = 9, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 561, Name = "A Oubeid", Position = "Midfielder", Age = 25, NationalTeam = "Mauritania", TeamId = 9, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 562, Name = "Mohamed Bayoumi", Position = "Midfielder", Age = 25, NationalTeam = "Egypt", TeamId = 9, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 563, Name = "Omar Fathy Saviola", Position = "Midfielder", Age = 31, NationalTeam = "Egypt", TeamId = 9, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 564, Name = "Ismail Ashraf", Position = "Midfielder", Age = 26, NationalTeam = "Egypt", TeamId = 9, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 565, Name = "Mohamed El Daghimi", Position = "Midfielder", Age = 32, NationalTeam = "Egypt", TeamId = 9, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 566, Name = "Islam Abu Salema", Position = "Midfielder", Age = 32, NationalTeam = "Egypt", TeamId = 9, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 567, Name = "Fawzi El Hanawy", Position = "Midfielder", Age = 27, NationalTeam = "Egypt", TeamId = 9, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 568, Name = "Mohamed Ashraf Rouka", Position = "Midfielder", Age = 32, NationalTeam = "Egypt", TeamId = 9, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 569, Name = "Mahmoud Said Oka", Position = "Midfielder", Age = 22, NationalTeam = "Egypt", TeamId = 9, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 570, Name = "Badr El Sayed", Position = "Midfielder", Age = 22, NationalTeam = "Egypt", TeamId = 9, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 571, Name = "Ahmed El Sheikh", Position = "Midfielder", Age = 35, NationalTeam = "Egypt", TeamId = 9, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },

      // Forwards
      new Player { PlayerId = 572, Name = "N Ikechukwu", Position = "Forward", Age = 27, NationalTeam = "Nigeria", TeamId = 9, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 573, Name = "Amr Gamal", Position = "Forward", Age = 34, NationalTeam = "Egypt", TeamId = 9, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 574, Name = "Mohamed Mostafa", Position = "Forward", Age = 23, NationalTeam = "Egypt", TeamId = 9, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 575, Name = "Mohamed Farouk", Position = "Forward", Age = 36, NationalTeam = "Egypt", TeamId = 9, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 576, Name = "Damilola Emmanuel", Position = "Forward", Age = 20, NationalTeam = "Nigeria", TeamId = 9, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" }
      );



            modelBuilder.Entity<Player>().HasData(
    // Goalkeepers
    new Player { PlayerId = 578, Name = "Ali Lotfi", Position = "Goalkeeper", Age = 35, NationalTeam = "Egypt", TeamId = 10, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 579, Name = "Mohamed Mezika", Position = "Goalkeeper", Age = 30, NationalTeam = "Egypt", TeamId = 10, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 580, Name = "Abdelmonem Tamer", Position = "Goalkeeper", Age = 19, NationalTeam = "Egypt", TeamId = 10, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },

    // Defenders
    new Player { PlayerId = 581, Name = "Ali Gamal", Position = "Defender", Age = 25, NationalTeam = "Egypt", TeamId = 10, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 582, Name = "Ahmed Tarek", Position = "Defender", Age = 34, NationalTeam = "Egypt", TeamId = 10, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 583, Name = "Sameh Ibrahim", Position = "Defender", Age = 27, NationalTeam = "Egypt", TeamId = 10, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 584, Name = "Mohamed Samir", Position = "Defender", Age = 36, NationalTeam = "Egypt", TeamId = 10, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 585, Name = "Ahmed El Sayed Abdel Nabi", Position = "Defender", Age = 21, NationalTeam = "Egypt", TeamId = 10, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 586, Name = "Mohamed Ashraf", Position = "Defender", Age = 22, NationalTeam = "Egypt", TeamId = 10, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 587, Name = "Mostafa El Esh", Position = "Defender", Age = 23, NationalTeam = "Egypt", TeamId = 10, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 588, Name = "Ahmed Zaki", Position = "Defender", Age = 25, NationalTeam = "Egypt", TeamId = 10, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },

    // Midfielders
    new Player { PlayerId = 589, Name = "Abdelrahman Emad", Position = "Midfielder", Age = 25, NationalTeam = "Egypt", TeamId = 10, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 590, Name = "Ahmed Soghairi", Position = "Midfielder", Age = 26, NationalTeam = "Egypt", TeamId = 10, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 591, Name = "Peter Zelo Motomusi", Position = "Midfielder", Age = 26, NationalTeam = "DR Congo", TeamId = 10, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 592, Name = "Hamdy Abdel Maati", Position = "Midfielder", Age = 23, NationalTeam = "Egypt", TeamId = 10, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 593, Name = "Mohamed Suanieh", Position = "Midfielder", Age = 20, NationalTeam = "Gambia", TeamId = 10, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 594, Name = "Mata Majasa", Position = "Midfielder", Age = 20, NationalTeam = "Mauritania", TeamId = 10, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 595, Name = "Amar Hamdy", Position = "Midfielder", Age = 25, NationalTeam = "Egypt", TeamId = 10, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 596, Name = "Mahmoud Nabil", Position = "Midfielder", Age = 26, NationalTeam = "Egypt", TeamId = 10, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 597, Name = "Mohamed Hamdy", Position = "Midfielder", Age = 33, NationalTeam = "Egypt", TeamId = 10, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 598, Name = "Abdel Hameed Ahmed", Position = "Midfielder", Age = 32, NationalTeam = "Egypt", TeamId = 10, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 599, Name = "Marwan Mahmoud", Position = "Midfielder", Age = 31, NationalTeam = "Egypt", TeamId = 10, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },

    // Forwards
    new Player { PlayerId = 600, Name = "Y Rafael", Position = "Forward", Age = 25, NationalTeam = "Rwanda", TeamId = 10, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 601, Name = "Ahmed Adel", Position = "Forward", Age = 27, NationalTeam = "Egypt", TeamId = 10, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 602, Name = "Abel Yalo", Position = "Forward", Age = 28, NationalTeam = "Ethiopia", TeamId = 10, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 603, Name = "Mostafa Saad Messi", Position = "Forward", Age = 22, NationalTeam = "Egypt", TeamId = 10, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 604, Name = "Shady Hussein", Position = "Forward", Age = 30, NationalTeam = "Egypt", TeamId = 10, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 605, Name = "Abdelrahman El Banoubi", Position = "Forward", Age = 23, NationalTeam = "Egypt", TeamId = 10, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 606, Name = "Omar Amin", Position = "Forward", Age = 23, NationalTeam = "Egypt", TeamId = 10, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 607, Name = "Mohsni Malima", Position = "Forward", Age = 23, NationalTeam = "Tanzania", TeamId = 10, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" }
);

            modelBuilder.Entity<Player>().HasData(
                // Goalkeepers
                new Player { PlayerId = 608, Name = "Ahmed Masoud", Position = "Goalkeeper", Age = 32, NationalTeam = "Egypt", TeamId = 11, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
                new Player { PlayerId = 609, Name = "Mohamed Alaa", Position = "Goalkeeper", Age = 24, NationalTeam = "Egypt", TeamId = 11, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
                new Player { PlayerId = 610, Name = "Hassan Mahmoud", Position = "Goalkeeper", Age = 30, NationalTeam = "Egypt", TeamId = 11, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },

                // Defenders
                new Player { PlayerId = 611, Name = "Ahmed El Esh", Position = "Defender", Age = 25, NationalTeam = "Egypt", TeamId = 11, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
                new Player { PlayerId = 612, Name = "Ahmed Abd El Rasoul", Position = "Defender", Age = 28, NationalTeam = "Egypt", TeamId = 11, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
                new Player { PlayerId = 613, Name = "Aliou Gatta", Position = "Defender", Age = 28, NationalTeam = "Gambia", TeamId = 11, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
                new Player { PlayerId = 614, Name = "Ahmed Shosha", Position = "Defender", Age = 30, NationalTeam = "Egypt", TeamId = 11, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
                new Player { PlayerId = 615, Name = "Abdelgawad Taleb", Position = "Defender", Age = 21, NationalTeam = "Egypt", TeamId = 11, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },

                // Midfielders
                new Player { PlayerId = 616, Name = "Noor El Sayed", Position = "Midfielder", Age = 39, NationalTeam = "Egypt", TeamId = 11, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
                new Player { PlayerId = 617, Name = "Mohamed Mahmoud", Position = "Midfielder", Age = 25, NationalTeam = "Egypt", TeamId = 11, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
                new Player { PlayerId = 618, Name = "Mahmoud Hassouna", Position = "Midfielder", Age = 26, NationalTeam = "Egypt", TeamId = 11, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
                new Player { PlayerId = 619, Name = "Mohamed Emad", Position = "Midfielder", Age = 22, NationalTeam = "Egypt", TeamId = 11, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
                new Player { PlayerId = 620, Name = "Bilal El Sayed", Position = "Midfielder", Age = 23, NationalTeam = "Egypt", TeamId = 11, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
                new Player { PlayerId = 621, Name = "Reda Salah", Position = "Midfielder", Age = 25, NationalTeam = "Egypt", TeamId = 11, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
                new Player { PlayerId = 622, Name = "Hassan Yassin", Position = "Midfielder", Age = 27, NationalTeam = "Egypt", TeamId = 11, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
                new Player { PlayerId = 623, Name = "S Kabir", Position = "Midfielder", Age = 28, NationalTeam = "Nigeria", TeamId = 11, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
                new Player { PlayerId = 624, Name = "O Okoronkwo", Position = "Midfielder", Age = 20, NationalTeam = "Nigeria", TeamId = 11, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
                new Player { PlayerId = 625, Name = "Dominic Nsobila", Position = "Midfielder", Age = 22, NationalTeam = "Ghana", TeamId = 11, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },

                // Forwards
                new Player { PlayerId = 626, Name = "Arnaud Randrianantena", Position = "Forward", Age = 22, NationalTeam = "Madagascar", TeamId = 11, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
                new Player { PlayerId = 627, Name = "Mohamed El Nahas", Position = "Forward", Age = 21, NationalTeam = "Egypt", TeamId = 11, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
                new Player { PlayerId = 628, Name = "Mahmoud Ouksha", Position = "Forward", Age = 24, NationalTeam = "Egypt", TeamId = 11, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
                new Player { PlayerId = 629, Name = "Seif Shika", Position = "Forward", Age = 22, NationalTeam = "Egypt", TeamId = 11, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
                new Player { PlayerId = 630, Name = "Samuel Ojo", Position = "Forward", Age = 20, NationalTeam = "Nigeria", TeamId = 11, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
                new Player { PlayerId = 631, Name = "Ali El Zahabi", Position = "Forward", Age = 27, NationalTeam = "Egypt", TeamId = 11, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
                new Player { PlayerId = 632, Name = "T Oripelaye", Position = "Forward", Age = 20, NationalTeam = "Nigeria", TeamId = 11, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
                new Player { PlayerId = 633, Name = "Marwan Mohsen", Position = "Forward", Age = 34, NationalTeam = "Egypt", TeamId = 11, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
                new Player { PlayerId = 634, Name = "Mahmoud El Aaalamy", Position = "Forward", Age = 22, NationalTeam = "Egypt", TeamId = 11, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
                new Player { PlayerId = 635, Name = "Ahmed Yassin", Position = "Forward", Age = 29, NationalTeam = "France", TeamId = 11, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
                new Player { PlayerId = 636, Name = "Mazen Yasser", Position = "Forward", Age = 20, NationalTeam = "Egypt", TeamId = 11, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" }
            );


            modelBuilder.Entity<Player>().HasData(
     // Goalkeepers
     new Player { PlayerId = 637, Name = "Omar Radwan", Position = "Goalkeeper", Age = 26, NationalTeam = "Egypt", TeamId = 12, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 638, Name = "Mohamed Shaaban", Position = "Goalkeeper", Age = 29, NationalTeam = "Egypt", TeamId = 12, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 639, Name = "Mohamed Magdy Abd El Fattah", Position = "Goalkeeper", Age = 28, NationalTeam = "Egypt", TeamId = 12, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 640, Name = "Emad El Sayed", Position = "Goalkeeper", Age = 37, NationalTeam = "Egypt", TeamId = 12, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 641, Name = "Ahmed Abass", Position = "Goalkeeper", Age = 21, NationalTeam = "Egypt", TeamId = 12, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },

     // Defenders
     new Player { PlayerId = 642, Name = "Khaled Satouhi", Position = "Defender", Age = 34, NationalTeam = "Egypt", TeamId = 12, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 643, Name = "Amr Tarek", Position = "Defender", Age = 31, NationalTeam = "Egypt", TeamId = 12, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 644, Name = "Moamen Mahmoud", Position = "Defender", Age = 21, NationalTeam = "Egypt", TeamId = 12, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 645, Name = "Mohamed Fathallah", Position = "Defender", Age = 30, NationalTeam = "Egypt", TeamId = 12, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 646, Name = "Ahmed Ala El Din", Position = "Defender", Age = 29, NationalTeam = "Egypt", TeamId = 12, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 647, Name = "Mahmoud Abdel Aziz", Position = "Defender", Age = 21, NationalTeam = "Egypt", TeamId = 12, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 648, Name = "A Keita", Position = "Defender", Age = 21, NationalTeam = "Guinea", TeamId = 12, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },

     // Midfielders
     new Player { PlayerId = 649, Name = "Hassan Magdy", Position = "Midfielder", Age = 32, NationalTeam = "Egypt", TeamId = 12, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 650, Name = "Ahmed Abd El Rahman Zola", Position = "Midfielder", Age = 30, NationalTeam = "Egypt", TeamId = 12, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 651, Name = "Hamed Khaled", Position = "Midfielder", Age = 24, NationalTeam = "Egypt", TeamId = 12, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 652, Name = "Mostafa El Khawaga", Position = "Midfielder", Age = 30, NationalTeam = "Egypt", TeamId = 12, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 653, Name = "Khaled Mohamed Awad", Position = "Midfielder", Age = 21, NationalTeam = "Egypt", TeamId = 12, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 654, Name = "Islam Mohareb", Position = "Midfielder", Age = 32, NationalTeam = "Egypt", TeamId = 12, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 655, Name = "Ali Hamdy", Position = "Midfielder", Age = 24, NationalTeam = "Egypt", TeamId = 12, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 656, Name = "Ragab Omran", Position = "Midfielder", Age = 30, NationalTeam = "Egypt", TeamId = 12, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 657, Name = "Ahmed Tarek", Position = "Midfielder", Age = 24, NationalTeam = "Egypt", TeamId = 12, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 658, Name = "Ghaith Al Madadha", Position = "Midfielder", Age = 24, NationalTeam = "Egypt", TeamId = 12, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 659, Name = "H Souissi", Position = "Midfielder", Age = 25, NationalTeam = "Tunisia", TeamId = 12, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },

     // Forwards
     new Player { PlayerId = 660, Name = "Karim Tarek", Position = "Forward", Age = 31, NationalTeam = "Egypt", TeamId = 12, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 661, Name = "Delson Kamoni", Position = "Forward", Age = 26, NationalTeam = "Angola", TeamId = 12, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 662, Name = "Fares Hatem", Position = "Forward", Age = 21, NationalTeam = "Egypt", TeamId = 12, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 663, Name = "Mohamed Hany", Position = "Forward", Age = 22, NationalTeam = "Egypt", TeamId = 12, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 664, Name = "Khaled Abo Ziada", Position = "Forward", Age = 31, NationalTeam = "Egypt", TeamId = 12, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 665, Name = "Mohamed Basiouny", Position = "Forward", Age = 22, NationalTeam = "Egypt", TeamId = 12, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 666, Name = "I Ouro Agoro", Position = "Forward", Age = 28, NationalTeam = "Togo", TeamId = 12, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 667, Name = "Mohamed Atef", Position = "Forward", Age = 21, NationalTeam = "Egypt", TeamId = 12, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" }
 );

            modelBuilder.Entity<Player>().HasData(
     // Goalkeepers
     new Player { PlayerId = 668, Name = "Ramadan Mostafa", Position = "Goalkeeper", Age = 25, NationalTeam = "Egypt", TeamId = 13, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 669, Name = "Abdel Rahman Samir", Position = "Goalkeeper", Age = 24, NationalTeam = "Egypt", TeamId = 13, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 670, Name = "Reda Sayed", Position = "Goalkeeper", Age = 36, NationalTeam = "Egypt", TeamId = 13, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },

     // Defenders
     new Player { PlayerId = 671, Name = "Hesham Adel", Position = "Defender", Age = 26, NationalTeam = "Egypt", TeamId = 13, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 672, Name = "Mohamed Samir", Position = "Defender", Age = 22, NationalTeam = "Egypt", TeamId = 13, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 673, Name = "Ahmed Sobeha", Position = "Defender", Age = 24, NationalTeam = "Egypt", TeamId = 13, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 674, Name = "Ahmed Khalil Ibrahim", Position = "Defender", Age = 25, NationalTeam = "Egypt", TeamId = 13, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 675, Name = "Hazem Ibrahim", Position = "Defender", Age = 26, NationalTeam = "Egypt", TeamId = 13, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 676, Name = "Abdullah Adel", Position = "Defender", Age = 22, NationalTeam = "Egypt", TeamId = 13, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 677, Name = "Mohamed Samir", Position = "Defender", Age = 17, NationalTeam = "Egypt", TeamId = 13, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 678, Name = "Fathi El Sayed", Position = "Defender", Age = 21, NationalTeam = "Egypt", TeamId = 13, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 679, Name = "Mohamed Hamdy", Position = "Defender", Age = 20, NationalTeam = "Egypt", TeamId = 13, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 680, Name = "Marwan Dawood", Position = "Defender", Age = 26, NationalTeam = "Egypt", TeamId = 13, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },

     // Midfielders
     new Player { PlayerId = 681, Name = "Ahmed El Agoz", Position = "Midfielder", Age = 30, NationalTeam = "Egypt", TeamId = 13, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 682, Name = "Mostafa Shakshak", Position = "Midfielder", Age = 23, NationalTeam = "Egypt", TeamId = 13, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 683, Name = "Mohamed Nasser", Position = "Midfielder", Age = 22, NationalTeam = "Egypt", TeamId = 13, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 684, Name = "Youssef Adel", Position = "Midfielder", Age = 18, NationalTeam = "Egypt", TeamId = 13, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 685, Name = "Mohamed Emad", Position = "Midfielder", Age = 22, NationalTeam = "Egypt", TeamId = 13, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 686, Name = "Ali Mahmoud", Position = "Midfielder", Age = 18, NationalTeam = "Egypt", TeamId = 13, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 687, Name = "Ziad Kamal", Position = "Midfielder", Age = 22, NationalTeam = "Egypt", TeamId = 13, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 688, Name = "Sayed Said", Position = "Midfielder", Age = 22, NationalTeam = "Egypt", TeamId = 13, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 689, Name = "Ahmed Ismail Kofta", Position = "Midfielder", Age = 22, NationalTeam = "Egypt", TeamId = 13, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },

     // Forwards
     new Player { PlayerId = 690, Name = "Rafiq Kabo", Position = "Forward", Age = 31, NationalTeam = "Tunisia", TeamId = 13, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 691, Name = "Youssef Labib", Position = "Forward", Age = 22, NationalTeam = "Egypt", TeamId = 13, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 692, Name = "Salah Zayed", Position = "Forward", Age = 23, NationalTeam = "Egypt", TeamId = 13, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 693, Name = "Ahmed Nader Hawash", Position = "Forward", Age = 20, NationalTeam = "Egypt", TeamId = 13, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 694, Name = "Mohamed Sherif", Position = "Forward", Age = 25, NationalTeam = "Egypt", TeamId = 13, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 695, Name = "Y Oubaba", Position = "Forward", Age = 28, NationalTeam = "Morocco", TeamId = 13, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 696, Name = "Youssef Ahmed Hassan", Position = "Forward", Age = 20, NationalTeam = "Egypt", TeamId = 13, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 697, Name = "Abdul Mudasiru", Position = "Forward", Age = 27, NationalTeam = "Ghana", TeamId = 13, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 698, Name = "Ali Ehab", Position = "Forward", Age = 19, NationalTeam = "Egypt", TeamId = 13, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 699, Name = "T Randrianarijaona", Position = "Forward", Age = 25, NationalTeam = "Madagascar", TeamId = 13, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 700, Name = "Hossam Ghanem", Position = "Forward", Age = 25, NationalTeam = "Egypt", TeamId = 13, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 701, Name = "Ahmed Zaki", Position = "Forward", Age = 21, NationalTeam = "Egypt", TeamId = 13, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 702, Name = "Mohamed Walid Gedo", Position = "Forward", Age = 20, NationalTeam = "Egypt", TeamId = 13, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 703, Name = "Hamed Abdallah", Position = "Forward", Age = 21, NationalTeam = "Egypt", TeamId = 13, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 704, Name = "Adel Fadaly", Position = "Forward", Age = 20, NationalTeam = "Egypt", TeamId = 13, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" }
 );


            modelBuilder.Entity<Player>().HasData(
     // Goalkeepers
     new Player { PlayerId = 705, Name = "Mahmoud Gennesh", Position = "Goalkeeper", Age = 36, NationalTeam = "Egypt", TeamId = 14, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 706, Name = "Sobhy Suleiman", Position = "Goalkeeper", Age = 25, NationalTeam = "Egypt", TeamId = 14, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 707, Name = "Youssef Nader El Shazly", Position = "Goalkeeper", Age = 22, NationalTeam = "Egypt", TeamId = 14, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },

     // Defenders
     new Player { PlayerId = 708, Name = "Mostafa Ibrahim", Position = "Defender", Age = 23, NationalTeam = "Egypt", TeamId = 14, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 709, Name = "Mahmoud Shabana", Position = "Defender", Age = 28, NationalTeam = "Egypt", TeamId = 14, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 710, Name = "Karim El Deeb", Position = "Defender", Age = 28, NationalTeam = "Egypt", TeamId = 14, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 711, Name = "Mahmoud Alaa El Din", Position = "Defender", Age = 32, NationalTeam = "Egypt", TeamId = 14, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 712, Name = "Mohamed Sami", Position = "Defender", Age = 22, NationalTeam = "Egypt", TeamId = 14, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 713, Name = "Momen Sherif", Position = "Defender", Age = 17, NationalTeam = "Egypt", TeamId = 14, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 714, Name = "Abdel Rahman Ramadan", Position = "Defender", Age = 30, NationalTeam = "Egypt", TeamId = 14, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 715, Name = "Ahmed Mahmoud", Position = "Defender", Age = 20, NationalTeam = "Egypt", TeamId = 14, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },

     // Midfielders
     new Player { PlayerId = 716, Name = "Nasser Nasser", Position = "Midfielder", Age = 28, NationalTeam = "Egypt", TeamId = 14, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 717, Name = "Mohamed Metwally Kanaria", Position = "Midfielder", Age = 25, NationalTeam = "Egypt", TeamId = 14, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 718, Name = "Amr Saleh", Position = "Midfielder", Age = 28, NationalTeam = "Egypt", TeamId = 14, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 719, Name = "Mohamed Tony", Position = "Midfielder", Age = 27, NationalTeam = "Egypt", TeamId = 14, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 720, Name = "Noor Alaa", Position = "Midfielder", Age = 21, NationalTeam = "Egypt", TeamId = 14, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 721, Name = "Isaac Saviour", Position = "Midfielder", Age = 22, NationalTeam = "Nigeria", TeamId = 14, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },

     // Forwards
     new Player { PlayerId = 722, Name = "Abdel Ghani Mohamed", Position = "Forward", Age = 22, NationalTeam = "Egypt", TeamId = 14, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 723, Name = "Fadi Farid", Position = "Forward", Age = 27, NationalTeam = "Egypt", TeamId = 14, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 724, Name = "Abu Bakr Lyadi", Position = "Forward", Age = 22, NationalTeam = "Nigeria", TeamId = 14, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 725, Name = "Ahmed Eid Abdel Nabi", Position = "Forward", Age = 27, NationalTeam = "Egypt", TeamId = 14, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 726, Name = "John Ibuka", Position = "Forward", Age = 28, NationalTeam = "Nigeria", TeamId = 14, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 727, Name = "Bikali Obami", Position = "Forward", Age = 20, NationalTeam = "Gabon", TeamId = 14, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 728, Name = "Favor Akim", Position = "Forward", Age = 19, NationalTeam = "Nigeria", TeamId = 14, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 729, Name = "Hisham Nabawy", Position = "Forward", Age = 27, NationalTeam = "Egypt", TeamId = 14, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 730, Name = "Islam Samir", Position = "Forward", Age = 25, NationalTeam = "Egypt", TeamId = 14, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 731, Name = "Amr Gomaa", Position = "Forward", Age = 24, NationalTeam = "Egypt", TeamId = 14, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" }
 );

            modelBuilder.Entity<Player>().HasData(
     // Goalkeepers
     new Player { PlayerId = 732, Name = "Ahmed Yehia", Position = "Goalkeeper", Age = 35, NationalTeam = "Egypt", TeamId = 15, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 733, Name = "Karim Emad", Position = "Goalkeeper", Age = 26, NationalTeam = "Egypt", TeamId = 15, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 734, Name = "Kamal El Sayed", Position = "Goalkeeper", Age = 24, NationalTeam = "Egypt", TeamId = 15, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 735, Name = "Mostafa Makhlouf", Position = "Goalkeeper", Age = 20, NationalTeam = "Egypt", TeamId = 15, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 736, Name = "Mohamed Abu Gabal", Position = "Goalkeeper", Age = 35, NationalTeam = "Egypt", TeamId = 15, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },

     // Defenders
     new Player { PlayerId = 737, Name = "Ali El Feel", Position = "Defender", Age = 33, NationalTeam = "Egypt", TeamId = 15, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 738, Name = "Khaled Reda", Position = "Defender", Age = 34, NationalTeam = "Egypt", TeamId = 15, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 739, Name = "Ali Fawzy", Position = "Defender", Age = 31, NationalTeam = "Egypt", TeamId = 15, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 740, Name = "Mahmoud Rizk", Position = "Defender", Age = 30, NationalTeam = "Egypt", TeamId = 15, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 741, Name = "Mahmoud Shaaban", Position = "Defender", Age = 28, NationalTeam = "Egypt", TeamId = 15, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 742, Name = "Mohamed Desouky", Position = "Defender", Age = 26, NationalTeam = "Egypt", TeamId = 15, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 743, Name = "Mostafa Ashraf", Position = "Defender", Age = 22, NationalTeam = "Egypt", TeamId = 15, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 744, Name = "Abdel Rahman Rashdan", Position = "Defender", Age = 20, NationalTeam = "Egypt", TeamId = 15, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 745, Name = "Tarek Mohamed", Position = "Defender", Age = 23, NationalTeam = "Egypt", TeamId = 15, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },

     // Midfielders
     new Player { PlayerId = 746, Name = "Mohamed Helal", Position = "Midfielder", Age = 28, NationalTeam = "Egypt", TeamId = 15, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 747, Name = "Ghanam Mohamed", Position = "Midfielder", Age = 26, NationalTeam = "Egypt", TeamId = 15, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 748, Name = "Emad Hamdy", Position = "Midfielder", Age = 30, NationalTeam = "Egypt", TeamId = 15, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 749, Name = "Ahmed Youssef", Position = "Midfielder", Age = 24, NationalTeam = "Egypt", TeamId = 15, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 750, Name = "Abdel Rahman Osama", Position = "Midfielder", Age = 24, NationalTeam = "Egypt", TeamId = 15, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 751, Name = "Ali Zaazaa", Position = "Midfielder", Age = 22, NationalTeam = "Egypt", TeamId = 15, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 752, Name = "Ahmed Mostafa", Position = "Midfielder", Age = 26, NationalTeam = "Egypt", TeamId = 15, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 753, Name = "Abdallah Hafez", Position = "Midfielder", Age = 25, NationalTeam = "Egypt", TeamId = 15, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 754, Name = "Mohamed Sabry", Position = "Midfielder", Age = 23, NationalTeam = "Egypt", TeamId = 15, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 755, Name = "Rashad Metwally", Position = "Midfielder", Age = 22, NationalTeam = "Egypt", TeamId = 15, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },

     // Forwards
     new Player { PlayerId = 756, Name = "A Redjem", Position = "Forward", Age = 26, NationalTeam = "Algeria", TeamId = 15, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 757, Name = "Walid Farag", Position = "Forward", Age = 22, NationalTeam = "Egypt", TeamId = 15, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 758, Name = "Mahmoud Mamdouh", Position = "Forward", Age = 21, NationalTeam = "Egypt", TeamId = 15, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 759, Name = "Mohamed Mossad", Position = "Forward", Age = 22, NationalTeam = "Egypt", TeamId = 15, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 760, Name = "Arnold Iba", Position = "Forward", Age = 20, NationalTeam = "Cameroon", TeamId = 15, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 761, Name = "F Okenabirhie", Position = "Forward", Age = 28, NationalTeam = "England", TeamId = 15, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 762, Name = "Hossam Hassan", Position = "Forward", Age = 30, NationalTeam = "Egypt", TeamId = 15, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 763, Name = "Godwin Shika Okwara", Position = "Forward", Age = 26, NationalTeam = "Nigeria", TeamId = 15, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" }
 );


            modelBuilder.Entity<Player>().HasData(
     // Goalkeepers
     new Player { PlayerId = 764, Name = "El Hany Soliman", Position = "Goalkeeper", Age = 39, NationalTeam = "Egypt", TeamId = 16, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 765, Name = "Hussein Timour", Position = "Goalkeeper", Age = 24, NationalTeam = "Egypt", TeamId = 16, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 766, Name = "Ahmed Mihoub", Position = "Goalkeeper", Age = 28, NationalTeam = "Egypt", TeamId = 16, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },

     // Defenders
     new Player { PlayerId = 767, Name = "Ahmed Awad", Position = "Defender", Age = 28, NationalTeam = "Egypt", TeamId = 16, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 768, Name = "Mohamed Ragab", Position = "Defender", Age = 24, NationalTeam = "Egypt", TeamId = 16, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 769, Name = "Haitham Mostafa", Position = "Defender", Age = 31, NationalTeam = "Egypt", TeamId = 16, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 770, Name = "Sherif Reda", Position = "Defender", Age = 27, NationalTeam = "Egypt", TeamId = 16, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 771, Name = "Ibrahim Samy", Position = "Defender", Age = 22, NationalTeam = "Egypt", TeamId = 16, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 772, Name = "Ahmed Hakam", Position = "Defender", Age = 25, NationalTeam = "Egypt", TeamId = 16, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 773, Name = "Youssef Afifi", Position = "Defender", Age = 22, NationalTeam = "Egypt", TeamId = 16, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 774, Name = "Mohamed Debesh", Position = "Defender", Age = 33, NationalTeam = "Egypt", TeamId = 16, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },

     // Midfielders
     new Player { PlayerId = 775, Name = "Islam Atiya", Position = "Midfielder", Age = 25, NationalTeam = "Egypt", TeamId = 16, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 776, Name = "Khaled Bassiouny", Position = "Midfielder", Age = 25, NationalTeam = "Egypt", TeamId = 16, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 777, Name = "Doku Dodo", Position = "Midfielder", Age = 20, NationalTeam = "Benin", TeamId = 16, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 778, Name = "Abdel Rahman Amer", Position = "Midfielder", Age = 31, NationalTeam = "Egypt", TeamId = 16, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 779, Name = "Mahmoud Abdel Halim", Position = "Midfielder", Age = 28, NationalTeam = "Egypt", TeamId = 16, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 780, Name = "Ahmed Ali Amin", Position = "Midfielder", Age = 24, NationalTeam = "Egypt", TeamId = 16, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 781, Name = "Hisham Hafez", Position = "Midfielder", Age = 22, NationalTeam = "Egypt", TeamId = 16, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 782, Name = "K Mohamed", Position = "Midfielder", Age = 24, NationalTeam = "Côte dIvoire", TeamId = 16, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 783, Name = "Amr El Sisi", Position = "Midfielder", Age = 30, NationalTeam = "Egypt", TeamId = 16, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 784, Name = "El Habib Ahmed Hassan", Position = "Midfielder", Age = 28, NationalTeam = "Egypt", TeamId = 16, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 785, Name = "Ahmed Fawzy", Position = "Midfielder", Age = 21, NationalTeam = "Egypt", TeamId = 16, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 786, Name = "Samadou Attidjikou", Position = "Midfielder", Age = 20, NationalTeam = "Benin", TeamId = 16, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 787, Name = "Khaled El Ghandour", Position = "Midfielder", Age = 30, NationalTeam = "Egypt", TeamId = 16, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 788, Name = "Samir Fikry", Position = "Midfielder", Age = 28, NationalTeam = "Egypt", TeamId = 16, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 789, Name = "Emad Fathy", Position = "Midfielder", Age = 32, NationalTeam = "Egypt", TeamId = 16, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },

     // Forwards
     new Player { PlayerId = 790, Name = "Samuel Amadi", Position = "Forward", Age = 21, NationalTeam = "Nigeria", TeamId = 16, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 791, Name = "Mohamed Saeed", Position = "Forward", Age = 22, NationalTeam = "Egypt", TeamId = 16, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 792, Name = "Abdel Kader Yehia", Position = "Forward", Age = 25, NationalTeam = "Egypt", TeamId = 16, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 793, Name = "Hossam Ashraf", Position = "Forward", Age = 23, NationalTeam = "Egypt", TeamId = 16, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 794, Name = "Pape Badji", Position = "Forward", Age = 24, NationalTeam = "Senegal", TeamId = 16, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" }
 );


            modelBuilder.Entity<Player>().HasData(
    // Goalkeepers
    new Player { PlayerId = 795, Name = "Ahmed Adel Abdel Monem", Position = "Goalkeeper", Age = 36, NationalTeam = "Egypt", TeamId = 17, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 796, Name = "Abdullah Gamal", Position = "Goalkeeper", Age = 21, NationalTeam = "Egypt", TeamId = 17, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 797, Name = "Abdul Rahman Mahrous", Position = "Goalkeeper", Age = 0, NationalTeam = "Egypt", TeamId = 17, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },

    // Defenders
    new Player { PlayerId = 798, Name = "Mohamed Amar", Position = "Defender", Age = 24, NationalTeam = "Egypt", TeamId = 17, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 799, Name = "Mohamed Nasr", Position = "Defender", Age = 23, NationalTeam = "Egypt", TeamId = 17, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 800, Name = "Abdullah Said", Position = "Defender", Age = 22, NationalTeam = "Egypt", TeamId = 17, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 801, Name = "Hatem Mohamed", Position = "Defender", Age = 22, NationalTeam = "Egypt", TeamId = 17, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 802, Name = "Adel Karim Shehata", Position = "Defender", Age = 21, NationalTeam = "Egypt", TeamId = 17, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 803, Name = "Abdallah Mohamed", Position = "Defender", Age = 21, NationalTeam = "Egypt", TeamId = 17, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 804, Name = "Mohamed Ihab", Position = "Defender", Age = 21, NationalTeam = "Egypt", TeamId = 17, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 805, Name = "Abdallah Hassan", Position = "Defender", Age = 18, NationalTeam = "Egypt", TeamId = 17, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },

    // Midfielders
    new Player { PlayerId = 806, Name = "Mohamed Abd El Samee", Position = "Midfielder", Age = 23, NationalTeam = "Egypt", TeamId = 17, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 807, Name = "Marwan Hamdy", Position = "Midfielder", Age = 22, NationalTeam = "Egypt", TeamId = 17, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 808, Name = "Mohamed Hassan", Position = "Midfielder", Age = 30, NationalTeam = "Egypt", TeamId = 17, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 809, Name = "Ahmed El Sheikh", Position = "Midfielder", Age = 31, NationalTeam = "Egypt", TeamId = 17, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 810, Name = "Ali Omar", Position = "Midfielder", Age = 24, NationalTeam = "Egypt", TeamId = 17, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 811, Name = "Eric Traore", Position = "Midfielder", Age = 27, NationalTeam = "Burkina Faso", TeamId = 17, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 812, Name = "Mahmoud Otaka", Position = "Midfielder", Age = 20, NationalTeam = "Egypt", TeamId = 17, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 813, Name = "Ibrahim Abdel Aal", Position = "Midfielder", Age = 18, NationalTeam = "Egypt", TeamId = 17, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 814, Name = "Abdel Katkout", Position = "Midfielder", Age = 18, NationalTeam = "Egypt", TeamId = 17, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },

    // Forwards
    new Player { PlayerId = 815, Name = "Abdel Rahman El Deh", Position = "Forward", Age = 24, NationalTeam = "Egypt", TeamId = 17, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 816, Name = "Nader Farag", Position = "Forward", Age = 22, NationalTeam = "Egypt", TeamId = 17, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 817, Name = "Hassan Saber", Position = "Forward", Age = 18, NationalTeam = "Egypt", TeamId = 17, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 818, Name = "Mohamed Wagdy", Position = "Forward", Age = 21, NationalTeam = "Egypt", TeamId = 17, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 819, Name = "Amr Said", Position = "Forward", Age = 0, NationalTeam = "Egypt", TeamId = 17, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 820, Name = "Mohamed Zidan", Position = "Forward", Age = 22, NationalTeam = "Egypt", TeamId = 17, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 821, Name = "Khaled Al Nabries", Position = "Forward", Age = 20, NationalTeam = "Palestine", TeamId = 17, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 822, Name = "Mohamed Khatary", Position = "Forward", Age = 19, NationalTeam = "Egypt", TeamId = 17, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 823, Name = "Omar El Kot", Position = "Forward", Age = 18, NationalTeam = "Egypt", TeamId = 17, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 824, Name = "Mohamed El Behairy", Position = "Forward", Age = 22, NationalTeam = "Egypt", TeamId = 17, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
    new Player { PlayerId = 825, Name = "Ibrahim El Nagaawy", Position = "Forward", Age = 15, NationalTeam = "Egypt", TeamId = 17, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" }
);


            modelBuilder.Entity<Player>().HasData(
     // Goalkeepers
     new Player { PlayerId = 826, Name = "Ahmed Ibrahim", Position = "Goalkeeper", Age = 26, NationalTeam = "Egypt", TeamId = 18, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 827, Name = "Amer Amer", Position = "Goalkeeper", Age = 36, NationalTeam = "Egypt", TeamId = 18, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 828, Name = "Ahmed El Arabi", Position = "Goalkeeper", Age = 31, NationalTeam = "Egypt", TeamId = 18, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },

     // Defenders
     new Player { PlayerId = 829, Name = "Bassem Walid", Position = "Defender", Age = 26, NationalTeam = "Egypt", TeamId = 18, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 830, Name = "Ahmed Castelo", Position = "Defender", Age = 25, NationalTeam = "Egypt", TeamId = 18, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 831, Name = "Yehia Zakaria", Position = "Defender", Age = 22, NationalTeam = "Egypt", TeamId = 18, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 832, Name = "Mohamed Nabih", Position = "Defender", Age = 18, NationalTeam = "Egypt", TeamId = 18, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 833, Name = "Hamidu Fatawu", Position = "Defender", Age = 25, NationalTeam = "Ghana", TeamId = 18, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 834, Name = "Osama Fathy", Position = "Defender", Age = 24, NationalTeam = "Egypt", TeamId = 18, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 835, Name = "Abdelrahim Amoory", Position = "Defender", Age = 25, NationalTeam = "Egypt", TeamId = 18, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 836, Name = "Abdelrahman Youssef", Position = "Defender", Age = 26, NationalTeam = "Egypt", TeamId = 18, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },

     // Midfielders
     new Player { PlayerId = 837, Name = "Khaled El Akhmimi", Position = "Midfielder", Age = 28, NationalTeam = "Egypt", TeamId = 18, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 838, Name = "Ibrahim Hassan", Position = "Midfielder", Age = 32, NationalTeam = "Egypt", TeamId = 18, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 839, Name = "Youssef Hassan", Position = "Midfielder", Age = 25, NationalTeam = "Egypt", TeamId = 18, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 840, Name = "Mohamed Osama", Position = "Midfielder", Age = 24, NationalTeam = "Egypt", TeamId = 18, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 841, Name = "Ahmed Magdy", Position = "Midfielder", Age = 34, NationalTeam = "Egypt", TeamId = 18, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 842, Name = "M Touré", Position = "Midfielder", Age = 21, NationalTeam = "Côte d'Ivoire", TeamId = 18, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 843, Name = "Abdelrahman Khaled", Position = "Midfielder", Age = 28, NationalTeam = "Egypt", TeamId = 18, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 844, Name = "Momoh Kamara", Position = "Midfielder", Age = 0, NationalTeam = "0", TeamId = 18, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 845, Name = "Emad Mihoub", Position = "Midfielder", Age = 22, NationalTeam = "Egypt", TeamId = 18, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },

     // Forwards
     new Player { PlayerId = 846, Name = "Mohamed Ashraf", Position = "Forward", Age = 25, NationalTeam = "Egypt", TeamId = 18, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 847, Name = "Mohamed Essam Amara", Position = "Forward", Age = 27, NationalTeam = "Egypt", TeamId = 18, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 848, Name = "R Arfaoui", Position = "Forward", Age = 27, NationalTeam = "Tunisia", TeamId = 18, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 849, Name = "Mahmoud Satouhi", Position = "Forward", Age = 0, NationalTeam = "Egypt", TeamId = 18, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 850, Name = "Hossam Abu El Azm", Position = "Forward", Age = 29, NationalTeam = "Egypt", TeamId = 18, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 851, Name = "Mohamed Ben Hamouda", Position = "Forward", Age = 25, NationalTeam = "Tunisia", TeamId = 18, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 852, Name = "Mahmoud Magdy", Position = "Forward", Age = 18, NationalTeam = "Egypt", TeamId = 18, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 853, Name = "Mahmoud Wadi", Position = "Forward", Age = 29, NationalTeam = "Palestine", TeamId = 18, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 854, Name = "Atef Al Hakim", Position = "Forward", Age = 19, NationalTeam = "Egypt", TeamId = 18, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 855, Name = "Hazem Abou Sena", Position = "Forward", Age = 22, NationalTeam = "Egypt", TeamId = 18, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 856, Name = "Abdel Nasser Mohamed Di Maria", Position = "Forward", Age = 27, NationalTeam = "Egypt", TeamId = 18, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" }
 );


            modelBuilder.Entity<Player>().HasData(
     // Goalkeepers
     new Player { PlayerId = 857, Name = "Mahmoud Abu El-Saud", Position = "Goalkeeper", Age = 35, NationalTeam = "Egypt", TeamId = 19, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 858, Name = "Mohamed Fawzi", Position = "Goalkeeper", Age = 27, NationalTeam = "Egypt", TeamId = 19, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 859, Name = "Mahmoud El Hadary", Position = "Goalkeeper", Age = 30, NationalTeam = "Egypt", TeamId = 19, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },

     // Defenders
     new Player { PlayerId = 860, Name = "J. Oshaya", Position = "Defender", Age = 30, NationalTeam = "Uganda", TeamId = 19, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 861, Name = "Loay Wael", Position = "Defender", Age = 31, NationalTeam = "Egypt", TeamId = 19, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 862, Name = "Amir Abed", Position = "Defender", Age = 34, NationalTeam = "Egypt", TeamId = 19, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 863, Name = "Mohamed Hamed", Position = "Defender", Age = 30, NationalTeam = "Egypt", TeamId = 19, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 864, Name = "Mohamed Hazin", Position = "Defender", Age = 24, NationalTeam = "Egypt", TeamId = 19, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 865, Name = "Islam Abdallah", Position = "Defender", Age = 22, NationalTeam = "Egypt", TeamId = 19, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 866, Name = "Ahmed Magdy Kahraba", Position = "Defender", Age = 25, NationalTeam = "Egypt", TeamId = 19, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 867, Name = "Ibrahim El Qadi", Position = "Defender", Age = 33, NationalTeam = "Egypt", TeamId = 19, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 868, Name = "Mohamed Hesham", Position = "Defender", Age = 24, NationalTeam = "Egypt", TeamId = 19, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 869, Name = "Mohamed Gamal El Karta", Position = "Defender", Age = 33, NationalTeam = "Egypt", TeamId = 19, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },

     // Midfielders
     new Player { PlayerId = 870, Name = "Elsayed Abu Amna", Position = "Midfielder", Age = 28, NationalTeam = "Egypt", TeamId = 19, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 871, Name = "Islam Gaber", Position = "Midfielder", Age = 27, NationalTeam = "Egypt", TeamId = 19, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 872, Name = "Omar El-Wahsh", Position = "Midfielder", Age = 28, NationalTeam = "Egypt", TeamId = 19, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 873, Name = "Mohamed Abdelnaser", Position = "Midfielder", Age = 17, NationalTeam = "Egypt", TeamId = 19, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 874, Name = "Mohand Mohamed", Position = "Midfielder", Age = 27, NationalTeam = "Egypt", TeamId = 19, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 875, Name = "Abdelrahman Akmal", Position = "Midfielder", Age = 20, NationalTeam = "Egypt", TeamId = 19, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 876, Name = "Mostafa Gamal", Position = "Midfielder", Age = 32, NationalTeam = "Egypt", TeamId = 19, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },

     // Forwards
     new Player { PlayerId = 877, Name = "Mohamed Salem", Position = "Forward", Age = 29, NationalTeam = "Egypt", TeamId = 19, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 878, Name = "Mohamed Hesham", Position = "Forward", Age = 26, NationalTeam = "Egypt", TeamId = 19, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 879, Name = "Joaquim Ojiera", Position = "Forward", Age = 26, NationalTeam = "Uganda", TeamId = 19, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 880, Name = "Mahmoud Abou-Gouda", Position = "Forward", Age = 0, NationalTeam = "Egypt", TeamId = 19, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 881, Name = "Abdelrahman Samana", Position = "Forward", Age = 25, NationalTeam = "Egypt", TeamId = 19, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 882, Name = "Mostafa Sobhi", Position = "Forward", Age = 25, NationalTeam = "Egypt", TeamId = 19, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 883, Name = "Shokry Naguib", Position = "Forward", Age = 29, NationalTeam = "Egypt", TeamId = 19, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 884, Name = "C. Ekpenyong", Position = "Forward", Age = 18, NationalTeam = "Nigeria", TeamId = 19, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 885, Name = "Mahmoud El Sayed Daabasa", Position = "Forward", Age = 0, NationalTeam = "Egypt", TeamId = 19, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 886, Name = "Mohamed Antar", Position = "Forward", Age = 31, NationalTeam = "Egypt", TeamId = 19, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" }
 );

            modelBuilder.Entity<Player>().HasData(
     // Goalkeepers
     new Player { PlayerId = 887, Name = "Amr Hossam", Position = "Goalkeeper", Age = 32, NationalTeam = "Egypt", TeamId = 20, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 888, Name = "Hassan El-Hattab", Position = "Goalkeeper", Age = 28, NationalTeam = "Egypt", TeamId = 20, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 889, Name = "Amr Shaaban", Position = "Goalkeeper", Age = 0, NationalTeam = "Egypt", TeamId = 20, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },

     // Defenders
     new Player { PlayerId = 890, Name = "Ahmed Dahroug", Position = "Defender", Age = 28, NationalTeam = "Egypt", TeamId = 20, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 891, Name = "Ahmed Ayman", Position = "Defender", Age = 30, NationalTeam = "Egypt", TeamId = 20, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 892, Name = "Shady Maher", Position = "Defender", Age = 27, NationalTeam = "Egypt", TeamId = 20, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 893, Name = "Ahmed Reda", Position = "Defender", Age = 21, NationalTeam = "Egypt", TeamId = 20, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 894, Name = "Ragab El-Safi", Position = "Defender", Age = 24, NationalTeam = "Egypt", TeamId = 20, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 895, Name = "Ahmed Dahesh", Position = "Defender", Age = 25, NationalTeam = "Egypt", TeamId = 20, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 896, Name = "Kamal Abu El-Fotouh", Position = "Defender", Age = 27, NationalTeam = "Egypt", TeamId = 20, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 897, Name = "Saif Teka", Position = "Defender", Age = 32, NationalTeam = "Tunisia", TeamId = 20, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 898, Name = "Omar Adly", Position = "Defender", Age = 28, NationalTeam = "Egypt", TeamId = 20, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },

     // Midfielders
     new Player { PlayerId = 899, Name = "M. Kaandorp", Position = "Midfielder", Age = 26, NationalTeam = "Netherlands", TeamId = 20, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 900, Name = "Hesham Mohamed", Position = "Midfielder", Age = 33, NationalTeam = "Egypt", TeamId = 20, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 901, Name = "Ahmed El-Shimy", Position = "Midfielder", Age = 28, NationalTeam = "Egypt", TeamId = 20, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 902, Name = "Mahmoud Talaat", Position = "Midfielder", Age = 33, NationalTeam = "Egypt", TeamId = 20, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 903, Name = "Mohamed Abdel-Aty", Position = "Midfielder", Age = 29, NationalTeam = "Egypt", TeamId = 20, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 904, Name = "Islam Adel Kanu", Position = "Midfielder", Age = 31, NationalTeam = "Egypt", TeamId = 20, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 905, Name = "Ibrahim El Bahnasi", Position = "Midfielder", Age = 32, NationalTeam = "Egypt", TeamId = 20, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 906, Name = "Wincool Kobinah", Position = "Midfielder", Age = 33, NationalTeam = "Ghana", TeamId = 20, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },

     // Forwards
     new Player { PlayerId = 907, Name = "Ahmed Farouk", Position = "Forward", Age = 22, NationalTeam = "Egypt", TeamId = 20, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 908, Name = "Mahmoud Diasty", Position = "Forward", Age = 28, NationalTeam = "Egypt", TeamId = 20, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 909, Name = "Youssef Oya", Position = "Forward", Age = 23, NationalTeam = "Egypt", TeamId = 20, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 910, Name = "Mohamed Abdelrahim", Position = "Forward", Age = 32, NationalTeam = "Egypt", TeamId = 20, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 911, Name = "Ali Hussein", Position = "Forward", Age = 31, NationalTeam = "Egypt", TeamId = 20, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
     new Player { PlayerId = 912, Name = "F. Boli", Position = "Forward", Age = 30, NationalTeam = "Côte d'Ivoire", TeamId = 20, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" }
 );

            modelBuilder.Entity<Player>().HasData(
      // Goalkeepers
      new Player { PlayerId = 913, Name = "Ali El-Gabri", Position = "Goalkeeper", Age = 23, NationalTeam = "Egypt", TeamId = 21, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 914, Name = "Mohamed Hagras", Position = "Goalkeeper", Age = 0, NationalTeam = "Egypt", TeamId = 21, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },

      // Defenders
      new Player { PlayerId = 915, Name = "Joseph Nguim", Position = "Defender", Age = 32, NationalTeam = "Cameroon", TeamId = 21, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 916, Name = "Ibrahim Awad", Position = "Defender", Age = 27, NationalTeam = "Egypt", TeamId = 21, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 917, Name = "Mohamed Awsam", Position = "Defender", Age = 21, NationalTeam = "Egypt", TeamId = 21, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 918, Name = "M. Abuzraa", Position = "Defender", Age = 28, NationalTeam = "Morocco", TeamId = 21, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 919, Name = "Karim Yehia", Position = "Defender", Age = 25, NationalTeam = "Egypt", TeamId = 21, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 920, Name = "Mahmoud Metwally", Position = "Defender", Age = 30, NationalTeam = "Egypt", TeamId = 21, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 921, Name = "Karim Mamdouh Khaled", Position = "Defender", Age = 30, NationalTeam = "Egypt", TeamId = 21, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 922, Name = "Seif El-Khashab", Position = "Defender", Age = 25, NationalTeam = "Egypt", TeamId = 21, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },

      new Player { PlayerId = 923, Name = "Mohamed Medhat", Position = "Defender", Age = 0, NationalTeam = "Egypt", TeamId = 21, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 924, Name = "Essam El Fayoumi", Position = "Defender", Age = 0, NationalTeam = "Egypt", TeamId = 21, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 925, Name = "Mohamed Saied", Position = "Defender", Age = 0, NationalTeam = "Egypt", TeamId = 21, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },

      // Midfielders
      new Player { PlayerId = 926, Name = "Ahmed Hamza", Position = "Midfielder", Age = 30, NationalTeam = "Egypt", TeamId = 21, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 927, Name = "Magid Abdel Rahman", Position = "Midfielder", Age = 21, NationalTeam = "Egypt", TeamId = 21, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 928, Name = "Islam Abdel Naeem", Position = "Midfielder", Age = 32, NationalTeam = "Egypt", TeamId = 21, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 929, Name = "Seif El-Agooz", Position = "Midfielder", Age = 22, NationalTeam = "Egypt", TeamId = 21, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 930, Name = "Abdel Fattah Sheta", Position = "Midfielder", Age = 21, NationalTeam = "Egypt", TeamId = 21, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 931, Name = "Mohamed Hamdy", Position = "Midfielder", Age = 21, NationalTeam = "Egypt", TeamId = 21, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 932, Name = "M. Sillah", Position = "Midfielder", Age = 0, NationalTeam = "Egypt", TeamId = 21, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 933, Name = "J. Nkengafack", Position = "Midfielder", Age = 0, NationalTeam = "Egypt", TeamId = 21, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },

      // Forwards
      new Player { PlayerId = 934, Name = "Karim Ashraf", Position = "Forward", Age = 30, NationalTeam = "Egypt", TeamId = 21, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 935, Name = "Mohamed Juhayna", Position = "Forward", Age = 24, NationalTeam = "Egypt", TeamId = 21, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 936, Name = "Omar El-Saeed", Position = "Forward", Age = 33, NationalTeam = "Egypt", TeamId = 21, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 937, Name = "Mohamed Farouk", Position = "Forward", Age = 0, NationalTeam = "Egypt", TeamId = 21, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 938, Name = "Mohamed Onajem", Position = "Forward", Age = 32, NationalTeam = "Morocco", TeamId = 21, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 939, Name = "Abdallah Maradona", Position = "Forward", Age = 0, NationalTeam = "Egypt", TeamId = 21, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 940, Name = "Mostafa Abdel Rahim Koshary", Position = "Forward", Age = 32, NationalTeam = "Egypt", TeamId = 21, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 941, Name = "A. Sulieman", Position = "Forward", Age = 0, NationalTeam = "Egypt", TeamId = 21, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" },
      new Player { PlayerId = 942, Name = "Mohamed El-Sayed Shika", Position = "Forward", Age = 27, NationalTeam = "Egypt", TeamId = 21, Goals = 0, Assists = 0, MatchesPlayed = 0, ImageUrl = "/images/players/default.png" }
  );

            // Matches
            modelBuilder.Entity<Match>().HasData(
                // Round 1
                new Match
                {
                    MatchId = 1,
                    HomeTeamId = 1, // Al Ahly
                    AwayTeamId = 4, // El Masry
                    MatchDate = new DateTime(2025, 8, 20),
                    KickOffTime = new TimeSpan(19, 0, 0),
                    Stadium = "استاد الأهلي WE",
                    Round = "الجولة 1",
                    HomeScore = 2,
                    AwayScore = 0,
                    Result = MatchResult.HomeWin,
                    Status = MatchStatus.Completed,
                    EndTime = new DateTime(2025, 8, 20, 20, 45, 0),
                    SeasonId = 1,
                    TournamentId = 1
                },
                new Match
                {
                    MatchId = 2,
                    HomeTeamId = 2, // Zamalek
                    AwayTeamId = 5, // Future FC
                    MatchDate = new DateTime(2025, 8, 21),
                    KickOffTime = new TimeSpan(19, 0, 0),
                    Stadium = "استاد القاهرة الدولي",
                    Round = "الجولة 1",
                    HomeScore = 2,
                    AwayScore = 1,
                    Result = MatchResult.HomeWin,
                    Status = MatchStatus.Completed,
                    EndTime = new DateTime(2025, 8, 21, 20, 45, 0),
                    SeasonId = 1,
                    TournamentId = 1
                },
                new Match
                {
                    MatchId = 3,
                    HomeTeamId = 3, // Pyramids
                    AwayTeamId = 6, // Ceramica Cleopatra
                    MatchDate = new DateTime(2025, 8, 22),
                    KickOffTime = new TimeSpan(17, 0, 0),
                    Stadium = "استاد 30 يونيو",
                    Round = "الجولة 1",
                    HomeScore = 1,
                    AwayScore = 0,
                    Result = MatchResult.HomeWin,
                    Status = MatchStatus.Completed,
                    EndTime = new DateTime(2025, 8, 22, 18, 45, 0),
                    SeasonId = 1,
                    TournamentId = 1
                },

                // Round 2
                new Match
                {
                    MatchId = 4,
                    HomeTeamId = 5, // Future FC
                    AwayTeamId = 1, // Al Ahly
                    MatchDate = new DateTime(2025, 8, 25),
                    KickOffTime = new TimeSpan(19, 0, 0),
                    Stadium = "استاد WE الأهلي",
                    Round = "الجولة 2",
                    HomeScore = 0,
                    AwayScore = 3,
                    Result = MatchResult.AwayWin,
                    Status = MatchStatus.Completed,
                    EndTime = new DateTime(2025, 8, 25, 20, 45, 0),
                    SeasonId = 1,
                    TournamentId = 1
                },
                new Match
                {
                    MatchId = 5,
                    HomeTeamId = 6, // Ceramica Cleopatra
                    AwayTeamId = 2, // Zamalek
                    MatchDate = new DateTime(2025, 8, 26),
                    KickOffTime = new TimeSpan(19, 0, 0),
                    Stadium = "استاد الأكاديمية العسكرية",
                    Round = "الجولة 2",
                    HomeScore = 0,
                    AwayScore = 2,
                    Result = MatchResult.AwayWin,
                    Status = MatchStatus.Completed,
                    EndTime = new DateTime(2025, 8, 26, 20, 45, 0),
                    SeasonId = 1,
                    TournamentId = 1
                },
                new Match
                {
                    MatchId = 6,
                    HomeTeamId = 4, // El Masry
                    AwayTeamId = 3, // Pyramids
                    MatchDate = new DateTime(2025, 8, 27),
                    KickOffTime = new TimeSpan(17, 0, 0),
                    Stadium = "استاد بورسعيد",
                    Round = "الجولة 2",
                    HomeScore = 1,
                    AwayScore = 1,
                    Result = MatchResult.Draw,
                    Status = MatchStatus.Completed,
                    EndTime = new DateTime(2025, 8, 27, 18, 45, 0),
                    SeasonId = 1,
                    TournamentId = 1
                },

                // Round 3
                new Match
                {
                    MatchId = 7,
                    HomeTeamId = 1, // Al Ahly
                    AwayTeamId = 6, // Ceramica Cleopatra
                    MatchDate = new DateTime(2025, 9, 1),
                    KickOffTime = new TimeSpan(19, 0, 0),
                    Stadium = "استاد الأهلي WE",
                    Round = "الجولة 3",
                    HomeScore = 4,
                    AwayScore = 0,
                    Result = MatchResult.HomeWin,
                    Status = MatchStatus.Completed,
                    EndTime = new DateTime(2025, 9, 1, 20, 45, 0),
                    SeasonId = 1,
                    TournamentId = 1
                },
                new Match
                {
                    MatchId = 8,
                    HomeTeamId = 3, // Pyramids
                    AwayTeamId = 2, // Zamalek
                    MatchDate = new DateTime(2025, 9, 2),
                    KickOffTime = new TimeSpan(19, 0, 0),
                    Stadium = "استاد 30 يونيو",
                    Round = "الجولة 3",
                    HomeScore = 1,
                    AwayScore = 1,
                    Result = MatchResult.Draw,
                    Status = MatchStatus.Completed,
                    EndTime = new DateTime(2025, 9, 2, 20, 45, 0),
                    SeasonId = 1,
                    TournamentId = 1
                },
                new Match
                {
                    MatchId = 9,
                    HomeTeamId = 4, // El Masry
                    AwayTeamId = 5, // Future FC
                    MatchDate = new DateTime(2025, 9, 3),
                    KickOffTime = new TimeSpan(17, 0, 0),
                    Stadium = "استاد بورسعيد",
                    Round = "الجولة 3",
                    HomeScore = 2,
                    AwayScore = 1,
                    Result = MatchResult.HomeWin,
                    Status = MatchStatus.Completed,
                    EndTime = new DateTime(2025, 9, 3, 18, 45, 0),
                    SeasonId = 1,
                    TournamentId = 1
                },

                // Upcoming matches (Round 4)
                new Match
                {
                    MatchId = 10,
                    HomeTeamId = 2, // Zamalek
                    AwayTeamId = 1, // Al Ahly
                    MatchDate = new DateTime(2025, 9, 7),
                    KickOffTime = new TimeSpan(19, 0, 0),
                    Stadium = "استاد القاهرة الدولي",
                    Round = "الجولة 4",
                    Result = MatchResult.Pending,
                    Status = MatchStatus.Scheduled,
                    SeasonId = 1,
                    TournamentId = 1
                },
                new Match
                {
                    MatchId = 11,
                    HomeTeamId = 5, // Future FC
                    AwayTeamId = 3, // Pyramids
                    MatchDate = new DateTime(2025, 9, 8),
                    KickOffTime = new TimeSpan(17, 0, 0),
                    Stadium = "استاد WE الأهلي",
                    Round = "الجولة 4",
                    Result = MatchResult.Pending,
                    Status = MatchStatus.Scheduled,
                    SeasonId = 1,
                    TournamentId = 1
                },
                new Match
                {
                    MatchId = 12,
                    HomeTeamId = 6, // Ceramica Cleopatra
                    AwayTeamId = 4, // El Masry
                    MatchDate = new DateTime(2025, 9, 9),
                    KickOffTime = new TimeSpan(19, 0, 0),
                    Stadium = "استاد الأكاديمية العسكرية",
                    Round = "الجولة 4",
                    Result = MatchResult.Pending,
                    Status = MatchStatus.Scheduled,
                    SeasonId = 1,
                    TournamentId = 1
                }
            );

            // Match Events
            modelBuilder.Entity<MatchEvent>().HasData(
                // Match 1: Al Ahly 2-0 El Masry
                new MatchEvent
                {
                    Id = 1,
                    MatchId = 1,
                    TeamId = 1, // Al Ahly
                    PlayerId = 3, // Percy Tau
                    RelatedPlayerId = 4, // Hussein El Shahat (assist)
                    Minute = 23,
                    EventType = EventType.Goal,
                    GoalType = GoalType.Normal,
                    Description = "برسي تاو يسجل من عرضية حسين الشحات"
                },
                new MatchEvent
                {
                    Id = 2,
                    MatchId = 1,
                    TeamId = 1, // Al Ahly
                    PlayerId = 2, // Mohamed Magdy Afsha
                    Minute = 67,
                    EventType = EventType.Goal,
                    GoalType = GoalType.Penalty,
                    Description = "أفشة يسجل من ركلة جزاء بعد لمسة يد داخل منطقة الجزاء"
                },
                new MatchEvent
                {
                    Id = 3,
                    MatchId = 1,
                    TeamId = 1, // Al Ahly
                    PlayerId = 5, // Aliou Dieng
                    Minute = 55,
                    EventType = EventType.YellowCard,
                    Description = "تدخل عنيف"
                },

                // Match 7: Al Ahly 4-0 Ceramica Cleopatra
                new MatchEvent
                {
                    Id = 4,
                    MatchId = 7,
                    TeamId = 1, // Al Ahly
                    PlayerId = 3, // Percy Tau
                    Minute = 15,
                    EventType = EventType.Goal,
                    GoalType = GoalType.Normal,
                    Description = "تاو يفتتح التسجيل بتسديدة دقيقة"
                },
                new MatchEvent
                {
                    Id = 5,
                    MatchId = 7,
                    TeamId = 1, // Al Ahly
                    PlayerId = 4, // Hussein El Shahat
                    RelatedPlayerId = 3, // Percy Tau (assist)
                    Minute = 29,
                    EventType = EventType.Goal,
                    GoalType = GoalType.Normal,
                    Description = "الشحات يضاعف النتيجة بعد عمل رائع من تاو"
                },
                new MatchEvent
                {
                    Id = 6,
                    MatchId = 7,
                    TeamId = 1, // Al Ahly
                    PlayerId = 2, // Mohamed Magdy Afsha
                    Minute = 58,
                    EventType = EventType.Goal,
                    GoalType = GoalType.FreeKick,
                    Description = "أفشة يسجل من ركلة حرة رائعة"
                },
                new MatchEvent
                {
                    Id = 7,
                    MatchId = 7,
                    TeamId = 1, // Al Ahly
                    PlayerId = 3, // Percy Tau
                    Minute = 77,
                    EventType = EventType.Goal,
                    GoalType = GoalType.Normal,
                    Description = "تاو يسجل هدفه الثاني في المباراة برأسية قوية"
                },

                // Match 2: Zamalek 2-1 Future FC
                new MatchEvent
                {
                    Id = 8,
                    MatchId = 2,
                    TeamId = 2, // Zamalek
                    PlayerId = 7, // Ahmed Sayed Zizo
                    Minute = 15,
                    EventType = EventType.Goal,
                    GoalType = GoalType.FreeKick,
                    Description = "زيزو يسجل مباشرة من ركلة حرة"
                },
                new MatchEvent
                {
                    Id = 9,
                    MatchId = 2,
                    TeamId = 5, // Future FC
                    PlayerId = null,
                    Minute = 38,
                    EventType = EventType.Goal,
                    GoalType = GoalType.Normal,
                    Description = "هدف التعادل لفيوتشر برأسية من ركلة ركنية"
                },
                new MatchEvent
                {
                    Id = 10,
                    MatchId = 2,
                    TeamId = 2, // Zamalek
                    PlayerId = 7, // Ahmed Sayed Zizo
                    Minute = 79,
                    EventType = EventType.Goal,
                    GoalType = GoalType.Normal,
                    Description = "زيزو يسجل هدف الفوز بعد تمريرة رائعة"
                },

                // Match 8: Pyramids 1-1 Zamalek
                new MatchEvent
                {
                    Id = 11,
                    MatchId = 8,
                    TeamId = 3, // Pyramids
                    PlayerId = 8, // Ibrahim Adel
                    Minute = 35,
                    EventType = EventType.Goal,
                    GoalType = GoalType.Normal,
                    Description = "إبراهيم عادل يتقدم ببيراميدز بهدف فردي رائع"
                },
                new MatchEvent
                {
                    Id = 12,
                    MatchId = 8,
                    TeamId = 2, // Zamalek
                    PlayerId = 7, // Ahmed Sayed Zizo
                    Minute = 68,
                    EventType = EventType.Goal,
                    GoalType = GoalType.Normal,
                    Description = "زيزو يعادل للزمالك بتسديدة رائعة"
                }
            );
        }
    }
}
