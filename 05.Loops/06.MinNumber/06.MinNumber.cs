using System;

namespace _06.MinNumber
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int min = 99999999;
            for (int N = 0; N < n; N++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num < min)
                {
                    min = num;
                }
            }
            Console.WriteLine(min);
        }
    }
}
