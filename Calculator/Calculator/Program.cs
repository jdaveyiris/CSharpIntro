using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintWelcomeMessage();
            bool carryOn = true;
            while (carryOn)
            {
                PerformOneCalculation();
            }
        }

        private static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the calculator, please press any key to continue...");
            Console.ReadLine();
        }

        private static void PerformOneCalculation()
        {
            var operation = GetOperator();
            var numTot = GetHowMany(operation);
            DoCalculation(operation, numTot);
        }

        private static string GetOperator()
        {
            Console.WriteLine("Please enter an operator from the following: +, -, * or /: ");
            string operation = Console.ReadLine();
            return operation;
        }

        private static int GetHowMany(string operation)
        {

            Console.Write($"How many numbers do you wish to {operation} ? ");
            /*
            int number;
            bool success = int.TryParse(Console.ReadLine(), out number);
            if (success)
            {
                Console.WriteLine($"Converted '{Console.ReadLine()}' to {number}.");
                int numTot = int.Parse(Console.ReadLine());
                return numTot;
            }
            else
            {
                Console.WriteLine($"Attempted conversion of '{Console.ReadLine() ?? "<null>"}' failed.");
                return 1;
            }
            // Could not get TryParse working myself. 
            */
            int numTot = int.Parse(Console.ReadLine());
            return numTot;
        }

        private static void DoCalculation(string operation, int numTot)
        {
            int[] numbers = new int[numTot];
            for (int i = 1; i <= numTot; i++)
            {
                Console.Write($"Please enter number {i}: ");
                numbers[i - 1] = int.Parse(Console.ReadLine());
            }

            double total = numbers[0];

            for (int i = 1; i < numTot; i++)
            {
                if (operation == "+")
                {
                    total = total + numbers[i];
                }
                else if (operation == "-")
                {
                    total = total - numbers[i];
                }
                else if (operation == "*")
                {
                    total = total * numbers[i];
                }
                else
                {
                    total = total / numbers[i];
                }
            }

            Console.WriteLine("The answer is " + total);
            Console.ReadLine();
        }
    }
    
}


/*                        
            //Exercise 4.2:
            double solution = 0;      

            Console.Write("What is your first number? ");
            double firstNumber = Double.Parse(Console.ReadLine());

            Console.Write("What is your second number? ");
            double secondNumber = Double.Parse(Console.ReadLine());

            //int operation = int.Parse(Console.ReadLine()); (Thought this may allow for the input to be used as shown below)
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