using System;

namespace Calculator
{
    public class NumberCalculator
    {
        public void PerformOneCalculation()
        {
            var operation = GetOperator();
            var numTot = GetHowMany(operation);
            DoCalculation(operation, numTot);
        }

        private string GetOperator()
        {
            Console.WriteLine("Please enter an operator from the following: +, -, * or /: ");
            string operation = Console.ReadLine();
            return operation;
        }

        private int GetHowMany(string operation)
        {
            bool getNumber = true;
            int numTot = 0;
            while (getNumber)

            {
                Console.Write($"How many numbers do you wish to {operation} ? ");

                bool successfulParse = int.TryParse(Console.ReadLine(), out numTot);
                if (successfulParse)
                {
                    Console.WriteLine($"Great you entered {numTot}");
                    Console.ReadLine();
                    getNumber = false;
                }
                else
                {
                    Console.WriteLine("That will not work sadly.");
                    Console.ReadLine();
                    getNumber = true;
                }
            }
            return numTot;
        }
        private void DoCalculation(string operation, int numTot)
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
