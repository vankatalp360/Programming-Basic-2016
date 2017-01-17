using System;

namespace _5.Invalid_Number
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            if (number < 100 && number != 0 || number > 200)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
