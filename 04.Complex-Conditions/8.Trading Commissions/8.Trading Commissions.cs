using System;

namespace _8.Trading_Commissions
{
    class Program
    {
        static void Main()
        {
            string City = Console.ReadLine();
            double sells = double.Parse(Console.ReadLine());
            double commissions = 0;

            if (City == "Sofia")
            {
                if (sells >= 0 && sells <= 500) commissions = (sells / 100) * 5;
                else if (sells > 500 && sells <= 1000) commissions = (sells / 100) * 7;
                else if (sells > 1000 && sells <= 10000) commissions = (sells / 100) * 8;
                else if (sells > 10000) commissions = (sells / 100) * 12;      
            }
            else if (City == "Varna")
            {
                if (sells >= 0 && sells <= 500) commissions = (sells / 100) * 4.5;
                else if (sells > 500 && sells <= 1000) commissions = (sells / 100) * 7.5;
                else if (sells > 1000 && sells <= 10000) commissions = (sells / 100) * 10;
                else if (sells > 10000) commissions = (sells / 100) * 13;
            }
            else if (City == "Plovdiv")
            {
                if (sells >= 0 && sells <= 500) commissions = (sells / 100) * 5.5;
                else if (sells > 500 && sells <= 1000) commissions = (sells / 100) * 8;
                else if (sells > 1000 && sells <= 10000) commissions = (sells / 100) * 12;
                else if (sells > 10000) commissions = (sells / 100) * 14.5;
            }
            commissions = Math.Round(commissions, 2);
            if (City != "Sofia" && City != "Plovdiv" && City != "Varna" || commissions <= 0)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine(commissions);
            }
        }
    }
}
