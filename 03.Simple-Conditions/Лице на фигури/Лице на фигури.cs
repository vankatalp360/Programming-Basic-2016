using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лице_на_фигури
{
    class Program
    {
        static void Main(string[] args)
        {
            string figur = Console.ReadLine();
            double area = 0;
            if (figur == "square")
            {
                double a = double.Parse(Console.ReadLine());
                area = a * a;
            }
            else if (figur == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                area = a * b;
            }
            else if (figur == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                area = Math.PI * r * r;
            }
            else if (figur == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                area = (a * h) / 2;
            }
            area = Math.Round(area, 3);
            Console.WriteLine(area);
        }
    }
}
