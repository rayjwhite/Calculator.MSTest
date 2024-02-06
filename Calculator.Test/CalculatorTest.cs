namespace Calculator.Test
{
    /// <summary>
    /// This class is to test the calculator service with a contract having four methods of calculation.
    /// </summary>
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Test_Add()
        {
            // Arrange
            int expected = 10;
            int factor1 = 5;
            int factor2 = 5;

            // Act
            double actual = Library.Services.Calculator.Add(factor1, factor2);

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Test_Divide()
        {
            // Arrange
            int expected = 5;
            int factor1 = 20;
            int factor2 = 4;

            // Act
            double actual = Library.Services.Calculator.Divide(factor1, factor2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Multiply()
        {
            // Arrange
            int expected = 20;
            int factor1 = 5;
            int factor2 = 4;

            // Act
            double actual = Library.Services.Calculator.Multiply(factor1, factor2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Subtract()
        {
            // Arrange
            int expected = 1;
            int factor1 = 5;
            int factor2 = 4;

            // Act
            double actual = Library.Services.Calculator.Subtract(factor1, factor2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
