using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("enter the number");
            int n=int.Parse(Console.ReadLine());
            int fact = 1;
            for (int i = n;i>=1;i--)
            {
                fact=fact*i;
            }
            Console.WriteLine("factorial=" + fact);
            
        }
    }
}
