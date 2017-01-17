using System;

namespace _01.Разстояние
{
    class Program
    {
        static void Main()
        {
            double firstspeed = int.Parse(Console.ReadLine());
            double firsttime = int.Parse(Console.ReadLine());
            double secondtime = int.Parse(Console.ReadLine());
            double thirdtime = int.Parse(Console.ReadLine());
            double form = 1.166 ;
            double secondspeed = 0;
            double thirdspeed = 0;
            double firstspeed1 = 0;

            firsttime = firsttime / 60;
            firstspeed1 = firstspeed * firsttime;
            secondtime = secondtime / 60;
            secondspeed = firstspeed + (firstspeed / 100 * 10);
            double secondspeed1 = secondtime * secondspeed;
            thirdtime = thirdtime / 60;
            thirdspeed = (secondspeed - (secondspeed / 100 * 5));
            thirdspeed = thirdspeed * thirdtime;
            double all = firstspeed1 + secondspeed1 + thirdspeed;

            Console.WriteLine("{0:F2}", all);
        }
    }
}
