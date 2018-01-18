using System;

namespace NumericTypesMileage
{
    class Program
    {
        static void Main(string[] args)
        {
            double Miles;
            double Gas;

            Console.WriteLine("How much gas was used");
            string GasUsed = Console.ReadLine();
            Gas = double.Parse(GasUsed);

            Console.WriteLine("How many miles driven?");
            string MilesDriven = Console.ReadLine();
            Miles = double.Parse(MilesDriven);


            Console.WriteLine("Your milage is: " + (Miles / Gas) + " Miles per gallon");
            Console.ReadLine();
        }
    }
}
