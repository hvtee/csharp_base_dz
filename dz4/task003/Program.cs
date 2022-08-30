using System;

namespace task003
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
                    arr[i] = new Random().Next(-100, 101);
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

            System.Console.Write("The array is: ");
            FillArray(array);
            PrintArray(array);
        }
    }
}