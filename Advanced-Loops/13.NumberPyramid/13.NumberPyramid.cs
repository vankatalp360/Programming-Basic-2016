using System;

namespace _13.NumberPyramid
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;

            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write("{0} ", num);
                    if (num == n)
                    {
                        Console.WriteLine();
                        return;
                    }
                    num++;
                }
                Console.WriteLine();
            }
        }
    }
}
