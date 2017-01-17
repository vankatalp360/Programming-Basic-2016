using System;

namespace Операции_между_числа
{
    class Program
    {
        static void Main()
        {
            double N1 = double.Parse(Console.ReadLine());
            double N2 = double.Parse(Console.ReadLine());
            string Operation = Console.ReadLine();
            double Result = 0;
            string Result2;

            if (Operation == "+")
            {
                Result = N1 + N2;
                if (Result % 2 == 0)
                {
                    Result2 = "even";
                }
                else
                {
                    Result2 = "odd";
                }
                Console.WriteLine("{0} {1} {2} = {3} - {4}", N1, Operation, N2, Result, Result2);
            }
            else if (Operation == "-")
            {
                Result = N1 - N2;
                if (Result % 2 == 0)
                {
                    Result2 = "even";
                }
                else
                {
                    Result2 = "odd";
                }
                Console.WriteLine("{0} {1} {2} = {3} - {4}", N1, Operation, N2, Result, Result2);
            }
            else if (Operation == "*")
            {
                Result = N1 * N2;
                if (Result % 2 == 0)
                {
                    Result2 = "even";
                }
                else
                {
                    Result2 = "odd";
                }
                Console.WriteLine("{0} {1} {2} = {3} - {4}", N1, Operation, N2, Result, Result2);
            }
            else if (Operation == "/")
            {
                if (N2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", N1);
                }
                else
                {
                    Result = (N1 / N2);
                    Console.WriteLine("{0} / {1} = {2:F2}", N1, N2, Result);
                }
            }
            else if (Operation == "%")
            {
                if (N2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", N1);
                }
                else
                {
                    Result = N1 % N2;
                    Console.WriteLine("{0} % {1} = {2}", N1, N2, Result);
                }
            }
        }
    }
}
