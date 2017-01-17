using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadZ13_Point_In_The_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            var rectOneX1 = 0;
            var rectOneX2 = h * 3;
            var rectOneY1 = 0;
            var rectOneY2 = h;
            var rectTwoX1 = h;
            var rectTwoX2 = (h * 2);
            var rectTwoY1 = h;
            var rectTwoY2 = (h * 4);

            if ((x > rectOneX1 && x < rectOneX2) && (y > rectOneY1 && y < rectOneY2) ||
                    (y > rectOneY1 && y < rectOneY2) && (x > rectOneX1 && x < rectOneX2))
            { Console.WriteLine("inside"); }
            else if ((x > rectTwoX1 && x < rectTwoX2) && (y > rectTwoY1 && y < rectTwoY2) ||
                    (y > rectTwoY1 && y < rectTwoY2) && (x > rectTwoX1 && x < rectTwoX2))
            { Console.WriteLine("inside"); }
            else if ((x > h && x < (2 * h)) && y == h)
            { Console.WriteLine("inside"); }
            else if ((x == rectOneX1 || x == rectOneX2) && (y >= rectOneY1 && y <= rectOneY2) ||
                    (y == rectOneY1 || y == rectOneY2) && (x >= rectOneX1 && x <= rectOneX2))
            { Console.WriteLine("border"); }
            else if ((x == rectTwoX1 || x == rectTwoX2) && (y >= rectTwoY1 && y <= rectTwoY2) ||
                    (y == rectTwoY1 || y == rectTwoY2) && (x >= rectTwoX1 && x <= rectTwoX2))
            { Console.WriteLine("border"); }
            else
            { Console.WriteLine("outside"); }
        }
    }
}