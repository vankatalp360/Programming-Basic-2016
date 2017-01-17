using System;

namespace Бонус_точки
{
    class Program
    {
        static void Main()
        {
            double num = int.Parse(Console.ReadLine());
            double bonus = 0;
            if (num <= 100)
            {
                bonus = 5;
            }
            else if (num > 100 && num <= 1000)
            {
                bonus = num * ((double)20 / 100);
            }
            else if (num > 100)
            {
                bonus = num * ((double)10 / 100);
            }
            if (num % 2 ==0)
            {
                bonus = bonus + 1;
            }
            else if (num % 5 == 0)
            {
                bonus = bonus + 2;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(num + bonus);
        }
    }
}
