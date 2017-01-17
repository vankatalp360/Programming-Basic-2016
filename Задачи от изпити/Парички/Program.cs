using System;

namespace Парички
{
    class Program
    {
        static void Main()
        {
            int bitcoin = int.Parse(Console.ReadLine());
            double china = double.Parse(Console.ReadLine());
            double komis = double.Parse(Console.ReadLine());
            double BGNb = bitcoin * 1168; 
            double uin = china * 0.15; 
            double BGNu = uin * 1.76; 
            double All = BGNb + BGNu; 
            All = All / 1.95; 
            komis = All * komis / 100; 
            Console.WriteLine(All - komis);
        }
    }
}
