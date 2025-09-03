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

            // Teams - Egyptian Premier League
            modelBuilder.Entity<Team>().HasData(
                new Team
                {
                    Id = 1,
                    Name = "الأهلي",
                    ShortName = "AHL",
                    LogoUrl = "/images/teams/al-ahly.png",
                    Coach = "مارسيل كولر",
                    Founded = new DateTime(1907, 4, 24),
                    City = "القاهرة",
                    Country = "مصر",
                    Stadium = "استاد الأهلي WE",
                    StadiumCapacity = 30000,
                    Colors = "أحمر وأبيض",
                    Website = "https://www.alahlyegypt.com/",
                    SeasonId = 1,
                    Played = 3,
                    Wins = 3,
                    Draws = 0,
                    Losses = 0,
                    GoalsFor = 9,
                    GoalsAgainst = 0,
                    Position = 1
                },
                new Team
                {
                    Id = 2,
                    Name = "الزمالك",
                    ShortName = "ZAM",
                    LogoUrl = "/images/teams/zamalek.png",
                    Coach = "فرانسيسكو ميكالي",
                    Founded = new DateTime(1911, 1, 5),
                    City = "القاهرة",
                    Country = "مصر",
                    Stadium = "استاد القاهرة الدولي",
                    StadiumCapacity = 75000,
                    Colors = "أبيض وأحمر",
                    Website = "https://www.zamalekclub.com/",
                    SeasonId = 1,
                    Played = 3,
                    Wins = 2,
                    Draws = 1,
                    Losses = 0,
                    GoalsFor = 5,
                    GoalsAgainst = 2,
                    Position = 2
                },
                new Team
                {
                    Id = 3,
                    Name = "بيراميدز",
                    ShortName = "PYR",
                    LogoUrl = "/images/teams/pyramids.png",
                    Coach = "خالد جلال",
                    Founded = new DateTime(2008, 7, 17),
                    City = "القاهرة",
                    Country = "مصر",
                    Stadium = "استاد 30 يونيو",
                    StadiumCapacity = 30000,
                    Colors = "أزرق وأصفر",
                    Website = "https://www.pyramidsfc.com/",
                    SeasonId = 1,
                    Played = 3,
                    Wins = 1,
                    Draws = 2,
                    Losses = 0,
                    GoalsFor = 3,
                    GoalsAgainst = 2,
                    Position = 3
                },
                new Team
                {
                    Id = 4,
                    Name = "المصري",
                    ShortName = "MAS",
                    LogoUrl = "/images/teams/el-masry.png",
                    Coach = "محمد عودة",
                    Founded = new DateTime(1920, 6, 18),
                    City = "بورسعيد",
                    Country = "مصر",
                    Stadium = "استاد بورسعيد",
                    StadiumCapacity = 18000,
                    Colors = "أخضر وأبيض",
                    Website = "https://www.almasryclub.com/",
                    SeasonId = 1,
                    Played = 3,
                    Wins = 1,
                    Draws = 1,
                    Losses = 1,
                    GoalsFor = 3,
                    GoalsAgainst = 3,
                    Position = 4
                },
                new Team
                {
                    Id = 5,
                    Name = "فيوتشر",
                    ShortName = "FUT",
                    LogoUrl = "/images/teams/future-fc.png",
                    Coach = "علي ماهر",
                    Founded = new DateTime(2011, 8, 15),
                    City = "القاهرة",
                    Country = "مصر",
                    Stadium = "استاد WE الأهلي",
                    StadiumCapacity = 20000,
                    Colors = "أبيض وأزرق",
                    Website = "https://www.futurefcegypt.com/",
                    SeasonId = 1,
                    Played = 3,
                    Wins = 1,
                    Draws = 0,
                    Losses = 2,
                    GoalsFor = 2,
                    GoalsAgainst = 5,
                    Position = 5
                },
                new Team
                {
                    Id = 6,
                    Name = "سيراميكا كليوباترا",
                    ShortName = "CER",
                    LogoUrl = "/images/teams/ceramica-cleopatra.png",
                    Coach = "هاني رمزي",
                    Founded = new DateTime(2006, 1, 1),
                    City = "القاهرة",
                    Country = "مصر",
                    Stadium = "استاد الأكاديمية العسكرية",
                    StadiumCapacity = 28500,
                    Colors = "أزرق وأبيض",
                    Website = "https://www.ceramicacleopatrafc.com/",
                    SeasonId = 1,
                    Played = 3,
                    Wins = 0,
                    Draws = 0,
                    Losses = 3,
                    GoalsFor = 0,
                    GoalsAgainst = 7,
                    Position = 6
                }
            );

            // Players - Key players for each team
            // Al Ahly Players
            modelBuilder.Entity<Player>().HasData(
                new Player
                {
                    PlayerId = 1,
                    Name = "محمد الشناوي",
                    FullName = "محمد الشناوي",
                    Position = "حارس مرمى",
                    ShirtNumber = 1,
                    DateOfBirth = new DateTime(1988, 12, 18),
                    Age = 36,
                    Nationality = "مصر",
                    NationalTeam = "مصر",
                    TeamId = 1,
                    ImageUrl = "/images/players/mohamed-el-shenawy.png",
                    MatchesPlayed = 3,
                    Goals = 0,
                    Assists = 0,
                    YellowCards = 0,
                    RedCards = 0,
                    MinutesPlayed = 270
                },
                new Player
                {
                    PlayerId = 2,
                    Name = "محمد مجدي أفشة",
                    FullName = "محمد مجدي أفشة",
                    Position = "وسط",
                    ShirtNumber = 19,
                    DateOfBirth = new DateTime(1996, 3, 5),
                    Age = 29,
                    Nationality = "مصر",
                    NationalTeam = "مصر",
                    TeamId = 1,
                    ImageUrl = "/images/players/mohamed-magdy-afsha.png",
                    MatchesPlayed = 3,
                    Goals = 2,
                    Assists = 1,
                    YellowCards = 1,
                    RedCards = 0,
                    MinutesPlayed = 255
                },
                new Player
                {
                    PlayerId = 3,
                    Name = "برسي تاو",
                    FullName = "برسي تاو",
                    Position = "مهاجم",
                    ShirtNumber = 22,
                    DateOfBirth = new DateTime(1994, 5, 13),
                    Age = 31,
                    Nationality = "جنوب أفريقيا",
                    NationalTeam = "جنوب أفريقيا",
                    TeamId = 1,
                    ImageUrl = "/images/players/percy-tau.png",
                    MatchesPlayed = 3,
                    Goals = 3,
                    Assists = 1,
                    YellowCards = 0,
                    RedCards = 0,
                    MinutesPlayed = 235
                },
                new Player
                {
                    PlayerId = 4,
                    Name = "حسين الشحات",
                    FullName = "حسين الشحات",
                    Position = "جناح",
                    ShirtNumber = 14,
                    DateOfBirth = new DateTime(1992, 9, 21),
                    Age = 32,
                    Nationality = "مصر",
                    NationalTeam = "مصر",
                    TeamId = 1,
                    ImageUrl = "/images/players/hussein-el-shahat.png",
                    MatchesPlayed = 3,
                    Goals = 2,
                    Assists = 2,
                    YellowCards = 0,
                    RedCards = 0,
                    MinutesPlayed = 270
                },
                new Player
                {
                    PlayerId = 5,
                    Name = "أليو ديانج",
                    FullName = "أليو ديانج",
                    Position = "وسط دفاعي",
                    ShirtNumber = 15,
                    DateOfBirth = new DateTime(1997, 10, 16),
                    Age = 27,
                    Nationality = "مالي",
                    NationalTeam = "مالي",
                    TeamId = 1,
                    ImageUrl = "/images/players/aliou-dieng.png",
                    MatchesPlayed = 3,
                    Goals = 0,
                    Assists = 0,
                    YellowCards = 1,
                    RedCards = 0,
                    MinutesPlayed = 270
                },

                // Zamalek Players
                new Player
                {
                    PlayerId = 6,
                    Name = "محمد عواد",
                    FullName = "محمد عواد",
                    Position = "حارس مرمى",
                    ShirtNumber = 1,
                    DateOfBirth = new DateTime(1992, 7, 6),
                    Age = 33,
                    Nationality = "مصر",
                    NationalTeam = "مصر",
                    TeamId = 2,
                    ImageUrl = "/images/players/mohamed-awad.png",
                    MatchesPlayed = 3,
                    Goals = 0,
                    Assists = 0,
                    YellowCards = 0,
                    RedCards = 0,
                    MinutesPlayed = 270
                },
                new Player
                {
                    PlayerId = 7,
                    Name = "أحمد سيد زيزو",
                    FullName = "أحمد سيد زيزو",
                    Position = "جناح",
                    ShirtNumber = 17,
                    DateOfBirth = new DateTime(1996, 1, 10),
                    Age = 29,
                    Nationality = "مصر",
                    NationalTeam = "مصر",
                    TeamId = 2,
                    ImageUrl = "/images/players/ahmed-sayed-zizo.png",
                    MatchesPlayed = 3,
                    Goals = 3,
                    Assists = 0,
                    YellowCards = 1,
                    RedCards = 0,
                    MinutesPlayed = 270
                },
                new Player
                {
                    PlayerId = 8,
                    Name = "إبراهيم عادل",
                    FullName = "إبراهيم عادل",
                    Position = "مهاجم",
                    ShirtNumber = 11,
                    DateOfBirth = new DateTime(2001, 4, 7),
                    Age = 24,
                    Nationality = "مصر",
                    NationalTeam = "مصر",
                    TeamId = 3,
                    ImageUrl = "/images/players/ibrahim-adel.png",
                    MatchesPlayed = 3,
                    Goals = 2,
                    Assists = 0,
                    YellowCards = 0,
                    RedCards = 0,
                    MinutesPlayed = 270
                }
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
