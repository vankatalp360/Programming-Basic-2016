using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лице_на_правоъгълник
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a=");                 
            var a = decimal.Parse(Console.ReadLine());
            Console.WriteLine("b=");
            var b = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Лицето е равно на");
            Console.WriteLine(a * b);

            // TODO: calculate the area and print it
        }

    }
}
