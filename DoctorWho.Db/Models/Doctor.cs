using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DoctorWho.Db
{
    public class Doctor
    {
        [Key]
        public int DocotrId { get; set; }
        public long DoctorNumber { get; set; }
        public string DoctorName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime FirstEpisodeDate { get; set; }
        public DateTime LastEpisodeDate { get; set; }
        public List<Episode> Episodes { get; set; }
    }
}
