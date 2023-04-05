using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lang54cConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter radius: ");
            double radius = double.Parse(Console.ReadLine());
            double pi = 3.14159;
            double area = pi * radius * radius;
            double circ = 2 * pi * radius;

            Console.WriteLine("Radius: " + Math.Round(radius, 3));
            Console.WriteLine("Area: " + Math.Round(area, 3));
            Console.WriteLine("Circumference: " + Math.Round(circ, 3));
            Console.ReadKey();

        }
    }
}
