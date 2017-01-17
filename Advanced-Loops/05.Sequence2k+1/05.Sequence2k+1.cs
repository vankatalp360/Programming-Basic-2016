using System;

namespace _05.Sequence2k_1
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;

            while (n >= num)
            {
                Console.WriteLine(num);
                num = num * 2 + 1;
            }
        }
    }
}
