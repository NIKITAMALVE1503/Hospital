using Hospital.DBModel;
using Hospital.Repository.EFRepository;
using Doctor = Hospital.DBModel.Doctor;

namespace Hospital.Repository.EFRepository
{
    public class EfDoctorRepository : EfBaseRepository<Doctor>
    {
        private readonly HospitalContext _context;

        public EfDoctorRepository(HospitalContext context) : base(context)
        {
            _context = context;
        }
    }
}
