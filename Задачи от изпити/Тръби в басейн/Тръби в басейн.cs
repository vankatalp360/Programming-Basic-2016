using System;

namespace Тръби_в_басейн
{
    class Program
    {
        static void Main()
        {
            int V = int.Parse(Console.ReadLine());
            int P1 = int.Parse(Console.ReadLine());
            int P2 = int.Parse(Console.ReadLine());
            double H = double.Parse(Console.ReadLine());
            double P1water = P1 * H;
            double P2water = P2 * H;
            double water = P1water + P2water;
            double water1 = (int)(water / V * 100);
            double P1water1 = (int)(P1water / water * 100);
            double P2water1 = (int)(P2water / water * 100);
            double overflow = water - V;
            if (water <= V)
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", water1, P1water1, P2water1);
            }
            if (water > V)
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", H, overflow);
            }
        }
    }
}
