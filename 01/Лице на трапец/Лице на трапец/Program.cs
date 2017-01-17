using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лице_на_трапец
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = decimal.Parse(Console.ReadLine());
            var b = decimal.Parse(Console.ReadLine());
            var h = decimal.Parse(Console.ReadLine());

            Console.WriteLine(((a + b) * h) / 2);
        }
    }
}
