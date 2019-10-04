using System;
using Xunit;
using OctoberCourses2.Models;


namespace OctoberCourses2.Tests
{
    public class OctoberCourses2Tests
    {
        Courses undertest;

        public OctoberCourses2Tests()
        {
            undertest = new Courses(42, "Name", "Description");
        }
        [Fact]
        public void CourseConstructorSetsName()
        {
            var result = undertest.Name;
            Assert.Equal("Name", result);
        }
        [Fact]
        public void CourseConstructorSetsID()
        {
            var result = undertest.ID;
            Assert.Equal(42, result);
        }
        [Fact]
        public void CourseConstructorSetsDescription()
        {
            var result = undertest.Description;
            Assert.Equal("Description", result);
        }
        

        
    }
}
