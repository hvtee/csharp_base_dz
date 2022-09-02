/*
 * Задача 34: Задайте массив заполненный 
случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество 
чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

using System;

namespace task001
{
    class Program
    {
        static void Main()
        {
            Console.Clear();

            void PrintArray(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine(" ");
            }
            int[] FillArray(int size)
            {
                int[] array = new int[size];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = new Random().Next(100, 1000);
                }
                return array;
            }
            int FindEvenQuantity(int[] arr)
            {
                int quantity = 0;
                foreach (var item in arr)
                {
                    quantity += item % 2 == 0 ? 1 : 0;
                }
                return quantity;
            }

            int sizeArray = new Random().Next(10, 30);
            int[] array = FillArray(sizeArray);
            PrintArray(array);
            Console.WriteLine("The quantity of even numbers: " + FindEvenQuantity(array));
        }
    }
}