using System.Linq;

namespace DoctorWho.Db.Repositories
{
    class CompanionRepository
    {
        private readonly DoctorWhoCoreDbContext _context;
        public CompanionRepository(DoctorWhoCoreDbContext context)
        {
            _context = context;
        }

        public void UpdateCompanion(int companionId, Companion newCompanion)
        {
            var oldCompanion = _context.Companion.Where(S => S.CompanionId == companionId).First<Companion>();
            oldCompanion.CompanionName = newCompanion.CompanionName;
            oldCompanion.WhoPlayed = newCompanion.WhoPlayed;
            _context.SaveChanges();
        }

        public void DeleteCompanion(int companionId)
        {
            var companion = _context.Companion.Where(S => S.CompanionId == companionId).First<Companion>();
            _context.Remove(companion);
            _context.SaveChanges();
        }

        public Companion GetCompanion(int CompanionId)
        {
            return _context.Companion.Where(S => S.CompanionId == CompanionId).First<Companion>();
        }
    }
}
