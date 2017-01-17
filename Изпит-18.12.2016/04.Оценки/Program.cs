using System;

namespace _04.Оценки
{
    class Program
    {
        static void Main()
        {
            int students = int.Parse(Console.ReadLine());
            double topstudents = 0;
            double betwin44 = 0;
            double betwin33 = 0;
            double fail = 0;
            double average = 0;

            for (int student = 1; student <= students; student++)
            {
                double ocenka = double.Parse(Console.ReadLine());
                if (ocenka >= 5)
                {
                    topstudents += 1;
                    average += ocenka;
                }
                else if (ocenka >= 4 && ocenka <= 4.99)
                {
                    betwin44 += 1;
                    average += ocenka;
                }
                else if (ocenka >= 3 && ocenka <= 3.99)
                {
                    betwin33 += 1;
                    average += ocenka;
                }
                else if (ocenka < 3)
                {
                    fail += 1;
                    average += ocenka;
                }
            }
            topstudents = topstudents / students * 100;
            betwin44 = betwin44 / students * 100;
            betwin33 = betwin33 / students * 100;
            fail = fail / students * 100;
            average = average / students;

            Console.WriteLine("Top students: {0:F2}%", topstudents);
            Console.WriteLine("Between 4.00 and 4.99: {0:F2}%", betwin44);
            Console.WriteLine("Between 3.00 and 3.99: {0:F2}%", betwin33);
            Console.WriteLine("Fail: {0:F2}%", fail);
            Console.WriteLine("Average: {0:F2}", average);
        }
    }
}
