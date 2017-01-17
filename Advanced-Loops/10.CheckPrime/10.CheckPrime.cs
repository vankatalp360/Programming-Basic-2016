using System;

namespace _10.CheckPrime
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double Sqrt = Math.Sqrt(n);

            if (n <= 1)
            {
                Console.WriteLine("Not Prime");
                return;
            }
            for (int i = 2; i <= Sqrt; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("Not Prime");
                    return;
                }

            }
                Console.WriteLine("Prime");
        }
    }
}
