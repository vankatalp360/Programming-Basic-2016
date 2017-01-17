using System;

namespace Билети_за_мач
{
    class Program
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            string bilet = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());
            double procent = 0;
            double biletprice = 0;

            if (bilet == "VIP")
            {
                biletprice = 499.99;
                if (people <= 4)
                {
                    procent = budget / 100 * 75;

                }
                else if (people <= 9 && people >= 5)
                {
                    procent = budget / 100 * 60;
                }
                else if (people <= 24 && people >= 10)
                {
                    procent = budget / 100 * 50;
                }
                else if (people <= 49 && people >= 25)
                {
                    procent = budget / 100 * 40;
                }
                else if (people >= 50)
                {
                    procent = budget / 100 * 25;
                }
                budget = budget - procent;
                biletprice = biletprice * people;
                if (biletprice < budget)
                {
                    Console.WriteLine("Yes! You have {0:F2} leva left.", (budget - biletprice));
                }
                else
                {
                    Console.WriteLine("Not enough money! You need {0:F2} leva.", (biletprice - budget));
                }
            }
            else if (bilet == "Normal")
            {
                biletprice = 249.99;
                if (people <= 4)
                {
                    procent = budget / 100 * 75;
                }
                else if (people <= 9 && people >= 5)
                {
                    procent = budget / 100 * 60;
                }
                else if (people <= 24 && people >= 10)
                {
                    procent = budget / 100 * 50;
                }
                else if (people <= 49 && people >= 25)
                {
                    procent = budget / 100 * 40;
                }
                else if (people >= 50)
                {
                    procent = budget / 100 * 25;
                }
                budget = budget - procent;
                biletprice = biletprice * people;
                if (biletprice < budget)
                {
                    Console.WriteLine("Yes! You have {0:F2} leva left.", (budget - biletprice));
                }
                else
                {
                    Console.WriteLine("Not enough money! You need {0:F2} leva.", (biletprice - budget));
                }
            }
        }
    }
}
