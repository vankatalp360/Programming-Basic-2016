using System;

namespace _1.Проверка_за_отлична_оценка
{
    class Program
    {
        static void Main()
        {
            double Grade = double.Parse(Console.ReadLine());
            if (Grade >= 5.5)
            {
                Console.WriteLine("Excellent!");
            } 
        }
    }
}
