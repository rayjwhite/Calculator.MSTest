Console.WriteLine("Please enter the mathematical operation that you would like to perform.");
Console.WriteLine("A - Add, D - Divide, M - Multiply, S - Subtract");
string result = Console.ReadLine()?.ToUpper() ?? string.Empty;
if (string.IsNullOrEmpty(result))
    Console.WriteLine("Error understanding mathematical operation to perform.");
else
{
    Console.WriteLine("Enter the first number of the mathematical operation.");
    int factor1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the second number of the mathematical operation.");
    int factor2 = Convert.ToInt32(Console.ReadLine());

    switch (result)
    {
        case "A":
            Console.WriteLine(value: $"{factor1} + {factor2} = {Calculator.Library.Services.Calculator.Add(factor1, factor2)}");
            break;
        case "D":
            Console.WriteLine(value: $"{factor1} / {factor2} = {Calculator.Library.Services.Calculator.Divide(factor1, factor2)}");
            break;
        case "M":
            Console.WriteLine(value: $"{factor1} * {factor2} = {Calculator.Library.Services.Calculator.Multiply(factor1, factor2)}");
            break;
        case "S":
            Console.WriteLine(value: $"{factor1} - {factor2} = {Calculator.Library.Services.Calculator.Subtract(factor1, factor2)}");
            break;

        default:
            break;
    }
}
