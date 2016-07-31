using System;
using System.Collections.Generic;

namespace StudentsAndCourses.Models
{
   public class Course
    {
        private List<Student> students;

        public Course()
        {
            this.students = new List<Student>();
        }

        public void addStudent(Student student)
        {
            if (students.Count>30)
            {
                throw new ArgumentException("Student must be only 30");
            }
            else
            {
                students.Add(student);
            }
        }
        public void removeStudent(Student student)
        {
            students.Remove(student);
        }
        public int Count
        {
            get
            {
                return this.students.Count;
            }
        }
    }
}

