using System;

namespace _9.Volleybal
{
    class Program
    {
        static void Main(string[] args)
        {

            //Първият ред съдържа думата "leap"(високосна година) или "normal"(невисокосна).
            //Вторият ред съдържа цялото число p – брой празници в годината(които не са събота и неделя).
            //Третият ред съдържа цялото число h – брой уикенди, в които Влади си пътува до родния град.

            string year = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());


            int volleyballWeekends = 48;
            int voleyballWikendsInSofia = volleyballWeekends - h;
            double volleyballTimeInSofia = voleyballWikendsInSofia * (3.0 / 4.0);
            double volleyballTimeInHolidays = p * (2.0 / 3.0);
            double totalVoleyballTimeForYear = volleyballTimeInSofia + volleyballTimeInHolidays + h;

            switch (year)
            {
                case "leap":
                    totalVoleyballTimeForYear = totalVoleyballTimeForYear + (totalVoleyballTimeForYear * 0.15);
                    break;
                default:
                    break;
            }

            Console.WriteLine($"{Math.Floor(totalVoleyballTimeForYear)}");
        }
    }
}









