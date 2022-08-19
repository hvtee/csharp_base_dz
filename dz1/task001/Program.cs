using System;

namespace task001
{
    class Program
    {
        static void Main()
        {
            Console.Clear();

            System.Console.WriteLine("Input two numbers.");
            System.Console.Write("Number 1: ");
            int numberA = Convert.ToInt32(Console.ReadLine()!);
            System.Console.Write("Number 1: ");
            int numberB = int.Parse((Console.ReadLine()!));

            System.Console.WriteLine(" ");
            System.Console.WriteLine("Max number: " + Math.Max(numberA, numberB));
            System.Console.WriteLine("Min number: " + Math.Min(numberA, numberB));
        }
    }
}