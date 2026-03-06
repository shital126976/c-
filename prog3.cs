using System;


namespace prog_3
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("enter value of amount");
            double value=double.Parse(Console.ReadLine());
            Console.WriteLine("enter value of rate");
            double rate=double.Parse(Console.ReadLine());
            Console.WriteLine("enter the years");
            double years =double.Parse(Console.ReadLine());
            double si = (value * rate * years) / 100;
            Console.WriteLine("simple interest" + si);
            
        }
    }
}
