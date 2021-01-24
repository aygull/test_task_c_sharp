using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Figures
{
    [TestClass]
    public class FiguresClassTest
    {
        [TestMethod]
        public void TestMethod1()
        {

        }

        /// <summary>
        /// Тестируем отрицательный радиус круга
        /// </summary>
        [TestMethod]
        public void CircleNegativeRadiusTest()
        {
            Assert.ThrowsException<ArgumentException>(() => new Circle(-10));
        }

        /// <summary>
        /// Тестируем отрицательные стороны треугольника
        /// </summary>
        [TestMethod]
        public void TriangleNegativeSidesTest()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(-10, 0, 0));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(0, -10, 0));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(0, 0, -10));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(-10, -10, -10));
        }

        /// <summary>
        /// Тестируем вычисление площади круга
        /// </summary>
        [TestMethod]
        public void CircleSqrCalculationTest()
        {
            //Arrange
            var circle = new Circle(10);

            //Act
            double circleSquare = circle.GetArea();

            //Assert
            Assert.AreEqual(314.15926535897931, circleSquare);
        }

        /// <summary>
        /// Тестируем вычисление площади тиугольника
        /// </summary>
        [TestMethod]
        public void TriangleSqrCalculationTest()
        {
            //Arrange
            var triangle = new Triangle(3, 4, 5);

            //Act
            double triangleSquare = triangle.GetArea();

            //Assert
            Assert.AreEqual(6, triangleSquare);
        }

        /// <summary>
        /// Тестируем прямоугольный треугольник
        /// </summary>
        [TestMethod]
        public void RightAngleTriangleTest()
        {
            //Arrange
            var triangle = new Triangle(3, 4, 5);

            //Act
            var isRectangular = triangle.IsRectangular();

            //Assert
            Assert.AreEqual(true, isRectangular);
        }

        /// <summary>
        /// Тестируем не прямоугольный треугольник
        /// </summary>
        [TestMethod]
        public void NotRightAngleTriangleTest()
        {
            //Arrange
            var triangle = new Triangle(6, 2, 5);

            //Act
            var isTriangleRightAngled = triangle.IsRectangular();

            //Assert
            Assert.AreEqual(false, isTriangleRightAngled);
        }
    }
}