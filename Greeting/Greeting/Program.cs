using System;

namespace Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");
            string aFriend = Console.ReadLine();
            Console.WriteLine($"Hello, {aFriend} Nice to meet you ");
        }
    }
}
