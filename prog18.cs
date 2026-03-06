using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog18
{
    internal class Program
    {
        static void Main()
        {
            int[] arr = new int[10];
            Console.WriteLine("enter 5 numbers:");
            for (int i = 0; i < 5; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int max = arr[0];
            for (int i = 1; i < 5; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("Maximum nmber=" + max);
        
        }
    }
}
