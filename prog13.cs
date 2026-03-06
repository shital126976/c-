using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog13
{
    internal class Program
    {
        static void Main()
        {
            int a, b, c, min;
            Console.WriteLine("enter three numbers:");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            min = (a<b) ? ((a<c)?a:c):((b<c)?b:c);
            Console.WriteLine("minimum number="+min);
        }
    }
}
