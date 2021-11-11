using System;

namespace Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter your name:");
            //string aFriend = Console.ReadLine();
            //Console.WriteLine($"Hello, {aFriend} Nice to meet you ");

            /*
            int x;
            int y;

            x = 7;
            y = x + 3;
            Console.WriteLine(y);
            Console.ReadLine();
            
            ---------
            //Exercise 4.1:
            Console.WriteLine("What is your name?");
            Console.Write("Type your first name:");
            string myFirstName;
            myFirstName = Console.ReadLine();

            //string myLastName;
            Console.Write("Type your last name:");
            string myLastName = Console.ReadLine();

            string message = "";

            if ((myFirstName == "") && (myLastName == ""))
            {
                message = "You really ought to tell me your name you know.";
            }
            else if ((myFirstName == "") || (myLastName == ""))
            {
                message = ("Hello," + myFirstName + myLastName + "! I see you only have one name, but that is fine");
            }
            else
            {
                message = "Hello, " + myFirstName + " " + myLastName;
            }
            Console.WriteLine(message);
            Console.ReadLine();

            ----------
            //Exercise 3.1 & 3.2:
            Console.Write("What is the circles radius? ");
            string inputRadius = Console.ReadLine();


            double radius = Double.Parse(inputRadius);
            double areaCircle = Math.PI * (radius * radius);
            Console.WriteLine(areaCircle);
            Console.ReadLine();
            
            ------------

            Console.WriteLine("Jim's Mad Prizes");
            Console.Write("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();
            string message = "";

            if (userValue == "1")
            {
                message = "You won a fur coat!";
                //Console.WriteLine(message);
            }
            else if ( userValue == "2")
                message = "You won an Xbox!";         
            else if (userValue == "3")
            {
                message = "You won a car!";            
            }
            else
            {
                message = "Sorry that wasn't what you were meant to do! ";
                message += "Womp Womp.";
            }
            Console.WriteLine(message);
            Console.ReadLine();

          

            Console.WriteLine("Jim's Mad Prizes");
            Console.Write("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();

            string message = (userValue == "1") ? "boat" : "strand of lint";

            Console.Write("You won a {0}.", message);
            Console.ReadLine();

            ---------

            for (int i = 0; i < 10; i++)
            {
               if (i == 7)
                {
                    Console.WriteLine("I found seven! But whats in the box?");
                    break;
                }
            }
            Console.ReadLine();
           

            int[] numbers = new int[] { 4, 8, 15, 16, 23, 42 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.ReadLine();
            
            foreach (int x in numbers)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();


            string zig = "Always look on the bright side of life.";

            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach (char zigChar in charArray)
            {
                Console.Write(zigChar);
            }
            Console.ReadLine();
           
            ----------
            
            //Exercise 5.1:

            Console.WriteLine("Please enter the number you wish to add up to: ");
            string inputNum = Console.ReadLine();

            int maxNum = int.Parse(inputNum);
            int total = 0;

            for (int i = 0; i <= maxNum; i++)
            {
                total = total + i;
            }
            Console.WriteLine(total);
            Console.ReadLine();
            
            //Exercise 5.2:

            Console.WriteLine("Please enter the number you wish to multiply up to: ");
            string inputNum = Console.ReadLine();
            int maxNum = int.Parse(inputNum);
            string toDisplay = "";

            for (int secondNumber = 2; secondNumber <= maxNum; secondNumber++)
            {
                for (int firstNumber = 2; firstNumber <= maxNum; firstNumber++)
                {
                    int total = firstNumber * secondNumber;
                    toDisplay = ($"{ firstNumber}  x   { secondNumber}  =  { total} ");
                    Console.WriteLine(toDisplay);
                }
            }
            Console.ReadLine();

            -------------

            Exercise 5.4:
            
            Console.Write("Enter number of words: ");
            string numWords = Console.ReadLine();
            int totWords = int.Parse(numWords);

            string[] words = new string[totWords];
           
            for (int i = 0; i < totWords; i++)
            {
                Console.Write($"Please enter word {i+1} :");
                words[i] = Console.ReadLine();
            }
            Array.Reverse(words);

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();

            //Exercise 5.5: To come back to!

            -------------
                
            
            //Exercise 6.1:

           
            bool displayProg = true;

            while (displayProg)
            {
                displayProg = Prog();
            }

            ----------

            DateTime myValue = DateTime.Now;
            //Console.WriteLine(myValue.ToString());
            //Console.WriteLine(myValue.ToShortDateString());
            //Console.WriteLine(myValue.ToLongDateString());
            //Console.WriteLine(myValue.ToLongTimeString());

            //Console.WriteLine(myValue.AddDays(3).ToLongDateString());
            //Console.WriteLine(myValue.AddHours(-3).ToLongTimeString());

            //DateTime myBirthday = new DateTime(1901, 4, 26);
            //Console.WriteLine(myBirthday.ToShortDateString());

            DateTime myBirthday = DateTime.Parse("26/04/1901");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine(myAge.TotalDays);
            */

            Console.WriteLine("Welcome, what is your name? ");
            string name = Console.ReadLine();

            Console.WriteLine("Thankyou, and what is your birthdate (##/##/####)?");
            DateTime theBirthdate = DateTime.Parse(Console.ReadLine());
            TimeSpan Age = DateTime.Now.Subtract(theBirthdate);

            if ((name.ToUpper() == name && name.Length >= 12) && Age.TotalDays <= 3650)
            {
                Console.WriteLine("Well that is a rather loud and long name!");
                Console.WriteLine($"Welcome {name.ToLower()}, aren't you a bit young to be here?");
                Console.ReadLine();
            } else if ((name.ToUpper() == name && name.Length >= 12) && Age.TotalDays > 3650)
            {
                Console.WriteLine("Well that is a rather loud and long name!");
                Console.WriteLine($"Welcome {name.ToLower()}");
                Console.ReadLine();
            } else if (name.Length >= 12 && Age.TotalDays <= 3650)
            {
                Console.WriteLine("That's a long name you have there.");
                Console.WriteLine($"Welcome {name}, aren't you a bit young to be here?");
                Console.ReadLine();
            }        
               else if (name.Length >= 12 && Age.TotalDays > 3650)
            {
                Console.WriteLine("That's a long name you have there.");
                Console.WriteLine($"Welcome {name}");
                Console.ReadLine();
            } else if (name.ToUpper() == name && Age.TotalDays <= 3650)
            {
                Console.WriteLine("No need to shout!");
                Console.WriteLine($"Welcome {name.ToLower()}, aren't you a bit young to be here?");
                Console.ReadLine();
            }           
               else if (name.ToUpper() == name && Age.TotalDays > 3650)
            {
                Console.WriteLine("No need to shout!");
                Console.WriteLine($"Welcome {name.ToLower()}");
                Console.ReadLine();
            } else
            {
                Console.WriteLine($"Welcome {name}");
                Console.ReadLine();
            }
                   










        }



        /*
        private static bool Prog()
            //not all code paths return a value. Not entirly sure how I would return true or false to Prog()?
            //If I can get past that then I can test the while (complete) section.
        {
            string sentence = "";
            bool complete = true; 

            while (complete)
            {
                Console.WriteLine("Enter a word: ");
                string word = Console.ReadLine();
                if (word != "")
                {
                    sentence = sentence + " " + word;
                    Console.WriteLine("Current sentence: " + sentence);
                    Console.ReadLine();
                    return complete = true;
                }
                else
                {
                    Console.WriteLine("Final sentence: " + sentence);
                    Console.ReadLine();
                    return complete = false;
                }
            } 
        }*/
    }
}
