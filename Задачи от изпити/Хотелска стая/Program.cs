using System;

namespace Хотелска_стая
{
    class Program
    {
        static void Main()
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double Studio = 0;
            double Apart = 0;
            double Studioprocent = 0;
            double Apartprocent = 0;

            if (month == "May" || month == "October")
            {
                Studio = 50;
                Apart = 65;
                if (nights > 7 && nights <= 14)
                {
                    Studioprocent = Studio / 100 * 5;
                }
                else if (nights > 14)
                {
                    Studioprocent = Studio / 100 * 30;
                }
                if (nights > 14)
                {
                    Apartprocent = Apart / 100 * 10;
                }
                Studio = nights * (Studio - Studioprocent);
                Apart = nights * (Apart - Apartprocent);
            }
            else if (month == "June" || month == "September")
            {
                Studio = 75.20;
                Apart = 68.70;
                if (nights > 14)
                {
                    Studioprocent = Studio / 100 * 20;
                }
                if (nights > 14)
                {
                    Apartprocent = Apart / 100 * 10;
                }
                Studio = nights * (Studio - Studioprocent);
                Apart = nights * (Apart - Apartprocent);
            }
            else if (month == "July" || month == "August")
            {
                Studio = 76;
                Apart = 77;
                if (nights > 14)
                {
                    Apartprocent = Apart / 100 * 10;
                }
                Studio = nights * (Studio - Studioprocent);
                Apart = nights * (Apart - Apartprocent);
            }
            Console.WriteLine("Apartment: {0:F2} lv.", Apart);
            Console.WriteLine("Studio: {0:F2} lv.", Studio);
        }
    }
}
