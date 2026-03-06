using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace prog9
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter nuber");
            int n=int.Parse(Console.ReadLine());
            int n1 = 0;
            int n2 = 1;
            int n3; 
            Console.WriteLine( n1+" ");
            Console.WriteLine( n2+" ");
            n3 =n1 + n2;
            while (n3 <= n)
            {
                Console.WriteLine(n3 + " ");
                n1 = n2;
                n2 = n3;
                n3 = n1 + n2;
            }
        }
    }
}
