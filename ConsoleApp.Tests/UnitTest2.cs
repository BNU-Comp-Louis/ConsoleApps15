using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App02;
using System;

namespace ConsoleApp.Tests

{
    [TestClass]
    public class TestBmiCalculator
    {
        [TestMethod]

        public void TestLowestUnderWeightMetric()
        {
            BmiCalculator bmi = new BmiCalculator();

            bmi.Kilograms = 45;
            bmi.Centimetres = 191;

            bmi.CalculateMetric();

            double expectedBmiUser = 12;

            Assert.AreEqual(expectedBmiUser, Math.Floor(bmi.BmiUser));
        }

        [TestMethod]

        public void TestLowestUnderWeightImperial()
        {
            BmiCalculator bmi = new BmiCalculator();

            bmi.Stone = 7;
            bmi.Pounds = 0;
            bmi.Feet = 6;
            bmi.Inches = 3;

            bmi.CalculateImperial();

            double expectedBmiUser = 12;

            Assert.AreEqual(expectedBmiUser, Math.Floor(bmi.BmiUser));
        }

        [TestMethod]

        public void TestLowestNormalWeightMetric()
        {
            BmiCalculator bmi = new BmiCalculator();

            bmi.Kilograms = 70;
            bmi.Centimetres = 191;

            bmi.CalculateMetric();

            double expectedBmiUser = 19;

            Assert.AreEqual(expectedBmiUser, Math.Floor(bmi.BmiUser));
        }

        [TestMethod]

        public void TestLowestNormalWeightImperial()
        {
            BmiCalculator bmi = new BmiCalculator();

            bmi.Stone = 11;
            bmi.Pounds = 0;
            bmi.Feet = 6;
            bmi.Inches = 3;

            bmi.CalculateImperial();

            double expectedBmiUser = 19;

            Assert.AreEqual(expectedBmiUser, Math.Floor(bmi.BmiUser));
        }

        [TestMethod]

        public void TestLowestOverweightMetric()
        {
            BmiCalculator bmi = new BmiCalculator();

            bmi.Kilograms = 92;
            bmi.Centimetres = 191;

            bmi.CalculateMetric();

            double expectedBmiUser = 25;

            Assert.AreEqual(expectedBmiUser, Math.Floor(bmi.BmiUser));
        }

        [TestMethod]

        public void TestLowestOverweightImperial ()
        {
            BmiCalculator bmi = new BmiCalculator();

            bmi.Stone = 14;
            bmi.Pounds = 5;
            bmi.Feet = 6;
            bmi.Inches = 3;

            bmi.CalculateImperial();

            double expectedBmiUser = 25;

            Assert.AreEqual(expectedBmiUser, Math.Floor(bmi.BmiUser));
        }

        [TestMethod]

        public void TestLowestObeaseClassIMetric()
        {
            BmiCalculator bmi = new BmiCalculator();

            bmi.Kilograms = 110;
            bmi.Centimetres = 191;

            bmi.CalculateMetric();

            double expectedBmiUser = 30;

            Assert.AreEqual(expectedBmiUser, Math.Floor(bmi.BmiUser));
        }

        [TestMethod]

        public void TestLowestObeaseClassIImperial()
        {
            BmiCalculator bmi = new BmiCalculator();

            bmi.Stone = 17;
            bmi.Pounds = 3;
            bmi.Feet = 6;
            bmi.Inches = 3;

            bmi.CalculateImperial();

            double expectedBmiUser = 30;

            Assert.AreEqual(expectedBmiUser, Math.Floor(bmi.BmiUser));
        }

        [TestMethod]

        public void TestLowestObeaseClassIIMetric()
        {
            BmiCalculator bmi = new BmiCalculator();

            bmi.Kilograms = 129;
            bmi.Centimetres = 191;

            bmi.CalculateMetric();

            double expectedBmiUser = 35;

            Assert.AreEqual(expectedBmiUser, Math.Floor(bmi.BmiUser));
        }

        [TestMethod]

        public void TestLowestObeaseClassIIImperial()
        {
            BmiCalculator bmi = new BmiCalculator();

            bmi.Stone = 20;
            bmi.Pounds = 2;
            bmi.Feet = 6;
            bmi.Inches = 3;

            bmi.CalculateImperial();

            double expectedBmiUser = 35;

            Assert.AreEqual(expectedBmiUser, Math.Floor(bmi.BmiUser));
        }

        [TestMethod]

        public void TestLowestObeaseClassIIIMetric()
        {
            BmiCalculator bmi = new BmiCalculator();

            bmi.Kilograms = 147;
            bmi.Centimetres = 191;

            bmi.CalculateMetric();

            double expectedBmiUser = 40;

            Assert.AreEqual(expectedBmiUser, Math.Floor(bmi.BmiUser));
        }


        [TestMethod]

        public void TestLowestObeaseClassIIIImperial()
        {
            BmiCalculator bmi = new BmiCalculator();

            bmi.Stone = 23;
            bmi.Pounds = 1;
            bmi.Feet = 6;
            bmi.Inches = 3;

            bmi.CalculateImperial();

            double expectedBmiUser = 40;

            Assert.AreEqual(expectedBmiUser, Math.Floor(bmi.BmiUser));
        }

        [TestMethod]

        public void TestHighestUnderWeightMetric()
        {
            BmiCalculator bmi = new BmiCalculator();

            bmi.Kilograms = 67;
            bmi.Centimetres = 191;

            bmi.CalculateMetric();

            double expectedBmiUser = 18;

            Assert.AreEqual(expectedBmiUser, Math.Floor(bmi.BmiUser));
        }

        [TestMethod]

        public void TestHighestUnderWeightImperial()
        {
            BmiCalculator bmi = new BmiCalculator();

            bmi.Stone = 10;
            bmi.Pounds = 5;
            bmi.Feet = 6;
            bmi.Inches = 3;

            bmi.CalculateImperial();

            double expectedBmiUser = 18;

            Assert.AreEqual(expectedBmiUser, Math.Floor(bmi.BmiUser));
        }

        [TestMethod]

        public void TestHighestNormalWeightMetric()
        {
            BmiCalculator bmi = new BmiCalculator();

            bmi.Kilograms = 88;
            bmi.Centimetres = 191;

            bmi.CalculateMetric();

            double expectedBmiUser = 24;

            Assert.AreEqual(expectedBmiUser, Math.Floor(bmi.BmiUser));
        }

        [TestMethod]

        public void TestHighestNormalWeightImperial()
        {
            BmiCalculator bmi = new BmiCalculator();

            bmi.Stone = 13;
            bmi.Pounds = 12;
            bmi.Feet = 6;
            bmi.Inches = 3;

            bmi.CalculateImperial();

            double expectedBmiUser = 24;

            Assert.AreEqual(expectedBmiUser, Math.Floor(bmi.BmiUser));
        }

        [TestMethod]

        public void TestHighestOverweightMetric()
        {
            BmiCalculator bmi = new BmiCalculator();

            bmi.Kilograms = 107;
            bmi.Centimetres = 191;

            bmi.CalculateMetric();

            double expectedBmiUser = 29;

            Assert.AreEqual(expectedBmiUser, Math.Floor(bmi.BmiUser));
        }

        [TestMethod]

        public void TestHighestOverweightImperial()
        {
            BmiCalculator bmi = new BmiCalculator();

            bmi.Stone = 16;
            bmi.Pounds = 9;
            bmi.Feet = 6;
            bmi.Inches = 3;

            bmi.CalculateImperial();

            double expectedBmiUser = 29;

            Assert.AreEqual(expectedBmiUser, Math.Floor(bmi.BmiUser));
        }

        [TestMethod]

        public void TestHighestObeaseClassIMetric()
        {
            BmiCalculator bmi = new BmiCalculator();

            bmi.Kilograms = 126;
            bmi.Centimetres = 191;

            bmi.CalculateMetric();

            double expectedBmiUser = 34;

            Assert.AreEqual(expectedBmiUser, Math.Floor(bmi.BmiUser));
        }

        [TestMethod]

        public void TestHighestObeaseClassIImperial()
        {
            BmiCalculator bmi = new BmiCalculator();

            bmi.Stone = 19;
            bmi.Pounds = 8;
            bmi.Feet = 6;
            bmi.Inches = 3;

            bmi.CalculateImperial();

            double expectedBmiUser = 34;

            Assert.AreEqual(expectedBmiUser, Math.Floor(bmi.BmiUser));
        }

        [TestMethod]

        public void TestHighestObeaseClassIIMetric()
        {
            BmiCalculator bmi = new BmiCalculator();

            bmi.Kilograms = 143;
            bmi.Centimetres = 191;

            bmi.CalculateMetric();

            double expectedBmiUser = 39;

            Assert.AreEqual(expectedBmiUser, Math.Floor(bmi.BmiUser));
        }

        [TestMethod]

        public void TestHighestObeaseClassIIImperial()
        {
            BmiCalculator bmi = new BmiCalculator();

            bmi.Stone = 22;
            bmi.Pounds = 5;
            bmi.Feet = 6;
            bmi.Inches = 3;

            bmi.CalculateImperial();

            double expectedBmiUser = 39;

            Assert.AreEqual(expectedBmiUser, Math.Floor(bmi.BmiUser));
        }

        [TestMethod]

        public void TestHighestObeaseClassIIIMetric()
        {
            BmiCalculator bmi = new BmiCalculator();

            bmi.Kilograms = 161;
            bmi.Centimetres = 191;

            bmi.CalculateMetric();

            double expectedBmiUser = 44;

            Assert.AreEqual(expectedBmiUser, Math.Floor(bmi.BmiUser));
        }


        [TestMethod]

        public void TestHighestObeaseClassIIIImperial()
        {
            BmiCalculator bmi = new BmiCalculator();

            bmi.Stone = 25;
            bmi.Pounds = 3;
            bmi.Feet = 6;
            bmi.Inches = 3;

            bmi.CalculateImperial();

            double expectedBmiUser = 44;

            Assert.AreEqual(expectedBmiUser, Math.Floor(bmi.BmiUser));
        }

    }
}

