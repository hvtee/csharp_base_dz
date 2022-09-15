using MyLib;

namespace task004
{
    class Program
    {
        static void CreateArray(int[,,] arr)
        {
            Random rnd = new Random(DateTime.Now.Year);
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        arr[i, j, k] = rnd.Next(-50, 50);
                    }
                }
            }
        }
        static void PrintArray(int[,,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        Console.Write(arr[i, j, k] + " - " + $"({i}, {j}, {k}) |");
                    }
                    Console.WriteLine(" ");
                }
                Console.WriteLine("---");
            }
        }
        static void Main()
        {
            Console.Clear();

            Random rnd = new Random();
            int[,,] array3D = new int[3, 4, 5];

            CreateArray(array3D);
            PrintArray(array3D);

        }
    }
}