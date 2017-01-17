using System;

namespace Време___15_минути
{
    class Program
    {
        static void Main()
        {
            int hh = int.Parse(Console.ReadLine());
            int mm = int.Parse(Console.ReadLine());
            mm = mm + 15;
            if (mm > 59)
            {
                hh = hh + 1;
                mm = mm - 60;
            }
            if (hh > 23)
            {
                hh = 0;
            }
            if (mm < 10)
            {
                Console.WriteLine("{0}:0{1}", hh, mm);
            }
            else
            {
                Console.WriteLine("{0}:{1}", hh, mm);
            }           
        }
    }
}
