
using System.Collections.Generic;

namespace StudentsAndCourses.Models
{
   public class School
    {
        private List<Course> courses;
        private List<Student> students;

        public School()
        {
            this.courses = new List<Course>();
            this.students = new List<Student>();
        }
    }
}
