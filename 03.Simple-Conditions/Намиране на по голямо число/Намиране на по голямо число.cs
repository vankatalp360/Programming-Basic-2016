using System;

namespace Намиране_на_по_голямо_число
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a <= b)
            {
                Console.WriteLine(b);
            }
            else if (b <= a)
            {
                Console.WriteLine(a);
            }
        }
    }
}
