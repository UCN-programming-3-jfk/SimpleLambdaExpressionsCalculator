using System;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();
            float sum = calc.Add(3, 4);
            float remainder = calc.Subtract(4, 3);
            float product = calc.Multiply(6, 9);
            float fraction = calc.Divide(42, 7);
        }
    }
}
