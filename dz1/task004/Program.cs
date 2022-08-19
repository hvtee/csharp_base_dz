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

            int stepNumber = 1;

            while (stepNumber <= number)
            {
                if (stepNumber % 2 != 1)
            {
                System.Console.Write(stepNumber + " ");
            }
            stepNumber++;
            }
            
        }
    }
}