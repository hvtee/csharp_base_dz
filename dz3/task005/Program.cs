using System;

namespace task004
{
    class Program
    {
        static void Main()
        {
            Console.Clear();

            System.Console.WriteLine("Input radius: ");
            int radius = int.Parse(Console.ReadLine()!);

            if (radius < 0) //RADIUS > 0
            {
                System.Console.WriteLine("Wrong radius");
                return;
            }

            string square = Convert.ToString(Math.Round(Math.PI * radius * radius)); //TO COUNT AND TO ROUND CIRCLE SQUARE AND CONVERT TO STRING
            char maxDigitString = square[0]; // VARIABLE TO FIND MAX DIGIT

            for (int i = 1; i < square.Length; i++) //TO FIND MAX DIGIT
            {
                if (square[i] > maxDigitString)
                {
                    maxDigitString = square[i];
                }
            }

            System.Console.WriteLine("Max(string) is: " + maxDigitString);

            /*int maxDigitInt = maxDigitString - '0'; //CONVERT TO INT IF NECESSARY
            System.Console.WriteLine(maxDigitInt);*/

        }
    }
}