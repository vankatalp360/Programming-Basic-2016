using System;

namespace _3.Point_In_a_Rectangle
{
    class Program
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            string answer;
            if (x >= x1 && x <= x2 && y >= y1 && y <= y2)
            {
                answer = "Inside";
            }
            else
            {
                answer = "Outside";
            }
            Console.WriteLine(answer);
        }
    }
}
