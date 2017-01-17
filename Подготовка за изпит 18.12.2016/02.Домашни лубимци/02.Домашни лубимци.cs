using System;

namespace _02.Домашни_лубимци
{
    class Program
    {
        static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            double food = double.Parse(Console.ReadLine());
            double dog = double.Parse(Console.ReadLine());
            double cat = double.Parse(Console.ReadLine());
            double turtle = double.Parse(Console.ReadLine());

            double eat = (dog + cat + (turtle  / 1000)) * days;
            food = food - eat;

            if (food >= 0)
            {
                food = Math.Floor(food);
                Console.WriteLine("{0} kilos of food left.", food);
            }
            else
            {
                food = Math.Abs(food);
                food = Math.Ceiling(food);
                Console.WriteLine("{0} more kilos of food are needed.", food);
            }
        }
    }
}
