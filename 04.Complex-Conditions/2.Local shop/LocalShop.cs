using System;
namespace _2.Local_shop
{

    class LocalShop
    {
        static void Main()
        {
            string product = Console.ReadLine();
            string City = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());
            double total = 0;

            if (City == "Sofia")
            {
                if (product == "coffee") total = 0.50 * amount;
                if (product == "water") total = 0.80 * amount;
                if (product == "beer") total = 1.20 * amount;
                if (product == "sweets") total = 1.45 * amount;
                if (product == "peanuts") total = 1.60 * amount;
            }
            if (City == "Plovdiv")
            {
                if (product == "coffee") total = 0.40 * amount;
                if (product == "water") total = 0.70 * amount;
                if (product == "beer") total = 1.15 * amount;
                if (product == "sweets") total = 1.30 * amount;
                if (product == "peanuts") total = 1.50 * amount;
            }
            if (City == "Varna")
            {
                if (product == "coffee") total = 0.45 * amount;
                if (product == "water") total = 0.70 * amount;
                if (product == "beer") total = 1.10 * amount;
                if (product == "sweets") total = 1.35 * amount;
                if (product == "peanuts") total = 1.55 * amount;
            }
            Console.WriteLine(total);
        }
    }
}
