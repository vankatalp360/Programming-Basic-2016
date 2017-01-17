using System;

namespace _12.Volleyball
{
    class Program
    {
        static void Main()
        {
            string year = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            decimal Allleap = 0;
            decimal SatSofia = 0;

            if (year == "leap")
            {
                SatSofia = ((48 - h) / 4.00m) * 3;
                decimal Holiday = (p / 3.00m) * 2;
                decimal All = SatSofia + h + Holiday;
                decimal percent = (All / 100) * 15;
                Allleap = All + percent;
                Allleap = Math.Floor(Allleap);
            }
            else if (year == "normal")
            {
                SatSofia = ((48 - h) / 4.00m) * 3;
                decimal Holiday = (p / 3.00m) * 2;
                decimal All = SatSofia + h + Holiday;
                Allleap = All;
                Allleap = Math.Floor(Allleap);
            }
            Console.WriteLine(Allleap);
        }
    }
}
