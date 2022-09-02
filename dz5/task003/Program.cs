/*
 * Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным 
элементов массива.

[3 7 22 2 78] -> 76
*/

using System;

namespace task003
{
    class Program
    {
        static void Main()
        {
            Console.Clear();

            void PrintArray(double[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine(" ");
            }
            double[] FillArray(int size)
            {
                double[] array = new double[size];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = new Random().NextDouble();
                }
                return array;
            }
            double FindDifferenceMinMaxDouble(double[] arr)
            {
                double diff = 0, max = arr[0], min = arr[0];
                foreach (var elem in arr)
                {
                    max = elem > max ? elem : max;
                    min = elem < min ? elem : min;
                }
                diff = max - min;
                return diff;
            }

            //int sizeArray = new Random().Next(10, 12);
            int sizeArray = 4;
            double[] array = FillArray(sizeArray);
            PrintArray(array);
            Console.WriteLine("Difference between min and max: " + FindDifferenceMinMaxDouble(array));
        }
    }
}