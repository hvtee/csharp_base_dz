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
            System.Console.Write("Number 2: ");
            int numberB = int.Parse((Console.ReadLine()!));
            System.Console.Write("Number 3: ");
            int numberC = int.Parse((Console.ReadLine()!));

            int max = numberA;

            if (numberB > max)
            {
                max = numberB;
            }
            if (numberC > max)
            {
                max = numberC;
            }

            System.Console.WriteLine($"Max is: {max}");
        }
    }
}