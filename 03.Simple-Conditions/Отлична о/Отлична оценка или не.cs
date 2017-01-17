using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Отлична_о
{
    class Program
    {
        static void Main(string[] args)
        {
            double Grade = double.Parse(Console.ReadLine());
            if (Grade >= 5.5)
            {
                Console.WriteLine("Excellent!");
            }
            else
            {
                Console.WriteLine("Not excellent.");
            }
        }
    }
}
