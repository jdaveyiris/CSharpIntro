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
                int calculationMode = AskForCalculatorMode();

                if (calculationMode == NumberCalculator)
                {
                    PerformOneCalculation();
                } else if (calculationMode == DateCalculator)
                {
                    PerformOneDateCalculation();
                } else
                {
                    Console.WriteLine("I need to add something to make you press 1 or 2.");
                    Console.ReadLine();
                }
            }
        }

        private static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the calculator, please press any key to continue...");
            Console.ReadLine();
        }

        private const int NumberCalculator = 1;
        private const int DateCalculator = 2;

        private static int AskForCalculatorMode()
        {
            Console.WriteLine("Which calculator mode would you like?\n1) Numbers \n2) Dates ");
            return int.Parse(Console.ReadLine());
            
        }

        private static void PerformOneCalculation()
        {
            var operation = GetOperator();
            var numTot = GetHowMany(operation);
            DoCalculation(operation, numTot);
        }

        private static void PerformOneDateCalculation()
        {
            AddDaysOnToDate();
        }

        private static string GetOperator()
        {
            Console.WriteLine("Please enter an operator from the following: +, -, * or /: ");
            string operation = Console.ReadLine();
            return operation;
        }

        private static int GetHowMany(string operation)
        {
            
            //Third attempt. It now loops the How many numbers but I am stuck on returning numTot. 
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
            //why can't I get numTot to return from this line (scope of the method). It only seems to exist in the while {}
            //and I'm not aware of a method of moving it out to the GetHowMany() . . . numTot = 0 to initiate the variable!!!

            /*
            // Second attempt at getting TryParse to work with some string added (Exercise 7.2)
            int numTot;
            bool successfulParse = int.TryParse(Console.ReadLine(), out numTot);
            if (successfulParse)
            {
                Console.WriteLine("Great");
                Console.ReadLine();
                return numTot;
            } else
            {
                Console.WriteLine("That will not work sadly.");
                Console.ReadLine();
                return // need a method to return to line 94?
            }
            
            // First attempt at getting TryParse working myself. 
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
            */
            //Console.Write($"How many numbers do you wish to {operation} ? ");
            //int numTot = int.Parse(Console.ReadLine());
            //return numTot;
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

        private static void AddDaysOnToDate()
        {
            Console.WriteLine("What date would you like to add days to? (##/##/####)");
            DateTime givenDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("How many days would you like to add on?");
            int daysAdding = int.Parse(Console.ReadLine());
            DateTime resultingDate = givenDate.AddDays(daysAdding);
            Console.WriteLine("The intial date was {0} and with {1} added on the new date is {2}.",
                givenDate.ToShortDateString(), 
                daysAdding,
                resultingDate.ToShortDateString());
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