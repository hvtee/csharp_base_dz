using MyLib;

namespace task004
{
    class Program
    {
        static void DeleteIn2DArray(ref int[,] array, (int rowIndex, int columnIndex) coordIndex)
        {
            if (coordIndex == (-1, -1))
            { 
                Console.WriteLine("There is no such elelment");
                return;
            }
            int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
            for (int i = 0; i < coordIndex.rowIndex; i++)
            {
                for (int j = 0; j < coordIndex.columnIndex; j++)
                {
                    newArray[i, j] = array[i, j];
                }
            }
            for (int i = coordIndex.rowIndex + 1; i < array.GetLength(0); i++) 
            {
                for (int j = coordIndex.columnIndex + 1; j < array.GetLength(1); j++) 
                {
                    newArray[i - 1, j - 1] = array[i, j];
                }
            }
            array = newArray;
        }
        static (int, int) IndexToDelete(int[,] arr,int value)
        {
            (int, int) indexToDelete = (-1, -1);
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (value == arr[i, j]) indexToDelete = (i, j);    
                }
            }
            return indexToDelete;
        }
        static void Main()
        {
            Console.Clear();

            ArrayActions arrayActrions = new ArrayActions();

            (int, int) size2D = (4, 4);

            int[,] array2D = arrayActrions.CreateArray2D(size2D);
            arrayActrions.PrintArray2D(array2D);

            Console.Write("What elem do you want to delete: ");
            int value = int.Parse(Console.ReadLine()!);

            DeleteIn2DArray(ref array2D, IndexToDelete(array2D, value));

            arrayActrions.PrintArray2D(array2D);
        }
    }
}