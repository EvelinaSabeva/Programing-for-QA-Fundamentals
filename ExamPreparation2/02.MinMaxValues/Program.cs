int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int selection = int.Parse( Console.ReadLine());

int max = int.MinValue;
int min = int.MaxValue;

for (int i = 0; i < selection; i++)
{
    int currentNumbers = numbers[i];
    if (max < currentNumbers)
    {
        max = currentNumbers;
    }
    if (min > currentNumbers)
    {
        min = currentNumbers;
    }
}
Console.WriteLine(max);
Console.WriteLine(min);

