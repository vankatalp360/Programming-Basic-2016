using System;

namespace Фирма
{
    class Фирма
    {
        static void Main()
        {
            int H = int.Parse(Console.ReadLine());
            double Days = double.Parse(Console.ReadLine());
            int worker = int.Parse(Console.ReadLine());
            double tranning = ((Days / 100) * 10);
            tranning = Days - tranning; 
            double workday = tranning * 8; 
            double overtime = worker * (2 * Days); 
            double ALLH = workday + overtime; 
            ALLH = Math.Floor(ALLH);
            if (ALLH >= H)
            {
                double lefttime = ALLH - H;
                Console.WriteLine("Yes!{0} hours left.", lefttime);
            }
            if (ALLH < H)
            {
                double needtime = (H - ALLH);
                Console.WriteLine("Not enough time!{0} hours needed.", needtime);
            }
        }
    }
}
