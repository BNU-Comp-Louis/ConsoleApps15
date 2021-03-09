using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App03;
using System;
namespace ConsoleApp.Tests
{
    [TestClass]
    public class TestStudentGrades
    {
        private readonly StudentGrades studentGrades = new StudentGrades();

        private int[] testMarks;

        private readonly int[] StatsMarks = new int[]
        {
            10, 20, 30, 40, 50, 60, 70, 80, 90, 100
        };

        public TestStudentGrades()
        {
            testMarks = new int[]
            {
                10, 20, 30, 40, 50, 60, 70, 80, 90, 100
            };
        }

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

        [TestMethod]
        public void TestCalculateMean()
        {
            studentGrades.Marks = testMarks;
            double expectedMean = 55.0;
            studentGrades.CalculateStats();

            Assert.AreEqual(expectedMean, studentGrades.Mean);
        }

        [TestMethod]
        public void TestCalculateMin()
        {
            studentGrades.Marks = StatsMarks;
            int expectedMin = 10;

            studentGrades.CalculateStats();

            Assert.AreEqual(expectedMin, studentGrades.Minimum);
        }

        [TestMethod]
        public void TestGradeProfile()
        {
            studentGrades.Marks = testMarks;

            studentGrades.CalculateGradeProfile();

            bool expectedProfile;
            expectedProfile = ((studentGrades.GradeProfile[0] == 3) &&
                               (studentGrades.GradeProfile[1] == 1) &&
                               (studentGrades.GradeProfile[2] == 1) &&
                               (studentGrades.GradeProfile[3] == 1) &&
                               (studentGrades.GradeProfile[4] == 4));

            Assert.IsTrue(expectedProfile);

        }

    }
}
