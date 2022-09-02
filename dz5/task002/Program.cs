/*
 * Задача 36: Задайте одномерный массив, 
заполненный случайными числами. 
Найдите сумму элементов, стоящих на 
нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6]-> 0
*/


using System;

namespace task002
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
                    array[i] = new Random().Next(-100, 100 + 1);
                }
                return array;
            }
            int FindSumOddPosInArray(int[] arr)
            {
                int sum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += i % 2 == 1 ? arr[i] : 0;
                }
                return sum;
            }

            int sizeArray = new Random().Next(10, 50 + 1);
            int[] array = FillArray(sizeArray);
            PrintArray(array);
            Console.WriteLine("The sum of numbers on odd positions: " + FindSumOddPosInArray(array));
        }
    }
}