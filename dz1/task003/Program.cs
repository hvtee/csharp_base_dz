using System;

namespace task001
{
    class Program
    {
        static void Main()
        {
            Console.Clear();

            System.Console.WriteLine("Input number.");
            System.Console.Write("Number: ");
            int number = Convert.ToInt32(Console.ReadLine()!);
            
           if (Math.Abs(number) % 2 != 1)
           {
            System.Console.WriteLine($"Number {number} is even.");
           }
           else
           {
            System.Console.WriteLine($"Number {number} is NOT even.");
           }
        }
    }
}