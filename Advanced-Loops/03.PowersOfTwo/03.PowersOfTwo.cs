using System;

namespace _03.PowersOfTwo
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double num = 1;

            for (int Power = 0; Power <= n; Power++)
            {
                num = Math.Pow(2, Power);
                Console.WriteLine(num);
            }
        }
    }
}
