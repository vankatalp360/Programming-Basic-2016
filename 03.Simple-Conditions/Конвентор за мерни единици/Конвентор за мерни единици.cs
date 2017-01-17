using System;

namespace Конвентор_за_мерни_единици
{
    class Program
    {
        static void Main()
        {
            var num = double.Parse(Console.ReadLine());
            var inputCurrency = Console.ReadLine();
            var outputCurrency = Console.ReadLine();
            double total = 0;
            switch (inputCurrency)
            {
                case "m":
                    switch (outputCurrency)
                    {
                        case "m": total = num; break;
                        case "mm": total = num * 1000; break;
                        case "cm": total = num * 100; break;
                        case "mi": total = num * 0.000621371192; break;
                        case "in": total = num * 39.3700787; break;
                        case "km": total = num * 0.001; break;
                        case "ft": total = num * 3.2808399; break;
                        case "yd": total = num * 1.0936133; break;
                    }break;
                case "mm":
                    switch (outputCurrency)
                    {
                        case "mm": total = num; break;
                        case "m": total = (num / 1000); break;
                        case "cm": total = (num / 1000) * 100; break;
                        case "mi": total = (num / 1000)* 0.000621371192; break;
                        case "in": total = (num / 1000)* 39.3700787; break;
                        case "km": total = (num / 1000)* 0.001; break;
                        case "ft": total = (num / 1000)* 3.2808399; break;
                        case "yd": total = (num / 1000)* 1.0936133; break;
                    }break;
                case "cm":
                    switch (outputCurrency)
                    {
                        case "cm": total = num; break;
                        case "m": total = (num / 100); break;
                        case "mm": total = (num / 100) * 1000; break;
                        case "mi": total = (num / 100) * 0.000621371192; break;
                        case "in": total = (num / 100) * 39.3700787; break;
                        case "km": total = (num / 100) * 0.001; break;
                        case "ft": total = (num / 100) * 3.2808399; break;
                        case "yd": total = (num / 100) * 1.0936133; break;
                    }break;
                case "mi":
                    switch (outputCurrency)
                    {
                        case "mi": total = num; break;
                        case "m": total = (num / 0.000621371192); break;
                        case "mm": total = (num / 0.000621371192) * 1000; break;
                        case "cm": total = (num / 0.000621371192) * 100; break;
                        case "in": total = (num / 0.000621371192) * 39.3700787; break;
                        case "km": total = (num / 0.000621371192) * 0.001; break;
                        case "ft": total = (num / 0.000621371192) * 3.2808399; break;
                        case "yd": total = (num / 0.000621371192) * 1.0936133; break;
                    }break;
                case "in":
                    switch (outputCurrency)
                    {
                        case "in": total = num; break;
                        case "m": total = (num / 39.3700787); break;
                        case "mm": total = (num / 39.3700787) * 1000; break;
                        case "cm": total = (num / 39.3700787) * 100; break;
                        case "mi": total = (num / 39.3700787) * 0.000621371192; break;
                        case "km": total = (num / 39.3700787) * 0.001; break;
                        case "ft": total = (num / 39.3700787) * 3.2808399; break;
                        case "yd": total = (num / 39.3700787) * 1.0936133; break;
                    }break;
                case "km":
                    switch (outputCurrency)
                    {
                        case "km": total = num; break;
                        case "m": total = (num / 0.001); break;
                        case "mm": total = (num / 0.001) * 1000; break;
                        case "cm": total = (num / 0.001) * 100; break;
                        case "mi": total = (num / 0.001) * 0.000621371192; break;
                        case "in": total = (num / 0.001) * 39.3700787; break;
                        case "ft": total = (num / 0.001) * 3.2808399; break;
                        case "yd": total = (num / 0.001) * 1.0936133; break;
                    }break;
                case "ft":
                    switch (outputCurrency)
                    {
                        case "ft": total  = num; break;
                        case "m": total = (num / 3.2808399); break;
                        case "mm": total = (num / 3.2808399) * 1000; break;
                        case "cm": total = (num / 3.2808399) * 100; break;
                        case "mi": total = (num / 3.2808399) * 0.000621371192; break;
                        case "in": total = (num / 3.2808399) * 39.3700787; break;
                        case "km": total = (num / 3.2808399) * 0.001; break;
                        case "yd": total = (num / 3.2808399) * 1.0936133; break;
                    }break;
                case "yd":
                    switch (outputCurrency)
                    {
                        case "yd": total = num; break;
                        case "m": total = (num / 1.0936133); break;
                        case "mm": total = (num / 1.0936133) * 1000; break;
                        case "cm": total = (num / 1.0936133) * 100; break;
                        case "mi": total = (num / 1.0936133) * 0.000621371192; break;
                        case "in": total = (num / 1.0936133) * 39.3700787; break;
                        case "km": total = (num / 1.0936133) * 0.001; break;
                        case "ft": total = (num / 1.0936133) * 3.2808399; break;
                    }break;
            }
            Console.WriteLine("{0} {1}", total, outputCurrency);
        }
    }
}
