using System;

namespace InputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
           var UserName = Console.ReadLine();
            Console.WriteLine("Hello, " + UserName);
            Console.ReadLine();
        }
    }
}
