using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInterview18Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string: ");
            string yippee = Console.ReadLine().ToLower();
            Console.WriteLine("Enter a character to remove: ");
            string character = Console.ReadLine().ToLower(); 

            Console.WriteLine("New string : " + yippee.Replace(character, ""));
            Console.ReadLine();
        }
    }
}
