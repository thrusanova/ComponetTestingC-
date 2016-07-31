
namespace StudentsAndCourses.Models
{
    using System;

    public class Student
    {
        private string name;

        private int id;
        public Student(string name,int id)
        {
            this.Name = name;
            this.Id = id;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name cannot be empty!");
                }
                this.name = value;
            }
        }

        public int Id
        {
            get
            {
                return this.id;
            }
            private set
            {
                if (value<10000 || value>99999)
                {
                    throw new ArgumentOutOfRangeException("The ID must be between 10000 and 99999");
                }
                this.id = value;
            }
        }

    }
}
