using System;

namespace task002
{
    class Program
    {
        static void Main()
        {
            Console.Clear();

            int SumDigits(string num)
            {
                int res = (Convert.ToInt32(num[0]) - '0');
                for (int i = 1; i < num.Length; i++)
                {
                    res += (Convert.ToInt32(num[i]) - '0');
                }
                return res;
            }
            System.Console.Write("Input number: ");
            int number = Math.Abs(int.Parse(Console.ReadLine()!));
            string num = Convert.ToString(number);


            System.Console.WriteLine("The sum of digits is: " + SumDigits(num));

        }
    }
}