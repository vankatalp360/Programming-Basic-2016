using System;

namespace Познай_паролата
{
    class Program
    {
        static void Main()
        {
            string password = Console.ReadLine();
            if (password == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else if (password != "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Wrong password!");
            }            
        }
    }
}
