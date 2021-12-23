using System;

namespace Hospital.Model
{
    public class BaseModel
    {
        public Guid Id { get; set; }

        public DateTime CreatedDate { get; set;}

        public DateTime UpdatedDate { get; set; } = DateTime.Now;


    }
}
