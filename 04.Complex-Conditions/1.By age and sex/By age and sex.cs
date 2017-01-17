using System;

namespace _1.By_age_and_sex
{
    class Program
    {
        static void Main()
        {
            double age = double.Parse(Console.ReadLine());
            string sex = Console.ReadLine();
            
            if (sex == "f")
            {
                if (age >= 16)
                {
                    Console.WriteLine("Ms.");
                }
                else
                {
                    Console.WriteLine("Miss");
                }
            }
            else if (sex == "m")
            {
                if (age >= 16)
                {
                    Console.WriteLine("Mr.");
                }
                else
                {
                    Console.WriteLine("Master");
                }
            }
        }
    }
}
