using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog15
{
    internal class Program
    {
        static void Main()
        {
            string str, reverse = "";
            Console.WriteLine("enter a string:");
            str = Console.ReadLine();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverse += str[i];
            }
            if (str == reverse)
            {
                Console.WriteLine("it is palindrome");
            }
            else
                Console.WriteLine("it is not palindrome");
            
        }
    }
}
