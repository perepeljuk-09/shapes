using Microsoft.VisualStudio.TestTools.UnitTesting;
using shapes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace shapes.Models.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void TriangleExceptionBySideless0()
        {
            // arrange
            int firstSide = -1;
            int secondSide = 1;
            int thirdSide = 2;

            // Assert
            Assert.ThrowsException<Exception>(() => new Triangle(firstSide, secondSide, thirdSide));
        }
        [TestMethod]
        public void TriangleExceptionBySideEquals0()
        {
            // arrange
            int firstSide = 0;
            int secondSide = 1;
            int thirdSide = 2;

            // Assert
            Assert.ThrowsException<Exception>(() => new Triangle(firstSide, secondSide, thirdSide));
        }

        [TestMethod]
        public void GetSquare6()
        {
            // arrange
            int firstSide = 5;
            int secondSide = 4;
            int thirdSide = 3;
            float expected = 6;

            // act
            Triangle tr = new Triangle(firstSide, secondSide,thirdSide);
            float actual = tr.GetSquare();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsRectangularTrue()
        {
            // arrange
            int firstSide = 5;
            int secondSide = 4;
            int thirdSide = 3;

            bool expected = true;

            // act
            Triangle tr = new Triangle(firstSide, secondSide, thirdSide);
            bool actual = tr.CheckIsRectangular();

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IsRectangularFalse()
        {
            // arrange
            int firstSide = 10;
            int secondSide = 4;
            int thirdSide = 3;

            bool expected = false;

            // act
            Triangle tr = new Triangle(firstSide, secondSide, thirdSide);
            bool actual = tr.CheckIsRectangular();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Gipotenuze20()
        {
            // arrange
            int firstSide = 20;
            int secondSide = 4;
            int thirdSide = 3;

            int expected = 20;

            // act
            Triangle tr = new Triangle(firstSide, secondSide, thirdSide);

            MethodInfo methodInfo = tr.GetType().GetMethod("GetGipotenuzeAndKatets",BindingFlags.NonPublic | BindingFlags.Instance);


            (int, int, int) actual = ((int, int, int))methodInfo.Invoke(tr, null);

            // assert
            Assert.AreEqual(expected, actual.Item1);
        }
    }
}