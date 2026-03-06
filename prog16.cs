using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog16
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("enter a number");
            int num=int.Parse(Console.ReadLine());
            int original=num;
            int sum = 0;
            int digits=num.ToString().Length;
            while (num > 0)
            {
                int digit = num % 10;
                sum += (int)Math.Pow(digit, digits);
                num = num / 10;
            }
            if (sum == original)
                Console.WriteLine("It is an Armstrong number");
            else
                Console.WriteLine("It is not an Armstrong number");
            Console.ReadLine();
        }
    }
}
