using System;

namespace _11.Cinema
{
    class Program
    {
        static void Main()
        {
            string Type = Console.ReadLine();
            int Row = int.Parse(Console.ReadLine());
            int column = int.Parse(Console.ReadLine());
            double Premiere = 12.00;
            double Normal = 7.50;
            double Discount = 5.00;
            double result = 0;

            if (Type == "Premiere")
            {
                result = Row * column * Premiere; 
            }
            else if (Type == "Normal")
            {
                result = Row * column * Normal;
            }
            else if (Type == "Discount")
            {
                result = Row * column * Discount;
            }
            Console.WriteLine("{0:f2}", result);
        }
    }
}
