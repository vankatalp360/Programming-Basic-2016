﻿using System;

namespace Переметър_и_лице_на_кръг
{
    class Program
    {
        static void Main()
        {
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * r * r;
            double perimeter = 2 * Math.PI * r;

            Console.WriteLine(area);
            Console.WriteLine(perimeter);
        
        }
    }
}
