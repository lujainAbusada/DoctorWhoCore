using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DoctorWho.Db
{
    public class Episode
    {
        [Key]
        public int EpisodeId { get; set; }
        public int SeriesNumber { get; set; }
        public int EpisodeNumber { get; set; }
        public string EpisodeType { get; set; }
        public string Title { get; set; }
        public DateTime EpisodeDate { get; set; }
        public int AuthorId { get; set; }
        public int DoctorId { get; set; }
        public string Notes { get; set; }
        public List<EpisodeCompanion> EpisodeCompanion { get; set; }
        public List<EpisodeEnemy> EpisodeEnemy { get; set; }


    public Episode()
    {
            EpisodeCompanion = new List<EpisodeCompanion>();
            EpisodeEnemy = new List<EpisodeEnemy>();
        }
    }
}
