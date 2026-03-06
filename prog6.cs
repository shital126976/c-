using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odd_even
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("enter a number:");
            int a=int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("number is even");
            }
            else
            {
                Console.WriteLine("number is odd");
            }
        }
    }
}
