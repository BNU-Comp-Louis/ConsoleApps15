using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App03;
using System;
namespace ConsoleApp.Tests
{
    [TestClass]
    public class TestStudentGrades
    {
        private readonly StudentGrades studentGrades = new StudentGrades();

        [TestMethod]
        public void TestConvert0ToGradeF()
        {
            // Arrange

            Grades expectedGrade = Grades.F;

            //act 

            Grades actualGrade = studentGrades.ConvertToGrade(0);

            //Assert

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert39ToGradeF()
        {
            // Arrange

            Grades expectedGrade = Grades.F;

            //act 

            Grades actualGrade = studentGrades.ConvertToGrade(39);

            //Assert

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert40ToGradeD()
        {
            // Arrange

            Grades expectedGrade = Grades.D;

            //act 

            Grades actualGrade = studentGrades.ConvertToGrade(40);

            //Assert

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert49ToGradeD()
        {
            // Arrange

            Grades expectedGrade = Grades.D;

            //act 

            Grades actualGrade = studentGrades.ConvertToGrade(49);

            //Assert

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert50ToGradeC()
        {
            // Arrange

            Grades expectedGrade = Grades.C;

            //act 

            Grades actualGrade = studentGrades.ConvertToGrade(50);

            //Assert

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert59ToGradeC()
        {
            // Arrange

            Grades expectedGrade = Grades.C;

            //act 

            Grades actualGrade = studentGrades.ConvertToGrade(59);

            //Assert

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert60ToGradeB()
        {
            // Arrange

            Grades expectedGrade = Grades.B;

            //act 

            Grades actualGrade = studentGrades.ConvertToGrade(60);

            //Assert

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert69ToGradeB()
        {
            // Arrange

            Grades expectedGrade = Grades.B;

            //act 

            Grades actualGrade = studentGrades.ConvertToGrade(69);

            //Assert

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert70ToGradeA()
        {
            // Arrange

            Grades expectedGrade = Grades.A;

            //act 

            Grades actualGrade = studentGrades.ConvertToGrade(70);

            //Assert

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert100ToGradeA()
        {
            // Arrange

            Grades expectedGrade = Grades.A;

            //act 

            Grades actualGrade = studentGrades.ConvertToGrade(100);

            //Assert

            Assert.AreEqual(expectedGrade, actualGrade);
        }
    }
}
