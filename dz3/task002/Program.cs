using System;

namespace task001
{
    class Program
    {
        static void Main()
        {
            Console.Clear();

            System.Console.WriteLine("Input A(x, y, z)");
            System.Console.Write("x: ");
            int x1 = int.Parse(Console.ReadLine()!);
            System.Console.Write("y: ");
            int y1 = int.Parse(Console.ReadLine()!);
            System.Console.Write("z: ");
            int z1 = int.Parse(Console.ReadLine()!);
            System.Console.WriteLine("Input B(x, y, z)");
            System.Console.Write("x: ");
            int x2 = Convert.ToInt16(Console.ReadLine());
            System.Console.Write("y: ");
            int y2 = Convert.ToInt16(Console.ReadLine());
            System.Console.Write("z: ");
            int z2 = int.Parse(Console.ReadLine()!);

           
            System.Console.WriteLine(Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2)+ Math.Pow(z2-z1, 2)));
        }
    }
}