using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OctoberCourses2.Models;

namespace OctoberCourses2.Respositories
{
    public class CourseRespository : IRepository<Courses>
    {
        public List<Courses> coursesList;

        public CourseRespository()
        {
            coursesList = new List<Courses>()
            {
                new Courses(1, "Machine Learning", "No, Don't let machines learn"),
                new Courses(2, "C# For Dummies", "Thing"),
                new Courses(3, "thingything", "Thingythingtthing")
            };
        }



        public IEnumerable<Courses> GetAll()
        {
            return coursesList;
        }

        public Courses GetByID(int id)
        {
            return coursesList.Single(c => c.ID == id);
        }
    }
}
