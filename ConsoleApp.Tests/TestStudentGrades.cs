using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App03;
using System;
namespace ConsoleApp.Tests
{
    [TestClass]
    public class TestStudentGrades
    {
        private readonly StudentGrades converter = new StudentGrades();

        [TestMethod]
        public void TestConvert0ToGradeF()
        {
            // Arrange

            Grades expectedGrade = Grades.F;

            //act 

            Grades actualGrade = grades.ConverttoGrade(0);

            //Assert

            Assert.AreEqual(expectedGrade, actualGrade);
        }
    }
}
