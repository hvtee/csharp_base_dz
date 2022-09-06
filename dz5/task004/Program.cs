using System;

namespace task003
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
                    array[i] = new Random().Next(-50,50 + 1);
                }
                return array;
            }
            int FindAverage(int[] arr)
            {
                int average = 0;
                average = arr.Sum() / arr.Length;
                return average;
            } //TO FIND AVERAGE
               
            
          

            int sizeArray = new Random().Next(10, 20 + 1);
            int[] array = FillArray(sizeArray);
            PrintArray(array);

            int sizeNewArr = 0;
            foreach (var element in array)
            {
                sizeNewArr += Math.Abs(element) % 2 == 0 ? 1 : 0;
            } // TO FIND SIZE OF NEW EVEN ARRAY

            int[] arrayEven = new int[sizeNewArr];
            for (int i = 0, j = 0; i < array.Length; i++) 
            {
                if (Math.Abs(array[i]) % 2 == 0)
                {
                    arrayEven[j]=array[i];
                    j++;
                }
            } //CREATING EVEN ARRAY
            int[] arrayOdd = new int[array.Length - sizeNewArr];
            for (int i = 0, j = 0; i < array.Length; i++) 
            {
                if (Math.Abs(array[i]) % 2 == 1)
                {
                    arrayOdd[j] = array[i];
                    j++;
                }
            } //CREATING ODD ARRAY

            Console.WriteLine(" ");
            PrintArray(arrayEven);
            PrintArray(arrayOdd);
            Console.WriteLine(" ");

            if (FindAverage(arrayEven) > FindAverage(arrayOdd))
            {
                Console.WriteLine("Array of even > array of odd");
            }
            else if (FindAverage(arrayEven) < FindAverage(arrayOdd))
            {
                Console.WriteLine("Array of even < array of odd");
            }
            else
            {
                Console.WriteLine("Array of even + array of odd");

            }
        }
    }
}
