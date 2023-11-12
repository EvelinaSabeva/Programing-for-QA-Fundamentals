using System;

namespace _07.HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int countOfEvening = int.Parse(Console.ReadLine());
            double priceForStudio = 0.0;
            double priceForApartament = 0.0;



            //За студио, при повече от 7 нощувки през май и октомври: 5 % намаление.
            //За студио, при повече от 14 нощувки през май и октомври: 30 % намаление.
            //За студио, при повече от 14 нощувки през юни и септември: 20 % намаление.
            //За апартамент, при повече от 14 нощувки, без значение от месеца : 10 % намаление

            double fivePercent = 5.0 / 100.0;
            double tenPercent = 10.0 / 100.0;
            double twentyPercent = 20.0 / 100.0;
            double thirtyPercent = 30.0 / 100.0;

            if (month == "May" || month == "October")
            {
                priceForStudio = 50.0;
                priceForApartament = 65.0;

                if (countOfEvening > 7 && countOfEvening <= 14)
                {
                    priceForStudio -= priceForStudio * fivePercent;

                }
                else if (countOfEvening > 14)
                {
                    priceForStudio -= priceForStudio * thirtyPercent;
                    priceForApartament -= priceForApartament * tenPercent;
                }

            }
            else if (month == "June" || month == "September")
            {
                priceForStudio = 75.20;
                priceForApartament = 68.70;

                if (countOfEvening > 14)
                {
                    priceForStudio -= priceForStudio * twentyPercent;
                    priceForApartament -= priceForApartament * tenPercent;

                }
            }
            else if (month == "July" || month == "August")
            {
                priceForStudio = 76.0;
                priceForApartament = 77.0;

                if (countOfEvening > 14)
                {
                    priceForApartament -= priceForApartament * tenPercent;
                }
            }
            //else
            //{
            //    if (countOfEvening > 14)
            //    {
            //        priceForApartament -= priceForApartament * 0.1;
            //    }
            //}


            double totalPriceForApartament = countOfEvening * priceForApartament;
            double totalPriceForStudio = countOfEvening * priceForStudio;
            Console.WriteLine($"Apartment: { totalPriceForApartament:F2} lv.");
            Console.WriteLine($"Studio: {totalPriceForStudio:F2} lv.");
        }
    }
}
