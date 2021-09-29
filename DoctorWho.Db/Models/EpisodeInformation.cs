using System;
using System.ComponentModel.DataAnnotations;

namespace DoctorWho.Db
{
    public class EpisodeInformation
    {
        [Key]
        public int EpisodeId { get; private set; }
        public int SeriesNumber { get; private set; }
        public int EpisodeNumber { get; private set; }
        public string EpisodeType { get; private set; }
        public string Title { get; private set; }
        public DateTime EpisodeDate { get; private set; }
        public int AuthorId { get; private set; }
        public int DoctorId { get; private set; }
        public string Notes { get; private set; }
        public string Authors { get; private set; }
        public string Doctors { get; private set; }
        public string Enemies { get; private set; }
        public string Companions { get; private set; }
    }
}
