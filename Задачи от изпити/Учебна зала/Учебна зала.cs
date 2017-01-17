using System;

namespace Учебна_зала
{
    class Program
    {
        static void Main()
        {
            double H = double.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            H = H * 100;
            W = W * 100;
            double rows = H / 120;
            rows = Math.Floor(rows);
            double h1 = W - 100;
            double desks = h1 / 70;
            desks = Math.Floor(desks);
            double places = desks * rows;
            places = places - 3;
            Console.WriteLine(places);
        }
    }
}
