using GoalArena.Models;
using Microsoft.EntityFrameworkCore;

namespace GoalArena.Data.Seed
{
    public static class SeedData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Tournament>().HasData(
                new Tournament
                {
                    TournamentId = 3,
                    Name = "دوري أبطال أوروبا",
                    Country = "أوروبا",
                    LogoUrl = "/images/tournaments/ucl.png"
                }
               
            );
        }
    }
}
