using Hospital.Model;
using System;

namespace Hospital.Repository
{
    public class NurseRepository:BaseRepository<Nurse>
    {
        public override void AddData(Nurse nurse)
        {
            Console.WriteLine("Hello override");
           
        }

    }
}
