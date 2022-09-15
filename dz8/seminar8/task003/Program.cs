using MyLib;

namespace task002
{
    class Program
    {
        static void Main()
        {
            int[] Turn2DInto1D(int[,] arr)
            {
                int[] array1D = new int[arr.Length];
                int size1D = 0;
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        array1D[size1D]=arr[i,j];
                        size1D++;
                    }
                }
                return array1D;
            }
            int[] SortArray1D(int[] nums)
            {
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[i] > nums[j]) (nums[i], nums[j]) = (nums[j], nums[i]);  
                    }
                }
                return nums;
            }
            void ReapitsInArray(int[] arr)
            {
                int count = 1;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i == arr.Length - 1)
                    {                          
                        Console.WriteLine($"Quantity of {arr[i]} is: {count}");
                        return;
                    }
                    else if (arr[i] == arr[i + 1]) count++;
                    else
                    {
                        Console.WriteLine($"Quantity of {arr[i]} is: {count}");
                        count = 1;
                    }
                }
            }
            
            Console.Clear();

            ArrayActions arrayActions = new ArrayActions();
            Random random = new Random();

            (int, int) size2D = (10, 10);
            int[,] array = arrayActions.CreateArray2D(size2D);

            arrayActions.PrintArray2D(array);
            Console.WriteLine(" ");

            int[] array1D = Turn2DInto1D(array);
            arrayActions.PrintArray1D(array1D);
            Console.WriteLine(" ");

            arrayActions.PrintArray1D(SortArray1D(array1D));

            ReapitsInArray(array1D);


        }
    }
}

