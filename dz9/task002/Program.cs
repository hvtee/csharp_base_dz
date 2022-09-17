namespace task002
{
    class Program
    {
        static int SumDigits(ref int sum, int number, int lim)
        {
            if (number != lim)
            {
                if (number > 0) sum += number;
                SumDigits(ref sum, number + 1, lim);
                
            }
            return sum+lim;
        }
        static void Main()
        {
            Console.Clear();

            int num = -3;
            int lim = 7;
            int sum = 0;
            sum = SumDigits(ref sum, num, lim);
            Console.WriteLine(sum);
        }
    }
}