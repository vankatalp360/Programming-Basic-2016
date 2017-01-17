using System;

namespace _10.HalfSumElement
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = 0;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
                if (num > max)
                {
                    max = num;
                }
            }
            if (sum == max * 2)
            {
                Console.WriteLine("Yes sum = {0}", max);
            }
            else
            {
                Console.WriteLine("No Diff = {0}", Math.Abs(max - (sum - max)));
            }
        }
    }
}
