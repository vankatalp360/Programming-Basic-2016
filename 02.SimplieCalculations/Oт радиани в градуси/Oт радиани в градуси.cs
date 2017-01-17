using System;

namespace Oт_радиани_в_градуси
{
    class Program
    {
        static void Main()
        {
            var rad = double.Parse(Console.ReadLine());
            var deg = rad * (Math.PI * 2);

            deg = Math.Round(deg, 0);

            Console.WriteLine(deg);
        }
    }
}
