using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG_19
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = new int[10];
            Console.WriteLine("enter the 5 values:");
            for (int i = 0;i<5;i++)
            { 
                Console.WriteLine("number"+(i+1)+":");
                numbers[i]=int.Parse(Console.ReadLine());
            }
            int min=numbers[0];
            for (int i = 1; i < 5; i++) {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            Console.WriteLine("minimum number is:" + min);
            Console.ReadLine();
        }
    }
}
