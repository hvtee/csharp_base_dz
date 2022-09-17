namespace task001
{
    class Program
    {
            static void ToEnum(int num, int lim)
            {
                if (num != lim)
                {

                    if (num%2==0 )Console.Write(num + " ");
                    ToEnum(num + 1, lim);
                }
            }
            static void Main()
            {
                Console.Clear();

                int start = new Random().Next(-6, 6);
                int end = new Random().Next(6, 16);

                ToEnum(start, end);
            }
        }
    }
