using System;

namespace Лице_на_триъгълник
{
    class Program
    {
        static void Main()
        {
            var a = decimal.Parse(Console.ReadLine());
            var h = decimal.Parse(Console.ReadLine());
            var area = (a * h) / 2;

            area = Math.Round(area, 2);

            Console.WriteLine(area);
        }
    }
}
