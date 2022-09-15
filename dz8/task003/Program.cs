using MyLib;

namespace task003
{
    class Program
    {
        /// <summary>
        /// Multiple all allowed matrixes, if cannot writes it
        /// </summary>
        /// <param name="matrixA">First matrix A</param>
        /// <param name="matrixB">Second matrix B</param>
        /// <returns>Returns new matrix C</returns>
        static int[,] MatrixMultiple(int[,] matrixA, int[,] matrixB)
        {
            int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
            int sum;
            for (int i = 0; i < matrixA.GetLength(0); i++)
            {              
                for (int j = 0; j < matrixB.GetLength(1); j++)
                {
                    sum = 0;
                    for (int k = 0;k<matrixB.GetLength(0)&&k<matrixA.GetLength(1); k++)
                    {
                       sum += matrixA[i, k] * matrixB[k, j];
                    }
                    matrixC[i, j] += sum;
                }
            }
            return matrixC;
        }
        static void Main()
        {
            Console.Clear();

            ArrayActions arrayActions = new ArrayActions();

            (int, int) size2D = (1, 2);

            int[,] matrixA = arrayActions.CreateArray2D(size2D);
            arrayActions.PrintArray2D(matrixA);

            size2D = (2, 3);

            int[,] matrixB = arrayActions.CreateArray2D(size2D);
            arrayActions.PrintArray2D(matrixB);

            if (matrixA.GetLength(1) == matrixB.GetLength(0)) 
            {
                int[,] matrixC = MatrixMultiple(matrixA, matrixB);
                arrayActions.PrintArray2D(matrixC);
            }
            else Console.WriteLine("Impossible to mupltiple matrixes.");
        }
    }
}