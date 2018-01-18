using System;

namespace Area_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the Radius of the Circle");
            String radius = Console.ReadLine();
            double radiusNum = double.Parse(radius);
            double area = ((radiusNum * radiusNum) * Math.PI);

            //Console.WriteLine("The Area of the circle is: " + area);
            Console.WriteLine(String.Format("For the radius of {0} ,The Area of the circle is: {1} ", radius, area));

            Console.ReadLine();


        }
    }
}
