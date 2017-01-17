using System;

namespace Еднакви_думи
{
    class Program
    {
        static void Main()
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            a = a.ToLower();
            b = b.ToLower();
            if (a == b)
            {
                Console.WriteLine("yes");
            }
            else if (a != b)
            {
                Console.WriteLine("no");
            }
        }
    }
}
