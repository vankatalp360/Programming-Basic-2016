using System;

namespace _04.Логистика
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            double microbus = 0;
            double truck = 0;
            double train = 0;
            double all = 0;
            double microbusproc = 0;
            double truckproc = 0;
            double trainproc = 0;
            double alltrans = 0;

            for (int load = 1; load <= num; load++)
            {
                int tons = int.Parse(Console.ReadLine());
                if (tons <= 3)
                {
                    microbus = microbus + tons;
                }
                else if (tons >= 4 && tons <= 11)
                {
                    truck = truck + tons;
                }
                else if (tons >= 12)
                {
                    train = train + tons;
                }
            }
            alltrans = microbus + truck + train;
            microbusproc = microbus / alltrans * 100;
            trainproc = train / alltrans * 100;
            truckproc = truck / alltrans * 100;
            microbus = microbus * 200;
            truck = truck * 175;
            train = train * 120;
            all = (microbus + train + truck) / alltrans;

            Console.WriteLine("{0:F2}", all);
            Console.WriteLine("{0:F2}%", microbusproc);
            Console.WriteLine("{0:F2}%", truckproc);
            Console.WriteLine("{0:F2}%", trainproc);
        }
    }
}
