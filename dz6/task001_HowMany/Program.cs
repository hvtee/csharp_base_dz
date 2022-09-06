using System;

namespace task001
{
    class Program
    {
        static void Main()
        {
            void PrintArray(int[] arr)
            {
                foreach (var elem in arr)
                {
                    Console.Write(elem + " ");
                }
                Console.WriteLine(" ");
            }
            int[] CreateArray(int quantity)
            {
                int[] array = new int[quantity];              
                for (int i = 0; i < quantity; i++)
                {
                    Console.Write($"arr[{i}] is: ");
                    array[i] = int.Parse(Console.ReadLine()!);
                }
                return array;
            }
            int FindPositiveInArray(int[] arr)
            {
                int res = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > 0) res += 1;    
                }
                return res;
            }
            /*int[] CreatePositiveArray(int[] arr)
            {
                int[] arrayPositive = new int[FindPositiveInArray(arr)];
                for (int i = 0, j = 0; i < arr.Length; i++)
                {
                    if (arr[i]>0)
                    {
                        arrayPositive[j]=arr[i];
                        j++;
                    }
                }
                return arrayPositive;
            }*/

            Console.Clear();

            Console.WriteLine("How many nums do you want to input: ");
            int numQuantity = int.Parse(Console.ReadLine()!);

            int[] array = CreateArray(numQuantity);
            PrintArray(array);

            Console.WriteLine("Number of pos in array is: " + FindPositiveInArray(array));

            /*int[] arrPositive=CreatePositiveArray(array);
            PrintArray(arrPositive);*/

        }
    }
}