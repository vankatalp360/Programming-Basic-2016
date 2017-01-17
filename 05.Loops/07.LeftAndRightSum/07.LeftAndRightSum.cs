using System;

namespace _07.LeftAndRightSum
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int LeftSum = 0;
            int RightSum = 0;
            int Sum = 0;

            for (int N = 0; N < n; N++)
            {
                int num = int.Parse(Console.ReadLine());
                LeftSum += num;
            }
            for (int N = 0; N < n; N++)
            {
                int num = int.Parse(Console.ReadLine());
                RightSum += num;
            }
            Sum = Math.Abs(LeftSum - RightSum);
            if (Sum != 0)
            {
                Console.WriteLine("No, diff = {0}", Sum);
            }
            else
            {
                Console.WriteLine("Yes, sum = {0}", RightSum);
            }
        }
    }
}
