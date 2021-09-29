using DoctorWho.Db;
using DoctorWho.Db.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DoctorWho
{
    class Program
    {
        private static DoctorWhoCoreDbContext _context = new DoctorWhoCoreDbContext();

        static void Main(string[] args)
        {
            _context.Database.EnsureCreated();
        }

        private static List<EpisodeInformation> GetEpisodeInformation()
        {
            return _context.viewEpisodes.AsNoTracking().ToList();
        }

        private static List<IFrequentCharacters> ExecutespSummariseEpisodes()
        {
            List<IFrequentCharacters> frequentCharacters = new List<IFrequentCharacters>();

            using (var command = _context.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "spSummariseEpisodes";
                command.CommandType = CommandType.StoredProcedure;
                _context.Database.OpenConnection();
                var dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    int companionId = dataReader.GetInt32(dataReader.GetOrdinal("CompanionId"));
                    int frequency = dataReader.GetInt32(dataReader.GetOrdinal("number"));
                    frequentCharacters.Add(new FrequentCompanions { CompanionId = companionId, Frequency = frequency });
                }
                dataReader.NextResult();
                while (dataReader.Read())
                {
                    int enemyId = dataReader.GetInt32(dataReader.GetOrdinal("EnemyId"));
                    int frequency = dataReader.GetInt32(dataReader.GetOrdinal("number"));
                    frequentCharacters.Add(new FrequentEnemies { EnemyId = enemyId, Frequency = frequency });
                }
            }
            return frequentCharacters;
        }
    }
}
