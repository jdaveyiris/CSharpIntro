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
            

            Console.WriteLine("What is your name?");
            Console.Write("Type your first name:");
            string myFirstName;
            myFirstName = Console.ReadLine();

            //string myLastName;
            Console.Write("Type your last name:");
            string myLastName = Console.ReadLine();

            Console.WriteLine("Hello, " + myFirstName + " " + myLastName);
            Console.ReadLine();
             */

            Console.Write("What is the circles radius? ");
            string inputRadius = Console.ReadLine();


            double radius = Double.Parse(inputRadius);
            double areaCircle = Math.PI * (radius * radius);
            Console.WriteLine(areaCircle);
            Console.ReadLine();

        }
    }
}
