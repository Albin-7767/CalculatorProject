using NUnit.Framework;
using CalculatorLibrary; 

namespace CalculatorTests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        // Addition Tests
        [Test]
        public void Add_PositiveNumbers_ReturnsCorrectSum()
        {
            // Arrange
            int a = 5, b = 10;

            // Act
            int result = _calculator.Add(a, b);

            // Assert
            Assert.AreEqual(15, result);
        }

        [Test]
        public void Add_NegativeNumbers_ReturnsCorrectSum()
        {
            // Arrange
            int a = -5, b = -10;

            // Act
            int result = _calculator.Add(a, b);

            // Assert
            Assert.AreEqual(-15, result);
        }

        // Subtraction Tests
        [Test]
        public void Subtract_PositiveNumbers_ReturnsCorrectDifference()
        {
            // Arrange
            int a = 10, b = 5;

            // Act
            int result = _calculator.Subtract(a, b);

            // Assert
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Subtract_NegativeNumbers_ReturnsCorrectDifference()
        {
            // Arrange
            int a = -10, b = -5;

            // Act
            int result = _calculator.Subtract(a, b);

            // Assert
            Assert.AreEqual(-5, result);
        }

        // Multiplication Tests
        [Test]
        public void Multiply_PositiveNumbers_ReturnsCorrectProduct()
        {
            // Arrange
            int a = 4, b = 3;

            // Act
            int result = _calculator.Multiply(a, b);

            // Assert
            Assert.AreEqual(12, result);
        }

        [Test]
        public void Multiply_NumberByZero_ReturnsZero()
        {
            // Arrange
            int a = 5, b = 0;

            // Act
            int result = _calculator.Multiply(a, b);

            // Assert
            Assert.AreEqual(0, result);
        }

        // Division Tests
        [Test]
        public void Divide_PositiveNumbers_ReturnsCorrectQuotient()
        {
            // Arrange
            int a = 10, b = 2;

            // Act
            int result = _calculator.Divide(a, b);

            // Assert
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Divide_ByZero_ThrowsException()
        {
            // Arrange
            int a = 10, b = 0;

            // Act & Assert
            Assert.Throws<System.DivideByZeroException>(() => _calculator.Divide(a, b));
        }
    }
}
