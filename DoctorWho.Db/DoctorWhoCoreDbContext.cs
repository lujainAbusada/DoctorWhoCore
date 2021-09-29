using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;

namespace DoctorWho.Db
{
    public class DoctorWhoCoreDbContext : DbContext
    {
        public string fnEnemies(int EpisodeId) => throw new NotSupportedException();
        public string fnCompanions(int EpisodeId) => throw new NotSupportedException();
        public DbSet<Author> Author { get; set; }
        public DbSet<Enemy> Enemy { get; set; }
        public DbSet<Episode> Episode { get; set; }
        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Companion> Companion { get; set; }
        public DbSet<EpisodeCompanion> EpisodeCompanion { get; set; }
        public DbSet<EpisodeEnemy> EpisodeEnemy { get; set; }
        public DbSet<EpisodeInformation> viewEpisodes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLoggerFactory(ConsoleLoggerFactory).EnableSensitiveDataLogging()
                .UseSqlServer("server=DESKTOP-CGU4KCR;database=DoctorWhoCore;trusted_connection=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EpisodeEnemy>().HasKey(s => new { s.EnemyId, s.EpisodeId });
            modelBuilder.Entity<EpisodeCompanion>().HasKey(s => new { s.EpisodeId, s.CompanionId });
            modelBuilder.HasDbFunction(typeof(DoctorWhoCoreDbContext).GetMethod(nameof(fnCompanions), new[] { typeof(int) }))
               .HasName("fnCompanions");
            modelBuilder.HasDbFunction(typeof(DoctorWhoCoreDbContext).GetMethod(nameof(fnEnemies), new[] { typeof(int) }))
              .HasName("fnEnemies");
        }

        public static readonly ILoggerFactory ConsoleLoggerFactory= LoggerFactory.Create( builder =>
        {
            builder.AddFilter((category, level) =>
                category == DbLoggerCategory.Database.Command.Name
                && level == LogLevel.Information)
                            .AddConsole();
        });
    }
}
