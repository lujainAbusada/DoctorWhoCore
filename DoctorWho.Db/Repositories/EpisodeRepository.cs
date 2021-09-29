using System.Linq;

namespace DoctorWho.Db.Repositories
{
    public class EpisodeRepository
    {
        private DoctorWhoCoreDbContext _context;
     
        public EpisodeRepository(DoctorWhoCoreDbContext context)
        {
            _context = context;
        }

        public void UpdateEpisode(int episodeId, Episode newEpisode)
        {
            var oldEpisode = _context.Episode.Where(S => S.EpisodeId == episodeId).First<Episode>();
            oldEpisode.SeriesNumber = newEpisode.SeriesNumber;
            oldEpisode.EpisodeNumber = newEpisode.EpisodeNumber;
            oldEpisode.EpisodeType = newEpisode.EpisodeType;
            oldEpisode.Title = newEpisode.Title;
            oldEpisode.Notes = newEpisode.Notes;
            oldEpisode.DoctorId = newEpisode.DoctorId;
            oldEpisode.AuthorId = newEpisode.AuthorId;
            _context.SaveChanges();
        }

        public void DeleteEpisode(int episodeId)
        {
            var episode = _context.Episode.Where(S => S.EpisodeId == episodeId).First<Episode>();
            _context.Remove(episode);
            _context.SaveChanges();
        }

        public void AddEnemyToEpisode(int enemyId, int episodeId)
        {
            _context.EpisodeEnemy.Add(new EpisodeEnemy { EpisodeId = episodeId, EnemyId = enemyId });
            _context.SaveChanges();
        }

        public void AddCompanionToEpisode(int companionId, int episodeId)
        {
            _context.EpisodeCompanion.Add(new EpisodeCompanion { EpisodeId = episodeId, CompanionId = companionId });
            _context.SaveChanges();
        }
    }
}
