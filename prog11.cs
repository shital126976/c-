using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog11
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("enter starting number");
            int start=int.Parse(Console.ReadLine());
            Console.WriteLine("enter ending number");
            int end=int.Parse(Console.ReadLine());
            Console.WriteLine("Prime numbers between" + start + "and" + end + "are");
            for (int n = start; n <= end;n++)
            {
                if (n <= 1)
                    continue;
                int flag = 0;
                for(int i = 2; i * i <= n; i++)
                {
                    if(n%i == 0)
                    {
                        flag = 1;
                    }
                }
                if (flag == 0)
                    Console.WriteLine(n);
            }
            
               
        }
    }
}
