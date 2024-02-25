using LibrarySquare;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibrarySquareTests
{
    [TestClass]
    public class SquareTests
    {
        [TestMethod]
        public void Circle_Calculation_ValidRadius_ReturnsCorrectResult()
        {
            double radius = 5;
            Circle circle = new Circle();
            double result = circle.Calculation(radius);
            Assert.AreEqual(Math.PI * Math.Pow(radius, 2), result);
        }

        [TestMethod]
        public void Circle_Calculation_NegativeRadius_ReturnsZero()
        {
            double radius = -5;
            Circle circle = new Circle();
            double result = circle.Calculation(radius);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Tetragon_Calculation_ValidSides_ReturnsCorrectResult()
        {
            double firstSide = 4;
            double secondSide = 6;
            Tetragon tetragon = new Tetragon();
            double result = tetragon.Calculation(firstSide, secondSide);
            Assert.AreEqual(firstSide * secondSide, result);
        }

        [TestMethod]
        public void Tetragon_Calculation_NegativeSides_ReturnsZero()
        {
            double firstSide = -4;
            double secondSide = 6;
            Tetragon tetragon = new Tetragon();
            double result = tetragon.Calculation(firstSide, secondSide);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Triangle_Calculation_ValidSides_ReturnsCorrectResult()
        {
            double firstSide = 3;
            double secondSide = 4;
            double thirdSide = 5;
            Triangle triangle = new Triangle();
            double result = triangle.Calculation(firstSide, secondSide, thirdSide);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void Triangle_Calculation_InvalidSides_ReturnsZero()
        {
            double firstSide = 1;
            double secondSide = 2;
            double thirdSide = 10;
            Triangle triangle = new Triangle();
            double result = triangle.Calculation(firstSide, secondSide, thirdSide);
            Assert.AreEqual(0, result);
        }

    }

}
