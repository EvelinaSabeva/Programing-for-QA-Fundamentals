using System;

namespace _08.OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {

            int hourForTheExam = int.Parse(Console.ReadLine());
            int minutesForTheExam = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());

            string late = "Late";
            string onTime = "On Time";
            string early = "Early";

            int hourMinutesDifference = (arrivalHour - hourForTheExam) * 60;
            int minutesDiffrence = arrivalMinutes - minutesForTheExam;
            int difference = hourMinutesDifference + minutesDiffrence;

            if(difference > 0)
            {
                Console.WriteLine(late);
                if(difference >= 1)
                {
                    if(difference < 60)
                    {
                        Console.WriteLine($"{difference} minutes after the start");
                    }
                    else
                    {
                        Console.WriteLine($"{difference/ 60}: {(difference % 60):D2} hours after the start");
                    }
                }

            }
            else if(difference >= - 30)
            {
                Console.WriteLine(onTime);
                difference = Math.Abs(difference);
                if (difference >= 1)
                {
                    if (difference < 60)
                    {
                        Console.WriteLine($"{difference} minutes before the start");
                    }
                    else
                    {
                        Console.WriteLine($"{difference / 60}: {(difference % 60):D2} hours before the start");
                    }
                }
            }
            else
            {
                Console.WriteLine(early);
                difference = Math.Abs(difference);
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
                else
                {
                    Console.WriteLine($"{difference / 60}: {(difference % 60):D2} hours before the start");
                }
            }

            //if (hourForTheExam == arrivalHour)
            //{
            //    int difference = arrivalMinutes - minutesForTheExam;
            //    int absoluteDifference = Math.Abs(difference);
            //    if (difference >= -30 && difference <= 0) // absoluteDifference <= 30 && arrivalMinutes < minutesOfExam
            //    {
            //        Console.WriteLine($"{onTime}");
            //    }
            //    else
            //    {
            //        if (difference < 0)
            //        {
            //            Console.WriteLine($"{early}");
            //            if (absoluteDifference > 1)
            //            {
            //                Console.WriteLine($"{absoluteDifference} minutes before the start");
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{late}");
            //            if (absoluteDifference > 1)
            //            {
            //                Console.WriteLine($"{absoluteDifference} minutes after the start");
            //            }
            //        }
            //    }
            //}
            //else
            //{
            //    int difference = arrivalHour - hourForTheExam;
            //    int absoluteDifferenceHours = Math.Abs(difference);
            //    int absoluteDifferenceMinutes = Math.Abs(arrivalMinutes - minutesForTheExam);

            //    if (absoluteDifferenceHours == 1 && arrivalHour < hourForTheExam)
            //    {
            //        absoluteDifferenceMinutes = Math.Abs((60 + minutesForTheExam) - arrivalMinutes);

            //        if (absoluteDifferenceMinutes <= 30)
            //        {
            //            Console.WriteLine($"{onTime}");
            //            if (absoluteDifferenceMinutes > 1)
            //            {
            //                Console.WriteLine($"{absoluteDifferenceMinutes} minutes before the start");
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{early}");
            //            if (absoluteDifferenceMinutes > 1)
            //            {
            //                Console.WriteLine($"{absoluteDifferenceMinutes} minutes before the start");
            //            }
            //        }
            //    }
            //    else
            //    {

            //        if (difference < 0)
            //        {
            //            Console.WriteLine($"{early}");
            //            Console.WriteLine($"{absoluteDifferenceHours}:{absoluteDifferenceMinutes:D2} hours before the start");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{late}");
            //            Console.WriteLine($"{absoluteDifferenceHours}:{absoluteDifferenceMinutes:D2} hours after the start");
            //        }
            //    }
            //}

            //if (hourForTheExam != arrivalHour && minutesForTheExam != arrivalMinutes)
            //{

            //    int hourMinutes = (arrivalHour - hourForTheExam) * 60;
            //    int minutes = arrivalMinutes - minutesForTheExam;
            //    int totalMinutes = hourMinutes + minutes;

            //    if (hourMinutes - hourForTheExam >30)
            //    {
            //        Console.WriteLine($"{late}");
            //        Console.WriteLine(" mm minutes after the start:D2");

            //    }
            //    else if (hourMinutes - hourForTheExam >= 60)
            //    {
            //        Console.WriteLine($"{late}");
            //        Console.WriteLine("hh: mm hours after the start:D2");
            //    }
            //    else if ( hourForTheExam - hourMinutes >30)

            //    {
            //        Console.WriteLine($"{early}");
            //        Console.WriteLine(" mm minutes before the start:D2");

            //    }
            //    else if(hourForTheExam - hourMinutes >=60)
            //    {
            //        Console.WriteLine("hh: mm hours before the start:D2");
            //    }


            //}
            //else if (hourForTheExam == arrivalHour && minutesForTheExam == arrivalMinutes)
            //{
            //   if(hourForTheExam == arrivalHour && minutesForTheExam == arrivalMinutes)
            //    {
            //        Console.WriteLine($"{onTime}");
            //    }
            //    else 
            //    {
            //        Console.WriteLine($"{onTime}");
            //        Console.WriteLine("mm minutes before the start:D2");
            //    }

            //}

        }
    }
}
