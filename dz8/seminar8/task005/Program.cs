using MyLib;

namespace task004
{
    class Program
    {   
        static void PrintPascalTriangle()
        {
            for (int i = 0; i < limit; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    Console.Write(myArray[i][j] + " ");
                }
                Console.WriteLine(" ");
            }
        }
        static void PascalTriangle(int limit)
        {
            int[][] myArray = new int[limit][];
            for (int i = 0; i < myArray.Length; i++)
                myArray[i] = new int[i + 1];

            for (int i = 0; i < limit; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    myArray[i][0] = 1;
                    myArray[i][myArray[i].Length - 1] = 1;
                }
                Console.WriteLine(" ");
            }
            for (int i = 2; i < limit; i++)
            {
                for (int j = 1; j < myArray[i].Length - 1; j++)
                {
                    myArray[i][j] = myArray[i - 1][j - 1] + myArray[i - 1][j];
                }
            }
            PrintPascalTriangle();
        }
        static void Main()
        {
            Console.Clear();

            Console.WriteLine("Input how many rows do you want: ");
            int limit=int.Parse(Console.ReadLine()!);

           PascalTriangle(limit);
        }
    }
}