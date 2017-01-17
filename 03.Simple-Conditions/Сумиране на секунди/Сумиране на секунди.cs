using System;

namespace Сумиране_на_секунди
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int sum = a + b + c;
            string minSec = string.Format("{0}:{1:00}", sum / 60, sum % 60);
            Console.WriteLine(minSec);
        }
    }
}
