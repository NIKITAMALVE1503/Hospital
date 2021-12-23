using Hospital.Model;
using System;

namespace Hospital.Repository
{
    public abstract class BaseRepository<T> where T : BaseModel
    {
         public virtual void  AddData(T record) 
        {
            
            var id = new Guid();
            record.Id = id;
            record.UpdatedDate = DateTime.Now;
           
            Console.WriteLine("Base method");

        }
        public virtual void GetData()
        {

        }
        public virtual void DeleteData()
        {

        }
    }
}
