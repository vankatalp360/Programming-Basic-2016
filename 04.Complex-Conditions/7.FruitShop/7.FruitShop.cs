using System;

namespace _7.FruitShop
{
    class Program
    {
        static void Main()
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());
            double total = 0;
            if ((day == "Monday") || (day == "Tuesday") || (day == "Wednesday") || (day == "Thursday") || (day == "Friday"))
            {
                if (fruit == "banana") total = 2.50 * amount;
                else if (fruit == "apple") total = 1.20 * amount;
                else if (fruit == "orange") total = 0.85 * amount;
                else if (fruit == "grapefruit") total = 1.45 * amount;
                else if (fruit == "kiwi") total = 2.70 * amount;
                else if (fruit == "pineapple") total = 5.50 * amount;
                else if (fruit == "grapes") total = 3.85 * amount;
            }
            if ((day == "Saturday") || (day == "Sunday"))
            {
                if (fruit == "banana") total = 2.70 * amount;
                else if (fruit == "apple") total = 1.25 * amount;
                else if (fruit == "orange") total = 0.90 * amount;
                else if (fruit == "grapefruit") total = 1.60 * amount;
                else if (fruit == "kiwi") total = 3.00 * amount;
                else if (fruit == "pineapple") total = 5.60 * amount;
                else if (fruit == "grapes") total = 4.20 * amount;
            }
            if (total > 0)
            {
                Console.WriteLine(total);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
