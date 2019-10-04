using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OctoberCourses2.Respositories
{
    public interface IRepository<T> where T :class
    {
        IEnumerable<T> GetAll();
        T GetByID(int id);
    }
}
