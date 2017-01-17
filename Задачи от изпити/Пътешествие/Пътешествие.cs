using System;

namespace Пътешествие
{
    class Пътешествие
    {
        static void Main()
        {
            double money = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double spend = 0;

            if (money <= 100)
            {
                if (season == "summer")
                {
                    spend = money / 100 * 30;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Camp - {0:F2}", spend);
                }
                else if (season == "winter")
                {
                    spend = money / 100 * 70;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Hotel - {0:F2}", spend);
                }
            }
            else if (money <= 1000 && money > 100)
            {
                if (season == "summer")
                {
                    spend = money / 100 * 40;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Camp - {0:F2}", spend);
                }
                else if (season == "winter")
                {
                    spend = money / 100 * 80;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Hotel - {0:F2}", spend);
                }
            }
            else if (money > 1000)
            {
                spend = money / 100 * 90;
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine("Hotel - {0:F2}", spend);
            }
        }
    }
}
