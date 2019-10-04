using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using OctoberCourses2.Models;
using Xunit;
using OctoberCourses2.Controllers;


namespace OctoberCourses2.Tests
{
    public class CourseControllerTests
    {
        CourseController undertest;
        
        

        [Fact]
        public void IndexReturnsView()
        {
            var result = undertest.Index();
            Assert.IsType<ViewResult>(result);
           
        }
        [Fact]
        public void IndexPassesCoursesModelToView()
        {
            var result = undertest.Index();
            Assert.IsType<List<Courses>>(result.Model);

        }

    }
}
