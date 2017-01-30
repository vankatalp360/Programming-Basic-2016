using System;

namespace _01.RectanglesOf10x10Stars
{
    class Program
    {
        static void Main()
        {
            for (int col = 1; col <= 10; col++)
            {
                for (int row = 1;  row <= 10;  row++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
}
