using System;

namespace Лице_на_квадрат
{
    class Program
    {
        static void Main()
        {
            Console.Write("a = ");
            Decimal a = decimal.Parse(Console.ReadLine());
            Decimal area = a * a;
            Console.Write("Square = ");
            Console.WriteLine(area);


        }
    }
}
