using System;

namespace _06.Максимален_брой_комбинации
{
    class Program
    {
        static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            int count = 0;

            for (int first = start; first <= end; first++)
            {
                for (int second = start; second <= end; second++)
                {
                    Console.Write("<{0}-{1}>", first, second);
                    count += 1;

                    if (count == max)
                    {
                        Console.WriteLine();
                        return;
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
