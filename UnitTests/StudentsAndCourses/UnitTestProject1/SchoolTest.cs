
namespace School.Test

{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using StudentsAndCourses.Models;

    [TestClass]
    public class SchoolTest
    {
        [TestMethod]
        public void SchoolInitRight()
        {
            var school = new School();
            Assert.IsNotNull(school);
        }
    }
}
