using System;

namespace _02.Магазин_за_цветя
{
    class Program
    {
        static void Main()
        {
            int nummagnolii = int.Parse(Console.ReadLine());
            int numziombioli = int.Parse(Console.ReadLine());
            int numrose = int.Parse(Console.ReadLine());
            int numcactus = int.Parse(Console.ReadLine());
            double pricepresent = double.Parse(Console.ReadLine());

            double magnolii = 3.25;
            double ziombioli = 4;
            double rose = 3.50;
            double cactus = 8;
            double all = 0;

            magnolii = magnolii * nummagnolii;
            ziombioli = ziombioli * numziombioli;
            rose = rose * numrose;
            cactus = cactus * numcactus;

            all = magnolii + ziombioli + rose + cactus;
            all = all - (all / 100 * 5);

            if (all >= pricepresent)
            {
                all = Math.Floor(all - pricepresent);
                Console.WriteLine("She is left with {0} leva.", all);
            }
            else
            {
                all = Math.Ceiling(pricepresent - all);
                Console.WriteLine("She will have to borrow {0} leva.", all);
            }
        }
    }
}
