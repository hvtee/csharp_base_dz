using System;

namespace task004
{
    class Program
    {
        static void Main()
        {
            Console.Clear();            //TEST TASK

            int[] between(int a, int b)   //METHOD TO CREATE AN ARRAY [a, b] 
            {
                int[] vector = new int[b - a + 1];  //IMPORTANT FOR METHODS, TYPE "int[], double[] e.t.c" EXISTS!!!!!!!!!!!!
                for (int i = 0; i < vector.Length; i++)
                {
                    vector[i] = a;
                    a++;
                }
                return vector;
            }

            System.Console.WriteLine("Input two numbers: ");
            System.Console.WriteLine("Number 1: ");
            int number1 = int.Parse(Console.ReadLine()!);
            System.Console.WriteLine("Number 2: ");
            int number2 = int.Parse(Console.ReadLine()!);

            if (number1 > number2)
            {
                int temporary = number2;
                number2 = number1;
                number1 = temporary;
            }

            int[] array = between(number1, number2);
            
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}