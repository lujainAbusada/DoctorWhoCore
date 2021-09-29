using System.Linq;

namespace DoctorWho.Db.Repositories
{
    class EnemyRepository
    {
        private readonly DoctorWhoCoreDbContext _context;
 
        public EnemyRepository(DoctorWhoCoreDbContext context)
        {
            _context = context;
        }
        
        public void UpdateEnemy(int enemyId, Enemy newEnemy)
        {
            var oldEnemy = _context.Enemy.Where(S => S.EnemyId == enemyId).First<Enemy>();
            oldEnemy.EnemyName = newEnemy.EnemyName;
            oldEnemy.Description = newEnemy.Description;
            _context.SaveChanges();
        }

        public void DeleteEnemy(int enemyId)
        {
            var enemy = _context.Enemy.Where(S => S.EnemyId == enemyId).First<Enemy>();
            _context.Remove(enemy);
            _context.SaveChanges();
        }

        public Enemy GetEnemy(int EnemyId)
        {
            return _context.Enemy.Where(S => S.EnemyId == EnemyId).First<Enemy>();
        }
    }
}
