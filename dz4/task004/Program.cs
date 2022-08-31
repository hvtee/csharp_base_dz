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
                    arr[i] = new Random().Next(-10, 11);
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
            int FindMaxArray(int[] list)
            {
                int max = list[0];
                for (int i = 0; i < list.Length - 1; i++)
                {
                    if (list[i] > max)
                    {
                        max = list[i];
                    }
                }
                return max;
            }


            int[] array = new int[10];

            FillArray(array);
            System.Console.Write("The array is: ");
            PrintArray(array);
            System.Console.WriteLine(" ");
            System.Console.WriteLine("Max number is: " + FindMaxArray(array));
        }
    }
}