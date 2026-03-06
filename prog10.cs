using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog10
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("enter no");
            int n=int.Parse(Console.ReadLine());
            int i, m;
            int flag = 0;
            for(i = 2; i <=n-1;i++)
            {
                m = n % i;
                if(m == 0)
                {
                    Console.WriteLine("not prime no");
                    flag = 1; 
                    break;
                }
            }
            if (flag==0)
            {
                Console.WriteLine("prime no");
            }

        }
    }
}
