using System.Collections.Generic;
using System.Linq;

namespace DoctorWho.Db.Repositories
{
    class DoctorRepository
    {
        private readonly DoctorWhoCoreDbContext _context;

        public DoctorRepository(DoctorWhoCoreDbContext context)
        {
            _context = context;
        }
        public void UpdateDoctor(int doctorId, Doctor newDoctor)
        {
            var oldDoctor = _context.Doctor.Where(S => S.DocotrId == doctorId).First<Doctor>();
            oldDoctor.DoctorName = newDoctor.DoctorName;
            oldDoctor.BirthDate = newDoctor.BirthDate;
            oldDoctor.DoctorNumber = newDoctor.DoctorNumber;
            oldDoctor.FirstEpisodeDate = newDoctor.FirstEpisodeDate;
            oldDoctor.LastEpisodeDate = newDoctor.LastEpisodeDate;
            _context.SaveChanges();
        }

        public void DeleteDoctor(int doctorId)
        {
            var doctor = _context.Doctor.Where(S => S.DocotrId == doctorId).First<Doctor>();
            _context.Remove(doctor);
            _context.SaveChanges();
        }

        public List<Doctor> GetDoctor()
        {
            return _context.Doctor.ToList<Doctor>();
        }
    }
}
