using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibrarySquare.Tests
{
    [TestClass]
    public class CalculationTests
    {
        public string expectedError = "Нет возможности расчета, проверьте данные!";

        [TestMethod]
        public void Square_CircleRadius_ReturnsCorrectResult()
        {
            Calculation calculation = new Calculation();
            double radius = 5;
            double expected = Math.PI * Math.Pow(radius, 2);
            var result = calculation.Square(radius);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Square_CircleNegativeRadius_ReturnsErrorMessage()
        {
            Calculation calculation = new Calculation();
            double radius = -5;
            var result = calculation.Square(radius);
            Assert.AreEqual(expectedError, result);
        }

        [TestMethod]
        public void Square_TetragonSides_ReturnsCorrectResult()
        {
            Calculation calculation = new Calculation();
            double firstSide = 4;
            double secondSide = 6;
            double expected = firstSide * secondSide;
            var result = calculation.Square(firstSide, secondSide);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Square_TetragonSides_ReturnsErrorMessage()
        {
            Calculation calculation = new Calculation();
            double firstSide = 0;
            double secondSide = 1;
            var result = calculation.Square(firstSide, secondSide);
            Assert.AreEqual(expectedError, result);
        }

        [TestMethod]
        public void Square_TriangleSides_ReturnsCorrectResult()
        {

            Calculation calculation = new Calculation();
            double firstSide = 3;
            double secondSide = 4;
            double thirdSide = 5;
            double expected = 6;
            var result = calculation.Square(firstSide, secondSide, thirdSide);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Square_TriangleInvalidSides_ReturnsErrorMessage()
        {
            Calculation calculation = new Calculation();
            double firstSide = 1;
            double secondSide = 2;
            double thirdSide = 10;
            var result = calculation.Square(firstSide, secondSide, thirdSide);
            Assert.AreEqual(expectedError, result);
        }
    }
}