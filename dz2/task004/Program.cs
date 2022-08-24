using System;

namespace task001
{
    class Program
    {
        static void Main()
        {
            Console.Clear();

            System.Console.WriteLine("Input three 3 digits number.");
            System.Console.Write("Number1: ");
            int number1 = Convert.ToInt32(Console.ReadLine()!);
            System.Console.Write("Number2: ");
            int number2 = Convert.ToInt32(Console.ReadLine()!);
            System.Console.Write("Number3: ");
            int number3 = Convert.ToInt32(Console.ReadLine()!);

            int res = ((number1 + number2 + number3) / 3) % 10;
            int min = (Math.Min(Math.Min(number1, number2), number3) - Math.Min(Math.Min(number1, number2), number3) % 100) / 100;
            
            if (res > min)
            {
                System.Console.WriteLine("Yes");
            }
            else if (res < min)
            {
                System.Console.WriteLine("No");
            }
            else
            {
                System.Console.WriteLine("Equal");
            }
        }
    }
}