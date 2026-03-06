using System;


namespace unit1
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("enter value of a ");
            int a=int.Parse(Console.ReadLine());
            Console.Write("enter value of b");
            int b=Convert.ToInt32(Console.ReadLine());
            int c = a + b;
            int x = a - b;
            int y = a / b;
            int z = a % b;
            int t = a * b;
            Console.WriteLine("addition" + c);
            Console.WriteLine("subtraction" + x);
            Console.WriteLine("division" + y);
            Console.WriteLine("modulas" + z);
            Console.WriteLine("multiplication" + t);
        }
    }
}
