using Hospital.DBModel;
using Hospital.Repository.EFRepository;

namespace Hospital.EFRepository
{
    public class EfAppointmentRepository : EfBaseRepository<Appointment>
    {
        private readonly HospitalContext _context;

        public EfAppointmentRepository(HospitalContext context) : base(context)
        {
            _context = context;
        }
    }
}
