using MyLib;

namespace task002
{
    class Program
    {
        static void FindColumnMinValue(int[,] arr)
        {
            int rowNumber = 0;
            int sum1, sum2;
            for (int i = 0; i < arr.GetLength(0) - 1; i++)
            {
                sum1 = 0; sum2 = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum1+=arr[i,j];
                    sum2 += arr[i + 1, j];
                }
                if (sum2 < sum1)
                    rowNumber++;
            }
            Console.WriteLine("The biggest column is: " + (rowNumber + 1));
        }
        static void Main()
        {
            Console.Clear();

            ArrayActions arrayActrions = new ArrayActions();

            var size2D = (4, 5);

            int[,] array = arrayActrions.CreateArray2D(size2D);
            arrayActrions.PrintArray2D(array);

            FindColumnMinValue(array);
        }
    }
}