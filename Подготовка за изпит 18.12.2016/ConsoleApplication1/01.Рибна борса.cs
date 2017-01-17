using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            double skumriq = double.Parse(Console.ReadLine());
            double caca = double.Parse(Console.ReadLine());
            double palamud = double.Parse(Console.ReadLine());
            double safrid = double.Parse(Console.ReadLine());
            double midi = double.Parse(Console.ReadLine());

            palamud = ((skumriq / 100 * 60) + skumriq) * palamud;
            safrid = ((caca / 100 * 80) + caca) * safrid;
            midi = midi * 7.50;

            double All = palamud + safrid + midi;
            Console.WriteLine("{0:F2}", All);
        }
    }
}
