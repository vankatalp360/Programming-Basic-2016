using System;

namespace _01.Цена_на_жилище
{
    class Program
    {
        static void Main()
        {
            double firstroom = double.Parse(Console.ReadLine());
            double kitchen = double.Parse(Console.ReadLine());
            double pricekm2 = double.Parse(Console.ReadLine());

            double bathroom = firstroom / 2;
            double secondroom = firstroom + (firstroom / 100 * 10);
            double thirdroom = secondroom + (secondroom / 100 * 10);

            double all = kitchen + firstroom + secondroom + thirdroom + bathroom;
            all = all + (all / 100 * 5);
            all = all * pricekm2;

            Console.WriteLine("{0:F2}", all);
        }
    }
}
