using System;

namespace _03.Ваканция
{
    class Program
    {
        static void Main()
        {
            int old = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            string trans = Console.ReadLine();
            double oldprice = 0;
            double studentsprice = 0;
            double hotel = 0;
            double sum = 0;
            double transprice = 0;


            if (trans == "train")
            {
                oldprice = 24.99;
                studentsprice = 14.99;
                if ((old + students) >= 50)
                {
                    oldprice = oldprice / 100 * 50;
                    studentsprice = studentsprice / 100 * 50;
                }

            }
            else if (trans == "bus")
            {
                oldprice = 32.50;
                studentsprice = 28.50;
            }
            else if (trans == "boat")
            {
                oldprice = 42.99;
                studentsprice = 39.99;
            }
            else if (trans == "airplane")
            {
                oldprice = 70.00;
                studentsprice = 50.00;
            }
            oldprice = old * oldprice;
            studentsprice = students * studentsprice;
            transprice = (studentsprice + oldprice) * 2;
            hotel = nights * 82.99;
            sum = (transprice + hotel) * 0.10;
            sum = sum + transprice + hotel;

            Console.WriteLine("{0:F2}", sum);
        }
    }
}
