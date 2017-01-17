using System;

namespace _05.MaxNumber
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int max = -99999999;
            for (int N = 0; N < n; N++)
            {
                int num = int.Parse(Console.ReadLine());

                if(num > max)
                {
                    max = num;
                }
            }
            Console.WriteLine(max);
        }
    }
}
