using System;

namespace _04.Болница
{
    class Program
    {
        static void Main()
        {
            int period = int.Parse(Console.ReadLine());
            int all = 0;
            int treated = 0;
            int untreated = 0;
            int doctors = 7;

            for (int row = 1; row <= period; row++)
            {
                int patient = int.Parse(Console.ReadLine());
                all += patient;

                if ((treated < untreated) && (row % 3 == 0))
                {
                    doctors += 1;
                }

                if (patient >= doctors)
                {
                    treated += doctors;
                }
                else
                {
                    treated += patient;
                }

                if (patient > doctors)
                {
                    untreated += (patient - doctors);
                }
            }
            Console.WriteLine("Treated patients: {0}.", treated);
            Console.WriteLine("Untreated patients: {0}.", untreated);
        }
    }
}
