using System;

namespace task001
{
    class Program
    {
        static void Main()
        {
            Console.Clear();

            int ToPower(int numb, int pow)
            {
                int res = numb;
                for (int i = 1; i < pow; i++)
                {
                    res *= numb;
                }
                return res;
            }

            System.Console.WriteLine("Input number and power.");
            System.Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine()!);
            System.Console.Write("Power: ");
            int power = int.Parse(Console.ReadLine()!);

            System.Console.WriteLine($"Number {number} power {power} is: " + ToPower(number, power));
        }
    }
}