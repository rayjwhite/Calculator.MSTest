using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Library.Services.Contracts
{
    /// <summary>
    /// You must have at least C# version 8 to use this syntax to implement a static interface.
    /// </summary>
    public interface ICalculator
    {
        static int Add(int factor1, int factor2) => throw new NotImplementedException();
        static int Divide(int factor1, int factor2) => throw new NotImplementedException();
        static int Multiply(int factor1, int factor2) => throw new NotImplementedException();
        static int Subtract(int factor1, int factor2) => throw new NotImplementedException();
    }
}
