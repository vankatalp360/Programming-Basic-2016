using System;

namespace _12.Fibonacci
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int f0 = 1;
            int f1 = 1;
            int f = 0;

            if (n < 2)
            {
                Console.WriteLine("1");
            }
            else
            {
                for (int F = 0; F < n; F++)
                {
                    f = f1;
                    f1 = f0 + f1;
                    f0 = f;
                }
                Console.WriteLine(f0);
            }
        }
    }
}
