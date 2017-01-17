using System;

namespace Зеленчукова_борса
{
    class Program
    {
        static void Main()
        {
            double N = double.Parse(Console.ReadLine());
            double M = double.Parse(Console.ReadLine());
            int veg = int.Parse(Console.ReadLine());
            int frut = int.Parse(Console.ReadLine());


            
                double vegprice = N * veg;
                double frutprice = M * frut;
                double BGN = vegprice + frutprice;
                double EUR = BGN / 1.94;

                Console.WriteLine(EUR);
            
        }
    }
}
