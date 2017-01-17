using System;

namespace _11.EnterEvenNumber
{
    class Program
    {
        static void Main()
        {
            int m = 2;

            for (int i = 0; i < m; i++)
            {
                try
                {
                    int n = int.Parse(Console.ReadLine());

                    while (n % 2 != 0)
                    {
                        Console.WriteLine("The number is not even.");
                        n = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Even number entered: {0}", n);
                    return;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid number!");
                    i = 0;
                }
            }
        }
    }
}
