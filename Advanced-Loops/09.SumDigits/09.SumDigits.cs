using System;

namespace _09.SumDigits
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            while (num != 0)
            {
                sum += (num % 10);
                num = num / 10;
            }
            Console.WriteLine(sum);
        }
    }
}
