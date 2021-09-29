using System.Linq;

namespace DoctorWho.Db.Repositories
{
    class AuthorRepository
    {
        private readonly DoctorWhoCoreDbContext _context;

        public AuthorRepository(DoctorWhoCoreDbContext context)
        {
            _context = context;
        }

        public void UpdateAuthor(int authorId, Author oldAuthor)
        {
            var newAuthor = _context.Author.Where(S => S.AuthorId == authorId).First<Author>();
            newAuthor.AuthorName = oldAuthor.AuthorName;
            _context.SaveChanges();
        }

        public void DeleteAuthor(int authorId)
        {
            var author = _context.Author.Where(S => S.AuthorId == authorId).First<Author>();
            _context.Remove(author);
            _context.SaveChanges();

        }
    }
}
