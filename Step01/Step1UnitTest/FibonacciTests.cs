
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Step1UnitTest
{
    [TestClass]
    public class FibonacciTests
    {
        [TestMethod]
        public void CalculateFibonacciAlgorithm_EighthSentence_Return8()
        {
            // Arrange
            int result = 0;

            // Act
            int[]? fibonacci = Fibonacci.Fibonacci.CalculateFibonacciAlgorithm(8);
            result = fibonacci[fibonacci.Length - 1];

            // Assert
            Assert.AreEqual(13, result);
        }

        [TestMethod]
        public void CalculateFibonacciAlgorithm_NinthSentence_Return13()
        {
            // Arrange
            int result = 0;

            // Act
            int[]? fibonacci = Fibonacci.Fibonacci.CalculateFibonacciAlgorithm(9);
            result = fibonacci[fibonacci.Length - 1];

            // Assert
            Assert.AreEqual(21, result);
        }

        [TestMethod]
        public void CalculateFibonacciAlgorithm_TenthSentence_Return34()
        {
            // Arrange
            int result = 0;

            // Act
            int[]? fibonacci = Fibonacci.Fibonacci.CalculateFibonacciAlgorithm(10);
            result = fibonacci[fibonacci.Length - 1];

            // Assert
            Assert.AreEqual(34, result);
        }
    }
}
