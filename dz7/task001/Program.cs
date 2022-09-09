using System;

namespace task001
{
    class Program
    {
        static void Main()
        {
            Console.Clear();

            double[,] CreateArray2D(int m, int n)
            {
                double[,] arr = new double[m, n];
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        arr[i, j] = new Random().NextDouble();
                    }
                }
                return arr;
            }
            void PrintArray2D(double[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                    Console.WriteLine(" ");
                }
            }

            Console.WriteLine("Input size mxn: ");
            Console.Write("m: ");
            int rows = int.Parse(Console.ReadLine()!);
            Console.Write("n: ");
            int columns = int.Parse(Console.ReadLine()!);
            Console.WriteLine(" ");

            double[,] array = CreateArray2D(rows, columns);
            PrintArray2D(array);

        }
    }
}