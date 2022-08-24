using System;

namespace task001
{
    class Program
    {
        static void Main()
        {
            Console.Clear();

            System.Console.WriteLine("Input day number.");
            System.Console.Write("Number: ");
            int dayNumber = Convert.ToInt32(Console.ReadLine()!);

            //System.Console.WriteLine(dayNumber==6||dayNumber==7? "Its day off":"Its NOT day off");

            if (dayNumber == 6 || dayNumber == 7)
            {
                System.Console.WriteLine("Its day off");
            }
            else if (dayNumber > 0 && dayNumber < 6)
            {
                System.Console.WriteLine("Its NOT day off");
            }
            else
            {
                System.Console.WriteLine("Wrong day number.");
            }
        }
    }
}