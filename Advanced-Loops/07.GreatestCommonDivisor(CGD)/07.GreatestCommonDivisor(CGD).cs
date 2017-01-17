using System;

namespace _07.GreatestCommonDivisor_CGD_
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = a % b;

            while (c != 0)
            {
                a = b;
                b = c;
                c = a % b;
            }

            Console.WriteLine(b);
        }
    }
}
