using System;

namespace task001
{
    class Program
    {
        static void Main()
        {
            Console.Clear();

            System.Console.WriteLine("input 5digit number: ");

            /*string number = Console.ReadLine();
            if (number.Length != 5)
            {
                System.Console.WriteLine("Wrong number");
                return;
            }
            System.Console.WriteLine(number[0] == number[4] && number[1] == number[3] ? "Yes" : "No");*/

            int number = int.Parse(Console.ReadLine()!);

            if (number > 99999 || number < 9999)
            {
                System.Console.WriteLine("Wrong number");
                return;
            }

            bool digits_1_5 = (number - number % 10000) / 10000 == number % 10;
            bool digits_2_4 = (number % 10000 - number % 1000) / 1000 == (number % 100 - number % 10) / 10;

            System.Console.WriteLine(digits_2_4 && digits_1_5 ? "Yes" : "No");
        }
    }
}