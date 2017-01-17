using System;

namespace Навреме_за_изпит
{
    class Program
    {
        static void Main()
        {
            int ExamHour = int.Parse(Console.ReadLine());
            int ExamMinut = int.Parse(Console.ReadLine());
            int AriveHour = int.Parse(Console.ReadLine());
            int AriveMinut = int.Parse(Console.ReadLine());
            int AriveTime = 0;
            int ExamTime = 0;
            string answer = "";

            ExamHour = ExamHour * 60;
            ExamTime = ExamHour + ExamMinut;
            AriveHour = AriveHour * 60;
            AriveTime = AriveHour + AriveMinut;
            int AEdiff = AriveTime - ExamTime;
            int EAdiff = ExamTime - AriveTime;
            int EAhour = 0;
            int EAmin = 0;
            int AEhour = 0;
            int AEmin = 0;

            if ((ExamTime - AriveTime) <= 30 && (ExamTime - AriveTime) >= 0)
            {
                answer = "On time";
            }
            if ((ExamTime - AriveTime) > 30)
            {
                answer = "Early";
            }
            if ((AriveTime - ExamTime) > 0)
            {
                answer = "Late";
            }
            ExamHour = ExamHour / 60;
            AriveHour = AriveHour / 60;

            if (EAdiff >= 60)
            {
                EAhour = EAdiff / 60;
                EAmin = EAdiff - (EAhour * 60); 
            }
            if (AEdiff >= 60)
            {
                AEhour = AEdiff / 60;
                AEmin = AEdiff - (AEhour * 60);
            }            

            if ((answer == "Late") && ((AriveTime - ExamTime) < 60))
            {
                Console.WriteLine("Late {0} minutes after the start", (AriveTime - ExamTime));
            }
            else if ((answer == "Late") && ((AriveTime - ExamTime) >= 60))
            {
                if (AEmin >= 10)
                {
                    Console.WriteLine("Late {0}:{1} hours after the start", AEhour, AEmin);
                }
                else
                {
                    Console.WriteLine("Late {0}:0{1} hours after the start", AEhour, AEmin);
                }
                
            }
            else if ((answer == "Early") && ((ExamTime - AriveTime) < 60))
            {
                Console.WriteLine("Early {0} minutes before the start", (ExamTime - AriveTime));
            }
            else if ((answer == "Early") && ((ExamTime - AriveTime) >= 60))
            {
                if (EAmin < 10)
                {
                    Console.WriteLine("Early {0}:0{1} hours before the start", EAhour, EAmin);
                }
                else
                {
                    Console.WriteLine("Early {0}:{1} hours before the start", EAhour, EAmin);
                }
            }
            else if ((answer == "On time") && (ExamTime == AriveTime))
            {
                Console.WriteLine("On time");
            }
            else if ((answer == "On time") && ((ExamTime - AriveTime) <= 30))
            {
                Console.WriteLine("On time {0} minutes before the start", (ExamTime - AriveTime));
            }
        }
    }
}
