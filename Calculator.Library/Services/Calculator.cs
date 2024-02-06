using Calculator.Library.Services.Contracts;

namespace Calculator.Library.Services
{
    public class Calculator : ICalculator
    {
        public static int Add(int factor1, int factor2)
        {
            int product = factor1 + factor2;
            return product;
        }

        public static int Divide(int factor1, int factor2)
        {
            int product = factor1 / factor2;
            return product;
        }

        public static int Multiply(int factor1, int factor2)
        {
            int product = factor1 * factor2;
            return product;
        }

        public static int Subtract(int factor1, int factor2)
        {
            int product = factor1 - factor2;
            return product;
        }
    }
}
