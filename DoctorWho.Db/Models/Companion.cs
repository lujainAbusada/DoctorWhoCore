using System.ComponentModel.DataAnnotations;

namespace DoctorWho.Db
{
    public class Companion
    {
        [Key]
        public int CompanionId { get; set; }
        public string CompanionName { get; set; }
        public string WhoPlayed { get; set; }
    }
}
