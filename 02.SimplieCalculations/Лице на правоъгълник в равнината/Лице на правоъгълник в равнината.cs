using System;

namespace Лице_на_правоъгълник_в_равнината
{
    class Program
    {
        static void Main()
        {
            var x1 = decimal.Parse(Console.ReadLine());
            var y1 = decimal.Parse(Console.ReadLine());
            var x2 = decimal.Parse(Console.ReadLine());
            var y2 = decimal.Parse(Console.ReadLine());

            var a = Math.Max(x1, x2) - Math.Min(x1, x2);
            var b = Math.Max(y1, y1) - Math.Min(y1, y2);

            var area = a * b;
            var peremetar = 2 * (a + b);

            Console.WriteLine(area);
            Console.WriteLine(peremetar);

        }
    }
}
