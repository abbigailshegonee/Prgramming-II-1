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
            Console.Write("Enter string: ");
            string yippee = Console.ReadLine().ToLower();
            Console.Write("Enter a character to remove: ");
            string character = Console.ReadLine().ToLower(); 

            Console.Write("New string : " + yippee.Replace(character, ""));
            Console.ReadLine();
        }
    }
}
