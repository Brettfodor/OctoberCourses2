using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OctoberCourses2.Models
{
    public class Courses
    {
      public int ID { get; set;} 
      public string Name { get; set; }
      public string Description { get; set; }

        public Courses()
        { }
        public Courses(int id, string name, string description)
        {
            Name = name;
            ID = id;
            Description = description;
                
        }
    }
    
}
