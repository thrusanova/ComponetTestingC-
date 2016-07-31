using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using StudentsAndCourses.Models;

namespace School.Tests
{
    [TestFixture]
    public class CourseTest
    {
        [TestCase]
        public void CourseInitRight()
        {
            var course = new Course();
            Assert.IsNotNull(course);
        }

        [TestCase]
        public void AddCoursesRight()
        {
            var course = new Course();
            //var students = new List<Student>();
            var student = new Student("pesho", 20000);
           course.addStudent(student);
           // students.Add(student);
            Assert.AreEqual(course.Count,course.Count);
        }

        [TestCase]
        public void RemoveStudentsCorrectly()
        {
            var course = new Course();
            var student = new Student("pesho", 20000);
            course.addStudent(student);
             course.removeStudent(student);
            Assert.AreEqual(0,course.Count);
        }

        [TestCase]
        public void AddMoreThan30Students()
        {
            var course = new Course();
            TestDelegate test = () =>
            {
                for (int i = 0; i < 50; i++)
                {
                    var student = new Student("someName", 20000);
                    course.addStudent(student);
                }
            };
            Assert.Throws(typeof(ArgumentException),test);
        }

    }
}
