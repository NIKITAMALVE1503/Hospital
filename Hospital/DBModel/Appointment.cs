using Hospital.DBModel;
using System;
using System.Collections.Generic;



namespace Hospital.DBModel
{
    public  class Appointment : BaseModel
    {
       
        public int? DoctorId { get; set; }
        public bool? NineToTen { get; set; }
        public bool? TenToEleven { get; set; }
    }
}
