using GoalArena.Data.Seed;
using GoalArena.Models;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Models;

namespace GoalArena.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<MatchEvent> MatchEvents { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<TeamSeason> TeamSeasons { get; set; }
        public DbSet<UserOTP> UserOTPs { get; set; }
        public DbSet<Payment> payments { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<News>()
            .HasOne(n => n.Team)
            .WithMany()
            .HasForeignKey(n => n.TeamId)
            .OnDelete(DeleteBehavior.Restrict); 

            modelBuilder.Entity<News>()
           .HasOne(n => n.Player)
           .WithMany()
           .HasForeignKey(n => n.playerId)
           .OnDelete(DeleteBehavior.Restrict);
            
            modelBuilder.Entity<Match>()
           .HasOne(m => m.Tournament)
           .WithMany(t => t.Matches)
           .HasForeignKey(m => m.TournamentId)
           .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Match>()
          .HasOne(m => m.HomeTeam)
          .WithMany()
          .HasForeignKey(m => m.HomeTeamId)
          .OnDelete(DeleteBehavior.Restrict); 

            modelBuilder.Entity<Match>()
                .HasOne(m => m.AwayTeam)
                .WithMany()
                .HasForeignKey(m => m.AwayTeamId)
                .OnDelete(DeleteBehavior.Restrict);

             modelBuilder.Entity<TeamSeason>()
           .HasOne(ts => ts.Team)
           .WithMany(t => t.TeamSeasons)
           .HasForeignKey(ts => ts.TeamId)
           .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<MatchEvent>()
      .HasOne(me => me.Team)
      .WithMany()
      .HasForeignKey(me => me.TeamId)
      .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Seed();





        }
    }




}
