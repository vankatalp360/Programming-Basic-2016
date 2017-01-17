using System;

namespace _04.EvenPowersOf2
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            double num = 1;

            for (int Power = 0; Power <= n; Power += 2)
            {
                Console.WriteLine(num);
                num *= 4;
            }
        }
    }
}
