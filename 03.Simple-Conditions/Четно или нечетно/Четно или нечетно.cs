using System;

namespace Четно_или_нечетно
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());            
            if (a % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}
