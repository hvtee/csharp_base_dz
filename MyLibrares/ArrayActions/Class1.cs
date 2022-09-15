namespace MyLib
{

    public class ArrayActions
    {
        public int sizeOfArray1D = 0;
        public (int rows, int columns) sizeOfArray2D = (0, 0);
        public int coordinates1D = 0;
        public (int row, int column) coordinates2D = (0, 0);

        /// <summary>
        /// Creates 1D array
        /// </summary>
        /// <param name="size">Size of array</param>
        /// <returns>Array of random numbers [-50, 50)</returns>
        public int[] CreateArray1D(int size)
        {
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(-50, 50);
            }
            return array;
        }

        /// <summary>
        /// Prints 1D array
        /// </summary>
        /// <param name="arr">Input array that needs to be printed</param>
        public void PrintArray1D(int[] arr)
        {
            foreach (var item in arr) Console.Write(item + " ");
            Console.WriteLine(" ");
        }

        /// <summary>
        /// Creates 2D array
        /// </summary>
        /// <param name="size">(int rows, int columns) Size</param>
        /// <returns>Returns 2D array of int random number [-50, 50)</returns>
        public int[,] CreateArray2D((int rows, int columns) size)
        {
            int[,] arr = new int[size.rows, size.columns];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = new Random().Next(-50, 50);
                }
            }
            return arr;
        }

        /// <summary>
        /// Prints 2D array
        /// </summary>
        /// <param name="array">Array that needs to be printed</param>
        public void PrintArray2D(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine(" ");
        }

        /// <summary>
        /// Find element in int array by index and prints it
        /// </summary>
        /// <param name="arr">In what to search</param>
        /// <param name="coordinate">Index of element that needs to be found</param>
        public void FindElemIn1DArray(int[] arr, int coordinate)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (coordinate == i)
                {
                    Console.WriteLine("The element is: " + arr[i]);
                    return;
                }
            }
            Console.WriteLine("There is no such number.");
        }

        /// <summary>
        /// Find element in array by index and prints it
        /// </summary>
        /// <param name="arr">Array to search</param>
        /// <param name="coordinates">Index of element (int rows, int columns)</param>
        public void FindElemIn2DArray(int[,] arr, (int row, int column) coordinates)
        {

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i == coordinates.row && j == coordinates.column)
                    {
                        Console.WriteLine("The element is: " + arr[i, j]);
                        return;
                    }
                }
            }
            Console.WriteLine("There is no such number.");
        }
    }
}