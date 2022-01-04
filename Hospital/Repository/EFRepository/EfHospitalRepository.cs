using Hospital.DBModel;
using Hospital.Repository.EFRepository;

namespace Hospital.Repository.EFRepository
{
    public class EfHospitalRepository : EfBaseRepository<HospitalDb>
    {
        private readonly HospitalContext _context;

        public EfHospitalRepository(HospitalContext context) : base(context)
        {
            _context = context;
        }
    }
}
