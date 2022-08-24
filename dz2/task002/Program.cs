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

            
            Console.WriteLine(number > 99 ? number.ToString()[2] : "No third digit");
            Console.ReadKey(true);
        }
    }
}