using System;

namespace _08.OddEvenSum
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int Even = 0;
            int Odd = 0;
            int Sum = 0;

            for (int i = 0; i < n; i++)
            {
                for (int N = 0; N < n / n; N++)
                {
                    int num = int.Parse(Console.ReadLine());
                    if (i % 2 == 0)
                    {
                        Even += num;
                    }
                    else
                    {
                        Odd += num;
                    }
                }
            }
            Sum = Math.Abs(Even - Odd);
            if (Sum != 0)
            {
                Console.WriteLine("No, diff = {0}", Sum);
            }
            else
            {
                Console.WriteLine("Yes, sum = {0}", Odd);
            }

        }
    }
}
