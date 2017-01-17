using System;

namespace _02.Смяна_на_плочки
{
    class Program
    {
        static void Main()
        {
            double submoney = double.Parse(Console.ReadLine());
            double shirochpod = double.Parse(Console.ReadLine());
            double daljpod = double.Parse(Console.ReadLine());
            double strantrig = double.Parse(Console.ReadLine());
            double vistrig = double.Parse(Console.ReadLine());
            double cenaploch = double.Parse(Console.ReadLine());
            double summaistor = double.Parse(Console.ReadLine());
            double answer = 0;

            double pod = shirochpod * daljpod;
            double plochka = (strantrig * vistrig) / 2;
            double neobhodimploch = Math.Ceiling((pod / plochka) + 5);
            double obshtasum = (neobhodimploch * cenaploch) + summaistor;
            if (obshtasum <= submoney)
            {
                answer = submoney - obshtasum;
                Console.WriteLine("{0:F2} lv left.", answer);
            }
            else if (obshtasum > submoney)
            {
                answer = obshtasum - submoney;
                Console.WriteLine("You'll need {0:F2} lv more.", answer);
            }
            
        }
    }
}
