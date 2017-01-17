using System;

namespace Цена_за_транспорт
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string daynight = Console.ReadLine();
            double taxi = 0;
            double bus = 0;
            double train = 0;
            if (daynight == "day")
            {
                taxi = 0.70 + (n * 0.79);
                bus = 0.09 * n;
                train = 0.06 * n;
            }
            else if (daynight == "night")
            {
                taxi = 0.70 + (n * 0.90);
                bus = 0.09 * n;
                train = 0.06 * n;
            }
            if (n < 20)
            {
                Console.WriteLine(taxi);
            }
            else if (n >= 20 && n < 100)
            {
                Console.WriteLine(bus);
            }
            else if (n >= 100)
            {
                Console.WriteLine(train);
            }
        }
    }
}
