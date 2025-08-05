using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    internal class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

        public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<MatchEvent> MatchEvents { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // العلاقة: كل فريق ينتمي لموسم
            modelBuilder.Entity<Team>()
                .HasOne(t => t.Season)
                .WithMany(s => s.Teams)
                .HasForeignKey(t => t.SeasonId);

            // العلاقة: كل مباراة تنتمي لموسم
            modelBuilder.Entity<Match>()
                .HasOne(m => m.Season)
                .WithMany(s => s.Matches)
                .HasForeignKey(m => m.SeasonId);

            // العلاقات الأخرى تضاف كما كانت
        }

    }
}
