using Hospital.DBModel;
using Hospital.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hospital.Repository
{
    public interface IBaseRepository<T>
    {
        public List<T> GetAll();
        public T GetById(Guid id);
        public  string Add(T entity);
        public  string Update(T entity);
        public  string Delete(Guid id);
    }
}
