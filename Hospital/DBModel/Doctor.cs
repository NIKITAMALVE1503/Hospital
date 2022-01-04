using System;
using System.Collections.Generic;

#nullable disable

namespace Hospital.DBModel
{
    public  class Doctor : BaseModel
    {
        public string Name { get; set; }
        public int? HospitalId { get; set; }
    }
}
