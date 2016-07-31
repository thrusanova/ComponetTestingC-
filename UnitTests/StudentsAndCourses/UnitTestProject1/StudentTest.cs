
namespace School.Test

{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using StudentsAndCourses.Models;
    using System;
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void StudentNameIsNotNull()
        {
            var name = "Hristo";
            int id = 20000;
            var student = new Student(name,id);
            Assert.IsNotNull(student);
        }

        [TestMethod]
        public void StudentIdIsCorrectly()
        {
            var name = "Hristo";
            int id = 20000;
            var student = new Student(name, id);
            Assert.IsTrue(id >= 10000 || id <= 99999);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StudentNameIsNullThrowExeption()
        {
            var name = "";
            int id = 50000;
            var student = new Student(name, id);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void StudenIdIsNotInRange()
        {
            var name = "Hristo";
            int id = 2000;
            var student = new Student(name, id);
            Assert.IsTrue(id >= 10000 || id <= 99999);
        }

    }
}
