using System;

namespace _03.NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вид цветя -текст с възможности -"Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus

            //Брой цветя -цяло число в интервала[10…1000]

            //   Бюджет - цяло число в интервала[50…2500]

            string typeOfFlowers = Console.ReadLine();
            int countOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double priceForTypeOfFlowers = 0;
            double totalPriceForTypeOfFlower = 0;
            //Ако Нели купи повече от 80 Рози - 10 % отстъпка от крайната цена
            //•	Ако Нели купи повече от 90  Далии - 15 % отстъпка от крайната цена
            //•	Ако Нели купи повече от 80 Лалета - 15 % отстъпка от крайната цена
            //•	Ако Нели купи по-малко от 120 Нарциса - цената се оскъпява с 15 %
            //•	Ако Нели Купи по-малко от 80 Гладиоли - цената се оскъпява с 20 %
            //"Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"

            switch (typeOfFlowers)
            {
                case "Roses":
                    priceForTypeOfFlowers = 5.0;
                    totalPriceForTypeOfFlower = countOfFlowers * priceForTypeOfFlowers;
                    if (countOfFlowers > 80)
                    {
                        totalPriceForTypeOfFlower = totalPriceForTypeOfFlower - 0.1 * totalPriceForTypeOfFlower;
                    }
                    break;
                case "Dahlias":
                    priceForTypeOfFlowers = 3.80;
                    totalPriceForTypeOfFlower = countOfFlowers * priceForTypeOfFlowers;
                    if (countOfFlowers > 90)
                    {
                        totalPriceForTypeOfFlower = totalPriceForTypeOfFlower - 0.15 * totalPriceForTypeOfFlower;
                    }
                    break;
                case "Tulips":
                    priceForTypeOfFlowers = 2.80;
                    totalPriceForTypeOfFlower = countOfFlowers * priceForTypeOfFlowers;
                    if (countOfFlowers > 80)
                    {
                        totalPriceForTypeOfFlower = totalPriceForTypeOfFlower - 0.15 * totalPriceForTypeOfFlower;
                    }
                    break;
                case "Narcissus":
                    priceForTypeOfFlowers = 3.0;
                    totalPriceForTypeOfFlower = countOfFlowers * priceForTypeOfFlowers;
                    if (countOfFlowers < 120)
                    {
                        totalPriceForTypeOfFlower = totalPriceForTypeOfFlower + 0.15 * totalPriceForTypeOfFlower;
                    }
                    break;
                case "Gladiolus":
                    priceForTypeOfFlowers = 2.50;
                    totalPriceForTypeOfFlower = countOfFlowers * priceForTypeOfFlowers;
                    if (countOfFlowers < 80)
                    {
                        totalPriceForTypeOfFlower = totalPriceForTypeOfFlower + 0.2 * totalPriceForTypeOfFlower;
                    }
                    break;
            }
            if (budget >= totalPriceForTypeOfFlower)
            {
                double leftSum = budget - totalPriceForTypeOfFlower;
                Console.WriteLine($"Hey, you have a great garden with {countOfFlowers} {typeOfFlowers} and {leftSum:F2} leva left.");


            }
            else if (totalPriceForTypeOfFlower > budget)
            {
                double needSum = totalPriceForTypeOfFlower - budget;
                Console.WriteLine($"Not enough money, you need {needSum:F2} leva more.");
            }
        }
    }
}
