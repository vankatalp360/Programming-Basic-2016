using System;

namespace _06.Битки
{
    class Program
    {
        static void Main()
        {
            int player1 = int.Parse(Console.ReadLine());
            int player2 = int.Parse(Console.ReadLine());
            int maxfights = int.Parse(Console.ReadLine());
            int fights = 0;

            for (int pokemon1 = 1; pokemon1 <= player1; pokemon1++)
            {
                for (int pokemon2 = 1; pokemon2 <= player2; pokemon2++)
                {
                    Console.Write("({0} <-> {1}) ", pokemon1, pokemon2);
                    fights += 1; 
                    if (fights >= maxfights)
                    {
                        return;
                    }
                }
            }
        }
    }
}
