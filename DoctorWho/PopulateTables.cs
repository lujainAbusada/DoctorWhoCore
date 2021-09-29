using DoctorWho.Db;
using System;

namespace DoctorWho
{
    class PopulateTables
    {
        private static DoctorWhoCoreDbContext _context;

        public PopulateTables(DoctorWhoCoreDbContext context)
        {
            _context = context;
            PopulateAuthorTable();
            PopulateCompanionTable();
            PopulateDoctorTable();
            PopulateEnemyTable();
            PopulateEpisodeTable();
            PopulateEpisodeCompanionTable();
            PopulateEpisodeEnemyTable();
        }

        public void PopulateAuthorTable()
        {
            _context.AddRange(
                new Author { AuthorName = "Sara" },
                new Author { AuthorName = "Ola" },
                new Author { AuthorName = "Mohammad" },
                new Author { AuthorName = "Ahmad" },
                new Author { AuthorName = "Ramy" });
            _context.SaveChanges();
        }

        public void PopulateCompanionTable()
        {
            _context.AddRange(
                new Companion { CompanionName = "Haya", WhoPlayed = "Abd" },
                new Companion { CompanionName = "Laila", WhoPlayed = "Noor" },
                new Companion { CompanionName = "Muath", WhoPlayed = "Fatima" },
                new Companion { CompanionName = "Hazem", WhoPlayed = "Malak" },
                new Companion { CompanionName = "Lujain", WhoPlayed = "Rayyan" }
                );
            _context.SaveChanges();
        }

        public void PopulateDoctorTable()
        {
            _context.AddRange(
                new Doctor
                {
                    DoctorNumber = 0599852369,
                    DoctorName = "Samer",
                    BirthDate = new DateTime(1988, 6, 1),
                    FirstEpisodeDate = new DateTime(1990, 3, 9),
                    LastEpisodeDate = new DateTime(2008, 12, 1)
                },
                new Doctor
                {
                    DoctorNumber = 059985559,
                    DoctorName = "Ramiz",
                    BirthDate = new DateTime(1988, 7, 1),
                    FirstEpisodeDate = new DateTime(2005, 9, 6),
                    LastEpisodeDate = new DateTime(2009, 7, 8)
                },
                new Doctor
                {
                    DoctorNumber = 0596852345,
                    DoctorName = "Hala",
                    BirthDate = new DateTime(1988, 6, 11),
                    FirstEpisodeDate = new DateTime(2000, 3, 9),
                    LastEpisodeDate = new DateTime(2015, 11, 11)
                },
                new Doctor
                {
                    DoctorNumber = 0599852369,
                    DoctorName = "Noor",
                    BirthDate = new DateTime(1988, 6, 1),
                    FirstEpisodeDate = new DateTime(1990, 3, 9),
                    LastEpisodeDate = new DateTime(2008, 12, 1)
                },
                new Doctor
                {
                    DoctorNumber = 0599816622,
                    DoctorName = "Raghad",
                    BirthDate = new DateTime(1977, 8, 9),
                    FirstEpisodeDate = new DateTime(2013, 12, 8),
                    LastEpisodeDate = new DateTime(2014, 2, 6)
                });
            _context.SaveChanges();
        }

        public void PopulateEnemyTable()
        {
            _context.AddRange(
                new Enemy { EnemyName = "Sam", Description = "Super Power" },
                new Enemy { EnemyName = "John", Description = "Fire" },
                new Enemy { EnemyName = "Mike", Description = "Guns" },
                new Enemy { EnemyName = "Harry", Description = "Cars" },
                new Enemy { EnemyName = "Mark", Description = "Money" }
                );
            _context.SaveChanges();
        }

        public void PopulateEpisodeTable()
        {
            _context.AddRange(
                new Episode { EpisodeNumber = 23, AuthorId = 1, DoctorId = 2, Title = "Twenty Three", SeriesNumber = 12, EpisodeType = "Action", EpisodeDate = new DateTime(2013, 12, 8) },
                new Episode { EpisodeNumber = 15, AuthorId = 2, DoctorId = 2, Title = "Fifteen", SeriesNumber = 1, EpisodeType = "Comedy", EpisodeDate = new DateTime(2003, 1, 1),},
                new Episode { EpisodeNumber = 3, AuthorId = 1, DoctorId = 4, Title = "Three", SeriesNumber = 5, EpisodeType = "Horror", EpisodeDate = new DateTime(2009, 1, 9) },
                new Episode { EpisodeNumber = 17, AuthorId = 2, DoctorId = 5, Title = "Seventeen", SeriesNumber = 15, EpisodeType = "Romance", EpisodeDate = new DateTime(2020, 2, 10) },
                new Episode { EpisodeNumber = 8, AuthorId = 3, DoctorId = 1, Title = "Eight", SeriesNumber = 11, EpisodeType = "Drama", EpisodeDate = new DateTime(2017, 7, 11) });
            _context.SaveChanges();
        }

        public void PopulateEpisodeCompanionTable()
        {
            _context.AddRange(
                new EpisodeCompanion { CompanionId = 1, EpisodeId = 3 },
                new EpisodeCompanion { CompanionId = 2, EpisodeId = 2 },
                new EpisodeCompanion { CompanionId = 5, EpisodeId = 5 },
                new EpisodeCompanion { CompanionId = 1, EpisodeId = 1 },
                new EpisodeCompanion { CompanionId = 4, EpisodeId = 3 }
                );
            _context.SaveChanges();
        }

        public void PopulateEpisodeEnemyTable()
        {
            _context.AddRange(
                new EpisodeEnemy { EnemyId = 5, EpisodeId = 1 },
                new EpisodeEnemy { EnemyId = 2, EpisodeId = 3 },
                new EpisodeEnemy { EnemyId = 3, EpisodeId = 4 },
                new EpisodeEnemy { EnemyId = 2, EpisodeId = 1 },
                new EpisodeEnemy { EnemyId = 1, EpisodeId = 5 }
                );
            _context.SaveChanges();
        }
    }
}
