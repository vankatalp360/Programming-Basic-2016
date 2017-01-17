using System;

namespace _06.Комбинация_от_букви
{
    class Program
    {
        static void Main()
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char word = char.Parse(Console.ReadLine());
            int count = 0;

            for (char wordfirst = first; wordfirst <= second; wordfirst++)
            {
                for (char wordsec = first; wordsec <= second; wordsec++)
                {
                    for (char wordthird = first; wordthird <= second; wordthird++)
                    {
                        if (wordfirst != word && wordsec != word && wordthird != word)
                        {
                            Console.Write("{0}{1}{2} ", wordfirst, wordsec, wordthird);
                            count += 1;
                        }
                    }
                }
            }
            Console.Write(count);
            Console.WriteLine();
        }
    }
}
