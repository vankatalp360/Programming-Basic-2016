using System;

namespace Пресмятане_с_дати_1000_дни_на_Земята
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            DateTime birthday = DateTime.ParseExact(input, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
            birthday = birthday.AddDays(999);
            Console.WriteLine(birthday.ToString("dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture));
        }
    }
}
