using System;

namespace Реколта
{
    class Реколта
    {
        static void Main()
        {
            int X = int.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine());
            int Z = int.Parse(Console.ReadLine());
            int worker = int.Parse(Console.ReadLine());
            double grapes = Y * X;
            double wine = (grapes / 2.5) * 40 / 100;
            double ost = 0;
            if (wine >= Z)
            {
                double wine1 = Math.Floor(wine); 
                ost = Math.Ceiling(wine - Z);
                double person = Math.Ceiling(ost / worker);
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", wine1);
                Console.WriteLine("{0} liters left -> {1} liters per person.", ost, person);
            }
            else if (wine < Z)
            {
                double nedost = Math.Floor(Z - wine);
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.",nedost);
            }
        }
    }
}
