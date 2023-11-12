int[] inputArray = Console.ReadLine()
    .Split(' ')
    .Select(int.Parse)
    .ToArray();

int middleRightElementIndex = inputArray.Length / 2;
int middleLeftElementIndex = middleRightElementIndex - 1;

double middleElementsAverages = (inputArray[middleLeftElementIndex] + inputArray[middleRightElementIndex]) / 2.0;

Console.WriteLine($"{ middleElementsAverages:F2}");

