using System;

namespace USD_към_BGN
{
    class Program
    {
        static void Main()
        {
            var USD = double.Parse(Console.ReadLine());
            var BGN = USD * 1.79549;
            BGN = Math.Round(BGN, 2);

            Console.WriteLine(BGN);
        }
    }
}
