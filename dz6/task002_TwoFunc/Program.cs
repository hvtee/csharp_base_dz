using System;

namespace task002
{
    class Program
    {
        static void Main()
        {

            double FindX(double k1, double b1, double k2, double b2) => -(b1 - b2) / (k1 - k2); //ONLY X

            double FindY(double k1, double b1, double k2, double b2) => (b1 * -k2 / k1 + b2) / (-k2 / k1 + 1); // ONLY Y
            
            string FindPoint(double k1, double b1, double k2, double b2)
            {
                string result="(";
                result += Convert.ToString(-(b1 - b2) / (k1 - k2));
                result += ", ";
                result += Convert.ToString(k1 * (-(b1 - b2) / (k1 - k2)) + b1);
                result += ")";
                return result;
            } // BOTH X ADND Y 

            Console.Clear();

            Console.WriteLine("y = k1 * x + b1 and y = k2 * x + b2");
            Console.WriteLine("Input k1, b1, k2, b2");
            Console.Write("k1: ");
            double k1= double.Parse(Console.ReadLine()!);
            Console.Write("b1: ");
            double b1 = double.Parse(Console.ReadLine()!);
            Console.Write("k2: ");
            double k2 = double.Parse(Console.ReadLine()!);
            Console.Write("b2: ");
            double b2 = double.Parse(Console.ReadLine()!);

            Console.WriteLine($"y = {k1} * x + {b1} ");
            Console.WriteLine($"y = {k2} * x + {b2}");

            Console.WriteLine($"Solution is: ({FindX(k1, b1, k2, b2)}, {FindY(k1, b1, k2, b2)})");
            Console.WriteLine("Solution is: " + FindPoint(k1, b1, k2, b2));


        }
    }
}