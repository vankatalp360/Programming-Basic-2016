using System;

namespace Ремонт_на_плочки
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double L = double.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int O = int.Parse(Console.ReadLine());
            double plosht = N * N; 
            double bench = M * O; 
            double cover = plosht - bench; 
            double plate = W * L; 
            double needplate = cover / plate; 
            double needtime = needplate * 0.2;
            Console.WriteLine(needplate);
            Console.WriteLine(needtime);
        }
    }
}
