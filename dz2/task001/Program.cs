using System;

namespace task001
{
    class Program
    {
        static void Main()
        {
            Console.Clear();

            System.Console.WriteLine("Input 3 digits number.");
            System.Console.Write("Number: ");
            int number = Convert.ToInt32(Console.ReadLine()!);

            System.Console.WriteLine("Second digit is: " + Math.Abs((number % 100 - number % 10) / 10));
        }
    }
}