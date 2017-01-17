using System;

namespace _03.Велосъзтезание
{
    class Program
    {
        static void Main()
        {
            double juniors = double.Parse(Console.ReadLine());
            double seniors = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            double all = 0;
            double allpeople = juniors + seniors;

            if (type == "trail")
            {
                juniors = juniors * 5.50;
                seniors = seniors * 7;
                all = juniors + seniors;
            }
            else if (type == "cross-country")
            {
                juniors = juniors * 8;
                seniors = seniors * 9.50;
                all = juniors + seniors;
                if (allpeople >= 50)
                {
                    all = all - (all / 100 * 25);
                }
            }
            else if (type == "downhill")
            {
                juniors = juniors * 12.25;
                seniors = seniors * 13.75;
                all = juniors + seniors;
            }
            else if (type == "road")
            {
                juniors = juniors * 20;
                seniors = seniors * 21.50;
                all = juniors + seniors;
            }
            all = all - (all / 100 * 5);

            Console.WriteLine("{0:F2}", all);
        }
    }
}
