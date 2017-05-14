using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Caclulator;


namespace CalculatorUI
{
    class CalculatorUI
    {
        static void Main(string[] args)
        {
            Calculator objCalculator = new Calculator();
            Console.WriteLine("Square of 8=  " + objCalculator.Square(8).ToString());
            Console.WriteLine("Add =  " + objCalculator.Add(8.3, 9.24).ToString());
            Console.WriteLine("Multiply =  " +  objCalculator.Multiply(5, 8).ToString());
            Console.WriteLine("Subtract =  " + objCalculator.Subtract(22, 42).ToString());
            Console.Read();
        }
    }
}
