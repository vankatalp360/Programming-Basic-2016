using System;


namespace Съединения_на_текст_и_числа
{
    class Program
    {
        static void Main()
        {
            string firstname = (Console.ReadLine());
            string lastname = (Console.ReadLine());
            string age = (Console.ReadLine());
            string town = (Console.ReadLine());
            string name = firstname + " " + lastname;
            Console.WriteLine("You are {0}, a {1}-years old person from {2}.", name, age, town);
        }
    }
}
