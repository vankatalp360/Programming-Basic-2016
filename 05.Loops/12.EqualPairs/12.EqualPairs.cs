using System;

namespace _12.EqualPairs
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int diff = 0;
            int p = 0;
            int maxdiff = -9999999;

            for (int N = 1; N <= n; N++)
            {
                for (int i = 1; i <= n / n; i++)
                {
                    int num = int.Parse(Console.ReadLine());
                    int num1 = int.Parse(Console.ReadLine());
                    sum = num + num1; 
                    if (N == 1)
                    {
                        diff = 0;
                    }
                    else
                    {
                        diff = sum - p;
                        diff = Math.Abs(diff);
                    }
                    if (N != 1)
                    {
                        if (maxdiff < diff)
                        {
                            maxdiff = diff;
                        }
                    }
                    p = sum;
                }
            }
            maxdiff = Math.Abs(maxdiff);
            if (diff == 0)
            {
                Console.WriteLine("Yes, value={0}", sum);
            }
            else
            {
                Console.WriteLine("No, maxdiff={0}", maxdiff);
            }
        }
    }
}
