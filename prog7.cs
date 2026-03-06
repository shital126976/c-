using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro7
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("enter your age:");
            int age=int.Parse(Console.ReadLine());
            if (age < 12)
            {
                Console.WriteLine("kid");
            }
            else if (age>=12 && age<=17)
            {
                Console.WriteLine("teenager");
            }
            else if (age >= 18 && age <= 60)
            {
                Console.WriteLine("adult");
            }
            else
            {
                Console.WriteLine("senior");
            }
        }
    }
}
