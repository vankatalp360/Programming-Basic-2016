using System;

namespace _09.VowelsSum
{
    class Program
    {
        static void Main()
        {
            string s = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i <= s.Length - 1; i++)
            {
                if (s[i] == 'a')
                {
                    sum += 1;
                }
                else if (s[i] == 'e')
                {
                    sum += 2;
                }
                else if (s[i] == 'i')
                {
                    sum += 3;
                }
                else if (s[i] == 'o')
                {
                    sum += 4;
                }
                else if (s[i] == 'u')
                {
                    sum += 5;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
