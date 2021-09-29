using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DoctorWho.Db
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public List<Episode> Episodes { get; set; }
    }
}
