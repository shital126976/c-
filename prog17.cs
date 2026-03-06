using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog17
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("input:");
            int num=int.Parse(Console.ReadLine());
            int original = num;
            int sum = 0;
            int digits=num.ToString().Length;
            while (num > 0)
            {
                int digit = num % 10;
                sum += (int)Math.Pow(digit, digits);
                num /= 10;
            }
            if (sum == original) 
                Console.WriteLine("it is Armstrong");
            else
            
                    Console.WriteLine("it is not Armstrong");
        }
    }
}
