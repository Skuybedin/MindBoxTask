using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MindBoxLib.Tests
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void Square_12_Return_452_4()
        {
            //arrange
            Circle circle = new Circle("Circle",12);
            double expected = 452.4;

            //act
            double result = circle.CalcSquare();

            //assert
            Assert.AreEqual(expected, result);
        }
    }

    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void Square_4_4_5_Return_7_8()
        {
            //arrange
            Triangle triangle = new Triangle("Triangle", 4, 4, 5);
            double expected = 7.8;

            //act
            double result = triangle.CalcSquare();

            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void isRectangle_NotRectangle_ReturnFalse()
        {
            //Arrange
            var triangle = new Triangle("Triangle",2,3,4);

            //Act
            var result = triangle.IsRectangular();

            //Assert
            Assert.IsFalse(result);
        }
    }
}
