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
            string number = Console.ReadLine()!;
            //int number = Convert.ToInt32(Console.ReadLine()!);
            //number = Math.Abs(number);

            Console.WriteLine(number.Length > 2 ? number[2] : "No third digit");
            //Console.ReadKey(true);

            /*if (number < 99)
            {
                System.Console.WriteLine("No third digit");
                return;
            }

            while (number > 999)
            {
                number = number / 10;
            }

            System.Console.WriteLine("Third digit is: " + number % 10);*/
        }
    }
}