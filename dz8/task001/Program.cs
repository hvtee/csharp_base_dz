using MyLib;

namespace task001
{
    class Program
    {
        static void OrderArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1) - 1; j++)
                {
                    for (int k = j + 1; k < arr.GetLength(1); k++)
                    {
                        if (arr[i, j] < arr[i, k]) (arr[i, j], arr[i, k]) = (arr[i, k], arr[i, j]);
                    }
                }
            }
        }
        static void Main()
        {
            Console.Clear();

            ArrayActions arrayActions = new ArrayActions();

            (int, int) size2D = (4, 5);
            int[,] array = arrayActions.CreateArray2D(size2D);
            arrayActions.PrintArray2D(array);

            OrderArray(array);
            arrayActions.PrintArray2D(array);
        }
    }
}