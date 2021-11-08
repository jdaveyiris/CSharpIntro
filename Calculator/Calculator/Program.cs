using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your first number? ");
            double firstNumber = Double.Parse(Console.ReadLine());

            Console.Write("What is your first number? ");
            double secondNumber = Double.Parse(Console.ReadLine());

            Console.WriteLine("Together they multiply to make: " + (firstNumber * secondNumber));
            Console.ReadLine();
        }
    }
}
