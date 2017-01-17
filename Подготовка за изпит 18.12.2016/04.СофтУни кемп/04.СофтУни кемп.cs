using System;

namespace _04.СофтУни_кемп
{
    class Program
    {
        static void Main()
        {
            int groupe = int.Parse(Console.ReadLine());
            double groupe5 = 0;
            double groupe12 = 0;
            double groupe25 = 0;
            double groupe40 = 0;
            double groupe41 = 0;
            int all = 0;

            for (int number = 1; number <= groupe; number++)
            {
                int people = int.Parse(Console.ReadLine());
                all += people;

                if (people <= 5)
                {
                    groupe5 += people;
                }
                else if (people >= 6 && people <= 12)
                {
                    groupe12 += people;
                }
                else if (people >= 13 && people <= 25)
                {
                    groupe25 += people;
                }
                else if (people >= 26 && people <=40)
                {
                    groupe40 += people;
                }
                else if (people >= 41)
                {
                    groupe41 += people;
                }
            }
            groupe5 = groupe5 / all * 100;
            groupe12 = groupe12 / all * 100;
            groupe25 = groupe25 / all * 100;
            groupe40 = groupe40 / all * 100;
            groupe41 = groupe41 / all * 100;

            Console.WriteLine("{0:F2}%", groupe5);
            Console.WriteLine("{0:F2}%", groupe12);
            Console.WriteLine("{0:F2}%", groupe25);
            Console.WriteLine("{0:F2}%", groupe40);
            Console.WriteLine("{0:F2}%", groupe41);
        }
    }
}
