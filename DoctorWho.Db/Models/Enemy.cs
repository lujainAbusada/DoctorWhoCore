using System.ComponentModel.DataAnnotations;

namespace DoctorWho.Db
{
    public class Enemy
    {
        [Key]
        public int EnemyId { get; set; }
        public string EnemyName { get; set; }
        public string Description { get; set; }
    }
}
