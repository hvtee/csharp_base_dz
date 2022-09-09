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
            string FindColumnIn2DArray(int[,] arr)
            {
                string res = "No.";
                int sum;
                int cornerSum = CornerSum(arr);
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    sum = 0;
                    for (int i = 0; i < arr.GetLength(1); i++) sum += arr[i, j];
                    if (sum > cornerSum)
                    {
                        return res = "Yes";
                        break;
                    }
                }
                return res;
            }
            int CornerSum(int[,] arr)
            {
                int sum;
                sum = arr[0, 0] + arr[0, arr.GetLength(0) - 1] + arr[arr.GetLength(1) - 1, 0] + arr[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
                return sum;
            }

            Console.WriteLine("Input size mxn: ");
            Console.Write("m: ");
            int rows = int.Parse(Console.ReadLine()!);
            Console.Write("n: ");
            int columns = int.Parse(Console.ReadLine()!);
            Console.WriteLine(" ");

            int[,] array = CreateArray2D(rows, columns);
            PrintArray2D(array);

            Console.WriteLine(FindColumnIn2DArray(array));
        }
    }
}