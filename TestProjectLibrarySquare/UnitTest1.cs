using LibrarySquare;

namespace TestProjectLibrarySquare
{

        [TestFixture]
        public class CalculationTests
        {
            [Test]
            public void Square_CircleRadius_ReturnsCorrectResult()
            {
                // Arrange
                Calculation calculation = new Calculation();
                double radius = 5;
                double expected = Math.PI * Math.Pow(radius, 2);

                // Act
                var result = calculation.Square(radius);

                // Assert
                Assert.AreEqual(expected, result);
            }

            [Test]
            public void Square_CircleNegativeRadius_ReturnsErrorMessage()
            {
                // Arrange
                Calculation calculation = new Calculation();
                double radius = -5;
                string expected = "Нет возможности расчета, проверьте данные!";

                // Act
                var result = calculation.Square(radius);

                // Assert
                Assert.AreEqual(expected, result);
            }

            [Test]
            public void Square_TetragonSides_ReturnsCorrectResult()
            {
                // Arrange
                Calculation calculation = new Calculation();
                double firstSide = 4;
                double secondSide = 6;
                double expected = firstSide * secondSide;

                // Act
                var result = calculation.Square(firstSide, secondSide);

                // Assert
                Assert.AreEqual(expected, result);
            }

            [Test]
            public void Square_TriangleSides_ReturnsCorrectResult()
            {
                // Arrange
                Calculation calculation = new Calculation();
                double firstSide = 3;
                double secondSide = 4;
                double thirdSide = 5;
                double expected = 6; // Expected area of a 3-4-5 right triangle

                // Act
                var result = calculation.Square(firstSide, secondSide, thirdSide);

                // Assert
                Assert.AreEqual(expected, result);
            }

            [Test]
            public void Square_TriangleInvalidSides_ReturnsErrorMessage()
            {
                // Arrange
                Calculation calculation = new Calculation();
                double firstSide = 1;
                double secondSide = 2;
                double thirdSide = 10;
                string expected = "Нет возможности расчета, проверьте данные!";

                // Act
                var result = calculation.Square(firstSide, secondSide, thirdSide);

                // Assert
                Assert.AreEqual(expected, result);
            }
        }

}