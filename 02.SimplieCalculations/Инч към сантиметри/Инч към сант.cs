using System;

namespace Инч_към_сантиметри
{
    class Program
    {
        static void Main()
        {
            Console.Write("Inches = ");
            double inches = double.Parse(Console.ReadLine());
            double centimeters = inches * 2.54;
            Console.Write("Centimetres = ");
            Console.WriteLine(centimeters);
        }
    }
}
