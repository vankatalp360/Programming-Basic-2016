using System;

namespace _03.Магазин_за_цветя
{
    class Program
    {
        static void Main()
        {
            int broihrizantemi = int.Parse(Console.ReadLine());
            int broirozi = int.Parse(Console.ReadLine());
            int broilaleta = int.Parse(Console.ReadLine());
            string sezon = Console.ReadLine();
            string praznik = Console.ReadLine();
            double hrizantemi = 0;
            double rozi = 0;
            double laleta = 0;
            double cvetq = broirozi + broilaleta + broihrizantemi;

            if (sezon == "Spring" || sezon == "Summer")
            {
                hrizantemi = 2.00;
                rozi = 4.10;
                laleta = 2.50;
                hrizantemi = hrizantemi * broihrizantemi;
                rozi = rozi * broirozi;
                laleta = laleta * broilaleta;
            }
            else if (sezon == "Autumn" || sezon == "Winter")
            {
                hrizantemi = 3.75;
                rozi = 4.50;
                laleta = 4.15;
                hrizantemi = hrizantemi * broihrizantemi;
                rozi = rozi * broirozi;
                laleta = laleta * broilaleta;
            }
            double all = rozi + hrizantemi + laleta;

            if (praznik == "Y")
            {
                all = all + (all / 100 * 15);
            }
            if (broilaleta > 7 && sezon == "Spring")
            {
                all = all - (all / 100 * 5);
            }
            if (broirozi >= 10 && sezon == "Winter")
            {
                all = all - (all / 100 * 10);
            }
            if (cvetq > 20)
            {
                all = all - (all / 100 * 20);
            }

            all = all + 2;
            Console.WriteLine("{0:F2}", all);
        }
    }
}
