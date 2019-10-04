using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OctoberCourses2.Respositories;
using OctoberCourses2.Models;

namespace OctoberCourses2.Controllers
{
    public class CourseController : Controller
    {
        IRepository<Courses> courseRepo;
        public CourseController(IRepository<Courses> courseRepo)
        {
            this.courseRepo = courseRepo;
        }
        public ViewResult Index()
        {
            //CourseRespository courseRepo = new CourseRespository();
            var model = courseRepo.GetAll();
            return View(model);
        }
        public ViewResult Details(int id)
        {
            var model = courseRepo.GetByID(id);
            return View(model);
        }
    }
}