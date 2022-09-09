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
            (int, bool) FindElemIn2DArray(int[,] arr, (int rows, int columns) coordinates)
            {
                (int number, bool found) res = (0, false);
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (i == coordinates.rows && j == coordinates.columns)
                        {
                            res.number = arr[i, j];
                            res.found = true;
                        }
                    }
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

            (int rows, int columns) coord;
            Console.WriteLine("Input what elem do you want to find.");        
            Console.Write("Row: ");
            coord.rows = int.Parse(Console.ReadLine()!);
            Console.Write("Column: ");
            coord.columns = int.Parse(Console.ReadLine()!);
            Console.WriteLine(" ");

            (int number, bool found) elem = FindElemIn2DArray(array, coord);
            if (elem.found) Console.WriteLine("Your number is: " + elem.number);           
            else Console.WriteLine("No such number.");
        }
    }
}