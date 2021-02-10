using Microsoft.VisualStudio.TestTools.UnitTesting;
using T35_Laskutoimituksia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T35_Laskutoimituksia.Tests
{
    [TestClass()]
    public class ArrayCalsTests
    {
        [TestMethod()]
        public void SumTest()
        {
            //arrange
            double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            double expected = 25.6;
            //act
            double actual = ArrayCals.Sum(array);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AverageTest()
        {
            //arrange
            double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            double expected = 3.66;
            //act
            double actual = ArrayCals.Average(array);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MinTest()
        {
            double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            double expected = -4.5;
            //act
            double actual = ArrayCals.Min(array);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MaxTest()
        {
            double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            double expected = 12;
            //act
            double actual = ArrayCals.Max(array);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}