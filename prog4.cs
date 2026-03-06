using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog4
{
    internal class Program
    {
        static void Main()
        {
            float p, r, t, a, ci;

            Console.WriteLine("enter principal amount:");
            p = float.Parse(Console.ReadLine());

            Console.WriteLine("enter rate:");
            r = float.Parse(Console.ReadLine());

            Console.WriteLine("enter time");
            t = float.Parse(Console.ReadLine());

            a = 1 + r / 100;
            ci = a * p;
            Console.WriteLine("compound interest" + ci);


        }
    }
}
