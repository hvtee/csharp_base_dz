using System;

namespace task003
{
    class Program
    {
        static void Main()
        {
            Console.Clear();

            System.Console.WriteLine("Input Number");
            int number = int.Parse(Console.ReadLine()!);
            int stepNumber = 1;

            for (int i = 1; i <= number; i++)
            {
                System.Console.WriteLine($"Cube of {i} is: " + i * i * i);
            }
        }
    }
}