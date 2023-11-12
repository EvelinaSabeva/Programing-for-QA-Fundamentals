using System;

namespace _05.Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = " ";
            string type = " ";
            double spendMoney = 0;

            if (budget <= 100)
            {
                destination = "Bulgaria";

                if (season == "summer")
                {
                    spendMoney = 0.3 * budget;
                    type = "Camp";
                }
                else if (season == "winter")
                {
                    spendMoney = 0.7 * budget;
                    type = "Hotel";
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";

                if (season == "summer")
                {
                    spendMoney = 0.4 * budget;
                    type = "Camp";
                }
                else if (season == "winter")
                {
                    spendMoney = 0.8 * budget;
                    type = "Hotel";
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                spendMoney = 0.9 * budget;
                type = "Hotel";

            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{ type} - { spendMoney :F2}");

        }
    }
}
