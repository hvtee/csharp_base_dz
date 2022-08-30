using System;

namespace task004
{
    class Program
    {
        static void Main()
        {
            Console.Clear();
            void FillArray(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    System.Console.Write("array[" + i + "] is: ");
                    arr[i] = int.Parse(Console.ReadLine()!);
                }

            }
            void PrintArray(int[] arr)
            {
                System.Console.Write("[ ");
                for (int i = 0; i < arr.Length; i++)
                {
                    System.Console.Write(arr[i] + ", ");
                }
                System.Console.Write("]");
            }



            System.Console.Write("Input array length: ");
            int arrayLength = int.Parse(Console.ReadLine()!);
            int[] array = new int[arrayLength];

            FillArray(array);
            System.Console.Write("The array is: ");
            PrintArray(array);
        }
    }
}