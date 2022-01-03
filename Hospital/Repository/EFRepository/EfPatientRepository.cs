using Hospital.DBModel;
using Hospital.Repository.EFRepository;

namespace Hospital.Repository.EFRepository
{
    public class EfPatientRepository : EfBaseRepository<Patient>
    {
        private readonly HospitalContext _context;

        public EfPatientRepository(HospitalContext context) : base(context)
        {
            _context = context;
        }
    }
}
