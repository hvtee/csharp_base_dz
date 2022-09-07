using System;

namespace task002
{
    class Program
    {
        static void Main()
        {
            int[] CreateArray(int ArraySize)
            {
                int[] arr = new int[ArraySize];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = new Random().Next(-50, 50);
                }
                return arr;
            }
            void PrintArray(int[] arr)
            {
                foreach (var element in arr) Console.Write(element + " ");
                Console.WriteLine(" ");
            }
            int[] MoveNumberInArray(int[] arr, string moveTo)
            {
                int stepNum;
                if (moveTo == "right")
                {
                    for (int i = arr.Length - 1; i > 0; i--)
                    {
                        stepNum = arr[i - 1];
                        arr[i - 1] = arr[i];
                        arr[i] = stepNum;
                    }
                }
                else
                {
                    for (int i = 0; i < arr.Length - 1; i++)
                    {
                        stepNum = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = stepNum;
                    }
                    
                }
                return arr;
            }

            Console.Clear();

            int size;
            do 
            {
                Console.Write("Input array size: ");
                size = int.Parse(Console.ReadLine()!);
            } while (size < 0); // INPUT SIZE

            string moveNumberTo;
            do
            {
                Console.WriteLine("Move array: left or right?");
                moveNumberTo = Console.ReadLine()!.ToLower();
            } while (moveNumberTo != "right" && moveNumberTo != "left"); // INPUT DIRECTION

            Console.WriteLine(" ");
            int[] array = CreateArray(size);
            PrintArray(array);
           
            array = MoveNumberInArray(array, moveNumberTo);
            PrintArray(array);
        }
    }
}