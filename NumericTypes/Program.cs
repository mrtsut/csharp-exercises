using System;

namespace NumericTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            double NumLength;
            double NumWidth;

            Console.WriteLine("What is the Length?");
            string Length = Console.ReadLine();
            NumLength = double.Parse(Length);

            Console.WriteLine("What is the Width?");
            string Width = Console.ReadLine();
            NumWidth = double.Parse(Width);

            
            Console.WriteLine("The area of the rectangle is: "+ (NumLength + NumWidth));
            Console.ReadLine();
        }
    }
}
