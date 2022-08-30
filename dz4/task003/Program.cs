using System;

namespace task003
{
    class Program
    {
        static void Main()
        {
            Console.Clear();

            int[] FillArray(int arrayLength)
            {
                int[] list = new int[arrayLength];
                for (int i = 0; i < arrayLength; i++)
                {
                    list[i] = new Random().Next(-100, 101);
                }
                return list;
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
            int[] array = FillArray(arrayLength);
            System.Console.Write("The array is: ");
            PrintArray(array);
        }
    }
}