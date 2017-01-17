using System;

namespace Дневна_печалба
{
    class Program
    {
        static void Main()
        {
            int workdays = int.Parse(Console.ReadLine());
            double moneyday = double.Parse(Console.ReadLine());
            double US = double.Parse(Console.ReadLine());
            double month = workdays * moneyday;
            double year = (month * 12) + (month * 2.5);
            double fee = (year / 100) * 25;
            double clearyear = (year - fee) * US;
            double midday = clearyear / 365;
            midday = Math.Round(midday, 2);
            Console.WriteLine(midday);
        }
    }
}
