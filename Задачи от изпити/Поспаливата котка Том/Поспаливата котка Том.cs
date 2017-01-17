using System;

namespace Поспаливата_котка_Том
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int norm = 30000;
            int work = 365 - n;
            int playn = 127 * n;
            int playwork = 63 * work;
            int fullplaytime = playn + playwork;
            int diff = Math.Abs(norm - fullplaytime);
            int hh = diff / 60;
            int mm = diff - (hh * 60);
            if (norm >= fullplaytime)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", hh, mm);
            }
            else if (norm < fullplaytime)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", hh, mm);
            }
        }
    }
}
