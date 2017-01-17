using System;

namespace Умната_Лили
{
    class Program
    {
        static void Main()
        {
            int old = int.Parse(Console.ReadLine());
            double laundry = double.Parse(Console.ReadLine());
            int toyprice = int.Parse(Console.ReadLine());
            double money = 0;
            int toy = 0;
            double AllMoney = 0;
            double allmoney = 0;
            int brother = old / 2;
            for (int i = 1; i <= old; i++)
            {
                if (i % 2 == 0)
                {
                    if (i == 2)
                    {
                        money = 10.00;
                        allmoney += money;
                    }
                    else
                    {
                        money += 10.00;
                        allmoney += money;
                    }
                }
                else
                {
                    toy += 1;
                }
            }
            AllMoney = allmoney - (1.00 * brother);
            toyprice = toyprice * toy;
            AllMoney = AllMoney + toyprice;
            double N = AllMoney - laundry;
            double M = laundry - AllMoney;
            N = Math.Abs(N);
            M = Math.Abs(M);

            if (laundry <= AllMoney)
            {
                Console.WriteLine("Yes! {0:F2}", N);
            }

            else if (AllMoney < laundry)
            {
                Console.WriteLine("No! {0:F2}", M);
            }
        }
    }
}
