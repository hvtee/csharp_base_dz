using System;

namespace task001
{
    class Program
    {
        static void Main()
        {
            Console.Clear();

            int[,] CreateArray2D(int m, int n)
            {
                int[,] arr = new int[m, n];
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        arr[i, j] = new Random().Next(-20, 20);
                    }
                }
                return arr;
            }
            void PrintArray2D(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                    Console.WriteLine(" ");
                }
                Console.WriteLine(" ");
            }
            double[] AverageInColumnIn2DArray(int[,] arr)
            {
                double[] res = new double[arr.GetLength(1)];
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    for (int i = 0; i < arr.GetLength(1); i++)
                    {
                        res[j] += arr[i, j];
                    }
                    res[j] /= arr.GetLength(0);
                }
                return res;
            }

            Console.WriteLine("Input size mxn: ");
            Console.Write("m: ");
            int rows = int.Parse(Console.ReadLine()!);
            Console.Write("n: ");
            int columns = int.Parse(Console.ReadLine()!);
            Console.WriteLine(" ");

            int[,] array = CreateArray2D(rows, columns);
            PrintArray2D(array);

            double[] resArr = AverageInColumnIn2DArray(array);
            foreach (var item in resArr) Console.Write(item + " ");
        }
    }
}