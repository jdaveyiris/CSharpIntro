using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter an operator from the following: +, -, * or /: ");
            string operation = Console.ReadLine();      
            //int operation = int.Parse(Console.ReadLine()); (Thought this may allow for the input to be used as shown on line 21
            double solution = 0;

            Console.Write("What is your first number? ");
            double firstNumber = Double.Parse(Console.ReadLine());

            Console.Write("What is your first number? ");
            double secondNumber = Double.Parse(Console.ReadLine());

            // Can't simply force the input for operator into a one line solution.
            //sum = (firstNumber)(operation)(secondNumber);

            if (operation == "+")
            {
                solution = firstNumber + secondNumber;
            }
            else if (operation == "-")
            {
                solution = firstNumber - secondNumber;
            }
            else if (operation == "*")
            {
                solution = firstNumber * secondNumber;
            }
            else
            {
                solution = firstNumber / secondNumber;
            }

            Console.WriteLine("The answer is " + solution);
            Console.ReadLine();
        }
    }
}
