using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lang52aConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length: ");
            int length = int.Parse(Console.ReadLine());
            Console.Write("Enter width: ");
            int width = int.Parse(Console.ReadLine());
            int area = length * width;
            int perim = 2 * (length + width);
            Console.WriteLine("Area: " + area);
            Console.WriteLine("PerimeterP: " + perim);
            Console.ReadKey();

        }
    }
}
