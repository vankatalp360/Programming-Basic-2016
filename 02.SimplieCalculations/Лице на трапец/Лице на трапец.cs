﻿using System;

namespace Лице_на_трапец
{
    class Program
    {
        static void Main()
        {
            double b1 = double.Parse (Console.ReadLine());
            double b2 = double.Parse (Console.ReadLine());
            double h = double.Parse (Console.ReadLine());
            Console.WriteLine((b1 + b2) * h / 2);

        }
    }
}
