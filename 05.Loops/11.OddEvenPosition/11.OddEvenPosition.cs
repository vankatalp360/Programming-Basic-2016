using System;

namespace _11.OddEvenPosition
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double OddSum = 0;
            double OddMin = 1000000000.0;
            double OddMax = -1000000000.0;
            double EvenSum = 0;
            double EvenMin = 1000000000.0;
            double EvenMax = -1000000000.0;
            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    EvenSum += num;
                }
                else 
                {
                    OddSum += num;
                }
                if ((EvenMax < num) && (i % 2 == 0))
                {
                    EvenMax = num;
                }
                if ((EvenMin > num) && (i % 2 == 0))
                {
                    EvenMin = num;
                }
                if ((OddMax < num) && (i % 2 != 0))
                {
                    OddMax = num;
                }
                if ((OddMin > num) && (i % 2 != 0))
                {
                    OddMin = num;
                }
            }
            Console.WriteLine("OddSum = {0}", OddSum);
            if (OddMin == 1000000000.0)
            {
                Console.WriteLine("OddMin = No", OddMin);
            }
            else
            {
                Console.WriteLine("OddMin = {0}", OddMin);
            }
            if (OddMax == -1000000000.0)
            {
                Console.WriteLine("OddMax = No", OddMax);
            }
            else
            {
                Console.WriteLine("OddMax = {0}", OddMax);
            }
            Console.WriteLine("EvenSum = {0}", EvenSum);
            if (EvenMin == 1000000000.0)
            {
                Console.WriteLine("EvenMin = No", EvenMin);
            }
            else
            {
                Console.WriteLine("EvenMin = {0}", EvenMin);
            }
            if (EvenMax == -1000000000.0)
            {
                Console.WriteLine("EvenMax = No", EvenMax);
            }
            else
            {
                Console.WriteLine("EvenMax = {0}", EvenMax);
            }
        }
    }
}
