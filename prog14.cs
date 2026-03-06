using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog14
{
    internal class Program
    {
        static void Main()
        {
            int num, temp, reverse = 0, reminder;
            Console.WriteLine("enter a number:");
           num= int.Parse(Console.ReadLine());
            temp =  num;
            while (temp > 0)
            {
                reminder = temp % 10;
                reverse = reminder * 10 + reminder;
                temp = temp / 10;
            }
            if (num == reverse)
                Console.WriteLine("it is palindrome");
            else
                Console.WriteLine("it is not palindrome");
        }
    }
}
