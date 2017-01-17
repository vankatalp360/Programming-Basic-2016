using System;

namespace _C_към_градуси__F
{
    class Program
    {
        static void Main()
        {
            var C = double.Parse(Console.ReadLine());
            var F = ((C * 1.8) + 32);
            F = Math.Round(F, 2);

            Console.WriteLine(F);
        }
    }
}
