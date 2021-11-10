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

            Console.Write($"How many numbers do you wish to {operation} ? ");
            int numTot = int.Parse(Console.ReadLine());
            double[] numbers = new double[numTot];


            for (int i = 1; i <= numTot; i++)
            {
                Console.Write($"Please enter number {i}: ");
                numbers[i-1] = double.Parse(Console.ReadLine());
            }

            double total = numbers[0];

            foreach (double value in numbers)
            {
                if (operation == "+")
                {
                    total = total + value;
                }
                else if (operation == "-")
                {
                    total = total - value;
                }
                else if (operation == "*")
                {
                    total = total * value;
                }
                else
                {                   
                        total = total / value;                               
                }
            }

            Console.WriteLine("The answer is " + total);
            Console.ReadLine();


            /*       
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
            */

        }
    }
}
