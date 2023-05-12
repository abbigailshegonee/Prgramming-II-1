using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInterview8Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string word = Console.ReadLine().ToLower();
            Console.Write("Enter a character: ");
            string letter = Console.ReadLine().ToLower();

            int CharCount = 0;

            for (int lcv = 0; lcv < word.Length; lcv++) {
                char let = letter[0];
                if (word[lcv] == let) {
                    CharCount++;
                }
            }
            Console.WriteLine("Character '" + letter + "' appears in '" + word + "' " + CharCount + " times");
            Console.ReadLine();

        }
    }
}
